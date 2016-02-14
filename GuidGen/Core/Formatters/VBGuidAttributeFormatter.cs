using Cheer.Utilities.GuidGen.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cheer.Utilities.GuidGen.Core.Formatters
{
    public class VBGuidAttributeFormatter
         : IGuidFormatter
    {
        private readonly string name;

        public VBGuidAttributeFormatter()
        {
            name = SR.Formatter_VBGuidAttributeFormatterName;
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
            //global:System.Runtime.InteropServices.GuidAttribute
            // [Guid("B7BAD1AF-A0E5-4AC3-9B40-EAE56717AFB7")]
            return string.Format(CultureInfo.InvariantCulture, "<{0}(\"{1}\")>", typeof(GuidAttribute), value);
        }
    }
}
