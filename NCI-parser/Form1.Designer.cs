namespace NCI_parser
{
    partial class NCI_Packet_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NCI_Packet_Form_TableLayoutPanel = new TableLayoutPanel();
            NCI_Packet_Buttpn_TableLayoutPanel = new TableLayoutPanel();
            NCI_Format_Generate_Button = new Button();
            Generate_NCI_Packet_Button = new Button();
            NCI_Packet_TableLayoutPanel = new TableLayoutPanel();
            NCI_Packet_Textbox = new TextBox();
            NCI_Packet_Format_GroupBox = new GroupBox();
            NCI_Packet_Format_TableLayoutPanel = new TableLayoutPanel();
            Message_Type_ComboBox = new ComboBox();
            Message_Type_Label = new Label();
            Packet_Boundary_Flag_ComboBox = new ComboBox();
            Group_Identifier_Label = new Label();
            Packet_Boundary_Flag_Label = new Label();
            Group_Identifier_TextBox = new TextBox();
            Opcode_Identifier_TextBox = new TextBox();
            Payload_Label = new Label();
            Payload_TextBox = new TextBox();
            Payload_Length_TextBox = new TextBox();
            Payload_Length_Label = new Label();
            Opcode_Identifier_Label = new Label();
            NCI_Packet_Form_TableLayoutPanel.SuspendLayout();
            NCI_Packet_Buttpn_TableLayoutPanel.SuspendLayout();
            NCI_Packet_TableLayoutPanel.SuspendLayout();
            NCI_Packet_Format_GroupBox.SuspendLayout();
            NCI_Packet_Format_TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NCI_Packet_Form_TableLayoutPanel
            // 
            NCI_Packet_Form_TableLayoutPanel.ColumnCount = 1;
            NCI_Packet_Form_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            NCI_Packet_Form_TableLayoutPanel.Controls.Add(NCI_Packet_Buttpn_TableLayoutPanel, 0, 1);
            NCI_Packet_Form_TableLayoutPanel.Controls.Add(NCI_Packet_TableLayoutPanel, 0, 0);
            NCI_Packet_Form_TableLayoutPanel.Dock = DockStyle.Fill;
            NCI_Packet_Form_TableLayoutPanel.Location = new Point(0, 0);
            NCI_Packet_Form_TableLayoutPanel.Name = "NCI_Packet_Form_TableLayoutPanel";
            NCI_Packet_Form_TableLayoutPanel.RowCount = 2;
            NCI_Packet_Form_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            NCI_Packet_Form_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            NCI_Packet_Form_TableLayoutPanel.Size = new Size(800, 450);
            NCI_Packet_Form_TableLayoutPanel.TabIndex = 0;
            // 
            // NCI_Packet_Buttpn_TableLayoutPanel
            // 
            NCI_Packet_Buttpn_TableLayoutPanel.ColumnCount = 2;
            NCI_Packet_Buttpn_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NCI_Packet_Buttpn_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NCI_Packet_Buttpn_TableLayoutPanel.Controls.Add(NCI_Format_Generate_Button, 1, 0);
            NCI_Packet_Buttpn_TableLayoutPanel.Controls.Add(Generate_NCI_Packet_Button, 0, 0);
            NCI_Packet_Buttpn_TableLayoutPanel.Dock = DockStyle.Fill;
            NCI_Packet_Buttpn_TableLayoutPanel.Location = new Point(3, 408);
            NCI_Packet_Buttpn_TableLayoutPanel.Name = "NCI_Packet_Buttpn_TableLayoutPanel";
            NCI_Packet_Buttpn_TableLayoutPanel.RowCount = 1;
            NCI_Packet_Buttpn_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NCI_Packet_Buttpn_TableLayoutPanel.Size = new Size(794, 39);
            NCI_Packet_Buttpn_TableLayoutPanel.TabIndex = 1;
            // 
            // NCI_Format_Generate_Button
            // 
            NCI_Format_Generate_Button.Dock = DockStyle.Fill;
            NCI_Format_Generate_Button.Location = new Point(400, 3);
            NCI_Format_Generate_Button.Name = "NCI_Format_Generate_Button";
            NCI_Format_Generate_Button.Size = new Size(391, 33);
            NCI_Format_Generate_Button.TabIndex = 9;
            NCI_Format_Generate_Button.Text = "Format";
            NCI_Format_Generate_Button.UseVisualStyleBackColor = true;
            NCI_Format_Generate_Button.Click += NCI_Format_Generate_Button_Click;
            // 
            // Generate_NCI_Packet_Button
            // 
            Generate_NCI_Packet_Button.Dock = DockStyle.Fill;
            Generate_NCI_Packet_Button.Location = new Point(3, 3);
            Generate_NCI_Packet_Button.Name = "Generate_NCI_Packet_Button";
            Generate_NCI_Packet_Button.Size = new Size(391, 33);
            Generate_NCI_Packet_Button.TabIndex = 7;
            Generate_NCI_Packet_Button.Text = "Generate";
            Generate_NCI_Packet_Button.UseVisualStyleBackColor = true;
            Generate_NCI_Packet_Button.Click += Generate_NCI_Packet_Button_Click;
            // 
            // NCI_Packet_TableLayoutPanel
            // 
            NCI_Packet_TableLayoutPanel.ColumnCount = 2;
            NCI_Packet_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NCI_Packet_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NCI_Packet_TableLayoutPanel.Controls.Add(NCI_Packet_Textbox, 1, 0);
            NCI_Packet_TableLayoutPanel.Controls.Add(NCI_Packet_Format_GroupBox, 0, 0);
            NCI_Packet_TableLayoutPanel.Dock = DockStyle.Fill;
            NCI_Packet_TableLayoutPanel.Location = new Point(3, 3);
            NCI_Packet_TableLayoutPanel.Name = "NCI_Packet_TableLayoutPanel";
            NCI_Packet_TableLayoutPanel.RowCount = 1;
            NCI_Packet_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NCI_Packet_TableLayoutPanel.Size = new Size(794, 399);
            NCI_Packet_TableLayoutPanel.TabIndex = 0;
            // 
            // NCI_Packet_Textbox
            // 
            NCI_Packet_Textbox.Dock = DockStyle.Fill;
            NCI_Packet_Textbox.Location = new Point(400, 3);
            NCI_Packet_Textbox.Multiline = true;
            NCI_Packet_Textbox.Name = "NCI_Packet_Textbox";
            NCI_Packet_Textbox.Size = new Size(391, 393);
            NCI_Packet_Textbox.TabIndex = 8;
            // 
            // NCI_Packet_Format_GroupBox
            // 
            NCI_Packet_Format_GroupBox.Controls.Add(NCI_Packet_Format_TableLayoutPanel);
            NCI_Packet_Format_GroupBox.Dock = DockStyle.Fill;
            NCI_Packet_Format_GroupBox.Location = new Point(3, 3);
            NCI_Packet_Format_GroupBox.Name = "NCI_Packet_Format_GroupBox";
            NCI_Packet_Format_GroupBox.Size = new Size(391, 393);
            NCI_Packet_Format_GroupBox.TabIndex = 0;
            NCI_Packet_Format_GroupBox.TabStop = false;
            NCI_Packet_Format_GroupBox.Text = "NCI Packet Format";
            // 
            // NCI_Packet_Format_TableLayoutPanel
            // 
            NCI_Packet_Format_TableLayoutPanel.ColumnCount = 2;
            NCI_Packet_Format_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NCI_Packet_Format_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Message_Type_ComboBox, 1, 0);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Message_Type_Label, 0, 0);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Packet_Boundary_Flag_ComboBox, 1, 1);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Group_Identifier_Label, 0, 2);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Packet_Boundary_Flag_Label, 0, 1);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Group_Identifier_TextBox, 1, 2);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Opcode_Identifier_TextBox, 1, 3);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Payload_Label, 0, 5);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Payload_TextBox, 1, 5);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Payload_Length_TextBox, 1, 4);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Payload_Length_Label, 0, 4);
            NCI_Packet_Format_TableLayoutPanel.Controls.Add(Opcode_Identifier_Label, 0, 3);
            NCI_Packet_Format_TableLayoutPanel.Dock = DockStyle.Fill;
            NCI_Packet_Format_TableLayoutPanel.Location = new Point(3, 23);
            NCI_Packet_Format_TableLayoutPanel.Name = "NCI_Packet_Format_TableLayoutPanel";
            NCI_Packet_Format_TableLayoutPanel.RowCount = 6;
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            NCI_Packet_Format_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            NCI_Packet_Format_TableLayoutPanel.Size = new Size(385, 367);
            NCI_Packet_Format_TableLayoutPanel.TabIndex = 3;
            // 
            // Message_Type_ComboBox
            // 
            Message_Type_ComboBox.Dock = DockStyle.Fill;
            Message_Type_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Message_Type_ComboBox.FormattingEnabled = true;
            Message_Type_ComboBox.Location = new Point(192, 0);
            Message_Type_ComboBox.Margin = new Padding(0);
            Message_Type_ComboBox.Name = "Message_Type_ComboBox";
            Message_Type_ComboBox.Size = new Size(193, 28);
            Message_Type_ComboBox.TabIndex = 1;
            Message_Type_ComboBox.SelectedIndexChanged += Message_Type_ComboBox_SelectedIndexChanged;
            // 
            // Message_Type_Label
            // 
            Message_Type_Label.Dock = DockStyle.Fill;
            Message_Type_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Message_Type_Label.Location = new Point(3, 0);
            Message_Type_Label.Name = "Message_Type_Label";
            Message_Type_Label.Padding = new Padding(3);
            Message_Type_Label.Size = new Size(186, 61);
            Message_Type_Label.TabIndex = 9;
            Message_Type_Label.Text = "Message Type:";
            Message_Type_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Packet_Boundary_Flag_ComboBox
            // 
            Packet_Boundary_Flag_ComboBox.Dock = DockStyle.Fill;
            Packet_Boundary_Flag_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Packet_Boundary_Flag_ComboBox.FormattingEnabled = true;
            Packet_Boundary_Flag_ComboBox.Location = new Point(192, 61);
            Packet_Boundary_Flag_ComboBox.Margin = new Padding(0);
            Packet_Boundary_Flag_ComboBox.Name = "Packet_Boundary_Flag_ComboBox";
            Packet_Boundary_Flag_ComboBox.Size = new Size(193, 28);
            Packet_Boundary_Flag_ComboBox.TabIndex = 2;
            // 
            // Group_Identifier_Label
            // 
            Group_Identifier_Label.Dock = DockStyle.Fill;
            Group_Identifier_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Group_Identifier_Label.Location = new Point(3, 125);
            Group_Identifier_Label.Margin = new Padding(3);
            Group_Identifier_Label.Name = "Group_Identifier_Label";
            Group_Identifier_Label.Size = new Size(186, 55);
            Group_Identifier_Label.TabIndex = 32;
            Group_Identifier_Label.Text = "Group Identifier:";
            Group_Identifier_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Packet_Boundary_Flag_Label
            // 
            Packet_Boundary_Flag_Label.Dock = DockStyle.Fill;
            Packet_Boundary_Flag_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Packet_Boundary_Flag_Label.Location = new Point(3, 61);
            Packet_Boundary_Flag_Label.Name = "Packet_Boundary_Flag_Label";
            Packet_Boundary_Flag_Label.Padding = new Padding(3);
            Packet_Boundary_Flag_Label.Size = new Size(186, 61);
            Packet_Boundary_Flag_Label.TabIndex = 11;
            Packet_Boundary_Flag_Label.Text = "Packet Boundary Flag:";
            Packet_Boundary_Flag_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Group_Identifier_TextBox
            // 
            Group_Identifier_TextBox.Dock = DockStyle.Fill;
            Group_Identifier_TextBox.Location = new Point(192, 122);
            Group_Identifier_TextBox.Margin = new Padding(0);
            Group_Identifier_TextBox.Name = "Group_Identifier_TextBox";
            Group_Identifier_TextBox.Size = new Size(193, 27);
            Group_Identifier_TextBox.TabIndex = 3;
            // 
            // Opcode_Identifier_TextBox
            // 
            Opcode_Identifier_TextBox.Dock = DockStyle.Fill;
            Opcode_Identifier_TextBox.Location = new Point(192, 183);
            Opcode_Identifier_TextBox.Margin = new Padding(0);
            Opcode_Identifier_TextBox.Name = "Opcode_Identifier_TextBox";
            Opcode_Identifier_TextBox.Size = new Size(193, 27);
            Opcode_Identifier_TextBox.TabIndex = 4;
            // 
            // Payload_Label
            // 
            Payload_Label.Dock = DockStyle.Fill;
            Payload_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Payload_Label.Location = new Point(3, 308);
            Payload_Label.Margin = new Padding(3);
            Payload_Label.Name = "Payload_Label";
            Payload_Label.Size = new Size(186, 56);
            Payload_Label.TabIndex = 29;
            Payload_Label.Text = "Payload:";
            Payload_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Payload_TextBox
            // 
            Payload_TextBox.Dock = DockStyle.Fill;
            Payload_TextBox.Location = new Point(192, 305);
            Payload_TextBox.Margin = new Padding(0);
            Payload_TextBox.Name = "Payload_TextBox";
            Payload_TextBox.Size = new Size(193, 27);
            Payload_TextBox.TabIndex = 6;
            // 
            // Payload_Length_TextBox
            // 
            Payload_Length_TextBox.Dock = DockStyle.Fill;
            Payload_Length_TextBox.Location = new Point(192, 244);
            Payload_Length_TextBox.Margin = new Padding(0);
            Payload_Length_TextBox.Name = "Payload_Length_TextBox";
            Payload_Length_TextBox.Size = new Size(193, 27);
            Payload_Length_TextBox.TabIndex = 5;
            Payload_Length_TextBox.TextChanged += Payload_Length_TextBox_TextChanged;
            // 
            // Payload_Length_Label
            // 
            Payload_Length_Label.Dock = DockStyle.Fill;
            Payload_Length_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Payload_Length_Label.Location = new Point(3, 247);
            Payload_Length_Label.Margin = new Padding(3);
            Payload_Length_Label.Name = "Payload_Length_Label";
            Payload_Length_Label.Size = new Size(186, 55);
            Payload_Length_Label.TabIndex = 27;
            Payload_Length_Label.Text = "Payload Length:";
            Payload_Length_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Opcode_Identifier_Label
            // 
            Opcode_Identifier_Label.Dock = DockStyle.Fill;
            Opcode_Identifier_Label.Font = new Font("Microsoft YaHei UI", 9F);
            Opcode_Identifier_Label.Location = new Point(3, 186);
            Opcode_Identifier_Label.Margin = new Padding(3);
            Opcode_Identifier_Label.Name = "Opcode_Identifier_Label";
            Opcode_Identifier_Label.Size = new Size(186, 55);
            Opcode_Identifier_Label.TabIndex = 25;
            Opcode_Identifier_Label.Text = "Opcode Identifier:";
            Opcode_Identifier_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // NCI_Packet_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NCI_Packet_Form_TableLayoutPanel);
            Name = "NCI_Packet_Form";
            Text = "NCI Packet Form";
            Load += NCI_Packet_Form_Load;
            NCI_Packet_Form_TableLayoutPanel.ResumeLayout(false);
            NCI_Packet_Buttpn_TableLayoutPanel.ResumeLayout(false);
            NCI_Packet_TableLayoutPanel.ResumeLayout(false);
            NCI_Packet_TableLayoutPanel.PerformLayout();
            NCI_Packet_Format_GroupBox.ResumeLayout(false);
            NCI_Packet_Format_TableLayoutPanel.ResumeLayout(false);
            NCI_Packet_Format_TableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel NCI_Packet_Form_TableLayoutPanel;
        private TableLayoutPanel NCI_Packet_TableLayoutPanel;
        private TableLayoutPanel NCI_Packet_Buttpn_TableLayoutPanel;
        private TextBox NCI_Packet_Textbox;
        private GroupBox NCI_Packet_Format_GroupBox;
        private Button NCI_Format_Generate_Button;
        private Button Generate_NCI_Packet_Button;
        private TableLayoutPanel NCI_Packet_Format_TableLayoutPanel;
        private ComboBox Message_Type_ComboBox;
        private Label Message_Type_Label;
        private ComboBox Packet_Boundary_Flag_ComboBox;
        private Label Group_Identifier_Label;
        private Label Packet_Boundary_Flag_Label;
        private TextBox Group_Identifier_TextBox;
        private TextBox Opcode_Identifier_TextBox;
        private Label Payload_Label;
        private TextBox Payload_TextBox;
        private TextBox Payload_Length_TextBox;
        private Label Payload_Length_Label;
        private Label Opcode_Identifier_Label;
    }
}
