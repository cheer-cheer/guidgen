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
    public class CSharpGuidAttributeFormatter
         : IGuidFormatter
    {
        private readonly string name;

        public CSharpGuidAttributeFormatter()
        {
            name = SR.Formatter_CSharpGuidAttributeFormatterName;
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
            return string.Format(CultureInfo.InvariantCulture, "[global::{0}(\"{1}\")]", typeof(GuidAttribute), value);
        }
    }
}