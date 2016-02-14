using Cheer.Utilities.GuidGen.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheer.Utilities.GuidGen.Core.Formatters
{
    public class OleCreateGuidFormatter
         : IGuidFormatter
    {
        private readonly string name;

        public OleCreateGuidFormatter()
        {
            name = SR.Formatter_OleCreateGuidFormatterName;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
         

        public string Format(Guid value)
        {
            var result = new StringBuilder();
            result.Append("// {");
            result.Append(value.ToString().ToUpperInvariant());
            result.AppendLine("}");
            result.Append("IMPLEMENT_OLECREATE(<<").Append(SR.Formatter_OleCreateGuidFormatter_ClassName).Append(">>");
            result.Append(", <<").Append(SR.Formatter_OleCreateGuidFormatter_ExternalName).Append(">>, ").AppendLine();

            var bytes = value.ToByteArray();
            result.AppendFormat(CultureInfo.InvariantCulture, "0x{0:x2}, 0x{1:x2}, 0x{2:x2}, 0x{3:x2}, 0x{4:x2}", 
                BitConverter.ToInt32(bytes, 0), BitConverter.ToInt16(bytes, 4), BitConverter.ToInt16(bytes, 6), bytes[8], bytes[9]);
            result.AppendFormat(CultureInfo.InvariantCulture, ", 0x{0:x2}, 0x{1:x2}, 0x{2:x2}, 0x{3:x2}, 0x{4:x2}, 0x{5:x2});", 
                bytes[10], bytes[11], bytes[12], bytes[13], bytes[14], bytes[15]);

            return result.ToString();
        }
    }
}
