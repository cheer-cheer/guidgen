using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheer.Utilities.GuidGen.Core.Formatters
{
    public interface IGuidFormatter
    {
        string Name
        {
            get;
        }
        string Format(Guid value);
    }
}
