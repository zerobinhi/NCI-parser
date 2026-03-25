using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NCI_parser
{
    #region Protocol Definitions

    public enum MessageType : byte
    {
        Data = 0b000,
        Command = 0b001,
        Response = 0b010,
        Notification = 0b011
    }

    public enum PacketBoundaryFlag : byte
    {
        Last = 0,
        NotLast = 1
    }

    #endregion

    public partial class NCI_Packet_Form : Form
    {
        public NCI_Packet_Form()
        {
            InitializeComponent();
        }

        private void NCI_Packet_Form_Load(object sender, EventArgs e)
        {
            Message_Type_ComboBox.DataSource = Enum.GetValues(typeof(MessageType));
            Packet_Boundary_Flag_ComboBox.DataSource = Enum.GetValues(typeof(PacketBoundaryFlag));

            Message_Type_ComboBox.SelectedItem = MessageType.Command;
            Packet_Boundary_Flag_ComboBox.SelectedItem = PacketBoundaryFlag.Last;

            UpdatePayloadTextBoxState();
        }

        #region Generate Packet (UI -> Bytes)

        private void Generate_NCI_Packet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] packet = BuildPacketFromUi();
                NCI_Packet_Textbox.Text = BitConverter.ToString(packet).Replace("-", " ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Generate Error");
            }
        }

        private byte[] BuildPacketFromUi()
        {
            var mt = (MessageType)Message_Type_ComboBox.SelectedItem;
            var pbf = (PacketBoundaryFlag)Packet_Boundary_Flag_ComboBox.SelectedItem;

            int payloadLen = NciValueParser.ParsePayloadLength(Payload_Length_TextBox.Text);
            byte[] payload = payloadLen > 0 ? NciValueParser.ParsePayload(Payload_TextBox.Text, Payload_Length_TextBox.Text) : Array.Empty<byte>();

            Payload_Length_TextBox.Text = NciValueParser.FormatPayloadLength(payloadLen);
            Payload_TextBox.Text = NciValueParser.FormatPayload(payload);

            List<byte> packet = new();

            // Data 和 Control 共用方法生成 Header
            int gid = NciValueParser.ParseGID(Group_Identifier_TextBox.Text);
            Group_Identifier_TextBox.Text = NciValueParser.FormatGID(gid);

            byte header0 = (byte)(((byte)mt << 5) | ((byte)pbf << 4) | gid);
            packet.Add(header0);

            if (mt == MessageType.Data)
            {
                packet.Add(0x00); // RFU
            }
            else
            {
                int oid = NciValueParser.ParseOID(Opcode_Identifier_TextBox.Text);
                Opcode_Identifier_TextBox.Text = NciValueParser.FormatOID(oid);
                packet.Add((byte)(oid & 0x3F)); // RFU[7:6]=0
            }

            packet.Add((byte)payloadLen);
            packet.AddRange(payload);

            return packet.ToArray();
        }

        #endregion

        #region Parse Packet (Bytes -> UI)

        private void NCI_Format_Generate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] packet = NciValueParser.ParseHex(NCI_Packet_Textbox.Text);
                ParsePacketToUi(packet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error");
            }
        }

        private void ParsePacketToUi(byte[] packet)
        {
            if (packet.Length < 3)
                throw new Exception("Packet too short.");

            byte b0 = packet[0];
            byte b1 = packet[1];
            MessageType mt = (MessageType)((b0 >> 5) & 0x07);
            PacketBoundaryFlag pbf = (PacketBoundaryFlag)((b0 >> 4) & 0x01);

            Message_Type_ComboBox.SelectedItem = mt;
            Packet_Boundary_Flag_ComboBox.SelectedItem = pbf;

            byte payloadLen = packet[2];

            if (packet.Length - 3 < payloadLen)
                throw new Exception($"Packet too short: Payload Length={payloadLen}, actual={packet.Length - 3}");

            if (packet.Length - 3 > payloadLen)
                throw new Exception($"Packet contains extra bytes beyond Payload Length: Payload Length={payloadLen}, actual={packet.Length - 3}");

            Payload_Length_TextBox.Text = NciValueParser.FormatPayloadLength(payloadLen);
            Payload_TextBox.Text = payloadLen > 0 ? NciValueParser.FormatPayload(packet.Skip(3).Take(payloadLen).ToArray()) : string.Empty;
            Payload_TextBox.Enabled = payloadLen > 0;

            int gid = b0 & 0x0F;
            Group_Identifier_TextBox.Text = NciValueParser.FormatGID(gid);

            if (mt == MessageType.Data)
            {
                Opcode_Identifier_TextBox.Enabled = false;
            }
            else
            {
                int oid = b1 & 0x3F;
                Opcode_Identifier_TextBox.Text = NciValueParser.FormatOID(oid);
            }
        }

        #endregion

        #region UI Helpers

        private void Payload_Length_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePayloadTextBoxState();
        }

        private void UpdatePayloadTextBoxState()
        {
            try
            {
                int len = NciValueParser.ParsePayloadLength(Payload_Length_TextBox.Text);
                Payload_TextBox.Enabled = len > 0;
                if (!Payload_TextBox.Enabled) Payload_TextBox.Clear();
            }
            catch
            {
                Payload_TextBox.Enabled = false;
                Payload_TextBox.Clear();
            }
        }

        private void Message_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((MessageType)Message_Type_ComboBox.SelectedItem == MessageType.Data)
            {
                Opcode_Identifier_TextBox.Enabled = false;
            }
            else
            {
                Opcode_Identifier_TextBox.Enabled = true;
            }
        }

        #endregion
    }
}
