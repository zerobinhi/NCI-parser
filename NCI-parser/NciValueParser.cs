using System;
using System.Globalization;
using System.Linq;

namespace NCI_parser
{
    public static class NciValueParser
    {
        #region GID / OID

        public static int ParseGID(string text) => ParseBinaryDecimalHex(text, 0, 15, "GID");
        public static string FormatGID(int value)
        {
            if (value < 0 || value > 15) throw new Exception($"GID out of range: {value}");
            return "0b" + Convert.ToString(value, 2).PadLeft(4, '0');
        }

        public static int ParseOID(string text) => ParseBinaryDecimalHex(text, 0, 63, "OID");
        public static string FormatOID(int value)
        {
            if (value < 0 || value > 63) throw new Exception($"OID out of range: {value}");
            return "0b" + Convert.ToString(value, 2).PadLeft(6, '0');
        }

        #endregion

        #region Payload Length

        public static int ParsePayloadLength(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;
            return ParseBinaryDecimalHex(text, 0, 255, "Payload Length");
        }

        public static string FormatPayloadLength(int value)
        {
            if (value < 0 || value > 255) throw new Exception($"Payload Length out of range: {value}");
            return "0x" + value.ToString("X2");
        }

        #endregion

        #region Payload

        public static byte[] ParsePayload(string text, string lengthText)
        {
            int length = ParsePayloadLength(lengthText);

            if (length == 0)
            {
                if (!string.IsNullOrWhiteSpace(text))
                    throw new Exception("Payload Length is 0, but Payload is not empty.");
                return Array.Empty<byte>();
            }

            if (string.IsNullOrWhiteSpace(text))
                throw new Exception("Payload cannot be empty when Payload Length > 0.");

            string[] parts = text.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != length)
                throw new Exception($"Payload length mismatch: {parts.Length} bytes provided, expected {length}.");

            byte[] payload = new byte[length];
            for (int i = 0; i < length; i++)
            {
                if (!byte.TryParse(parts[i], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out payload[i]))
                    throw new Exception($"Invalid hex byte in payload: {parts[i]}");
            }

            return payload;
        }

        public static string FormatPayload(byte[] data)
        {
            if (data == null || data.Length == 0) return string.Empty;
            return string.Join(" ", data.Select(b => b.ToString("X2")));
        }

        #endregion

        #region Helpers

        /// <summary>
        /// 自动识别二 / 十 / 十六进制
        /// 规则：
        /// 0bxxxx -> 二进制
        /// 仅包含 0/1 -> 十进制
        /// 0xXX 或包含 A-F -> 十六进制
        /// 其他纯数字 -> 十进制
        /// 其他异常 -> 异常
        /// </summary>
        private static int ParseBinaryDecimalHex(string text, int min, int max, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new Exception($"{fieldName} is empty.");

            text = text.Trim();
            int value;

            if (text.StartsWith("0b", StringComparison.OrdinalIgnoreCase))
            {
                value = Convert.ToInt32(text[2..], 2);
            }
            else if (text.All(c => c == '0' || c == '1'))
            {
                // 纯 0/1 -> 十进制
                value = int.Parse(text, NumberStyles.None, CultureInfo.InvariantCulture);
            }
            else if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ||
                     text.Any(c => "ABCDEFabcdef".Contains(c)))
            {
                value = Convert.ToInt32(text.Replace("0x", ""), 16);
            }
            else if (text.All(char.IsDigit))
            {
                value = int.Parse(text, NumberStyles.None, CultureInfo.InvariantCulture);
            }
            else
            {
                throw new Exception($"Invalid {fieldName} input: {text}");
            }

            if (value < min || value > max)
                throw new Exception($"{fieldName} out of range ({min}-{max}): {value}");

            return value;
        }

        /// <summary>
        /// 支持连续或空格分隔十六进制字符串
        /// </summary>
        public static byte[] ParseHex(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return Array.Empty<byte>();

            text = text.Replace(" ", "").Replace("0x", "");

            if (text.Length % 2 != 0)
                throw new Exception("Invalid hex string length.");

            byte[] data = new byte[text.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                if (!byte.TryParse(text.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out data[i]))
                    throw new Exception($"Invalid hex byte: {text.Substring(i * 2, 2)}");
            }
            return data;
        }

        #endregion
    }
}
