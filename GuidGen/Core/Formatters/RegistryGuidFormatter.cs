using Cheer.Utilities.GuidGen.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheer.Utilities.GuidGen.Core.Formatters
{
    public class RegistryGuidFormatter
         : IGuidFormatter
    {
        private readonly string name;

        public RegistryGuidFormatter()
        {
            name = SR.Formatter_RegistryGuidFormatterName;
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
            return value.ToString("B").ToUpperInvariant();
        }
    }
}
