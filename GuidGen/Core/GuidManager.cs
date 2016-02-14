using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cheer.Utilities.GuidGen.Core.Formatters;
using System.Threading.Tasks;

namespace Cheer.Utilities.GuidGen.Core
{
    public class GuidManager
    {
        private Guid guid;

        private readonly List<IGuidFormatter> formatters;

        public GuidManager()
        {
            guid = Guid.NewGuid();

            formatters = new List<IGuidFormatter>();
            InitPreDefinedFormatters();
        }

        private void InitPreDefinedFormatters()
        {
            formatters.Add(new OleCreateGuidFormatter());
            formatters.Add(new DefineGuidFormatter());
            formatters.Add(new StaticConstGuidFormatter());
            formatters.Add(new RegistryGuidFormatter());
            formatters.Add(new CSharpGuidAttributeFormatter());
            formatters.Add(new VBGuidAttributeFormatter());
        }

        public Guid Guid
        {
            get
            {
                return guid;
            }
            set
            {
                guid = value;
            }
        }
        public List<IGuidFormatter> Formatters
        {
            get
            {
                return formatters;
            }
        }
        public string Format(IGuidFormatter formatter)
        {
            if (formatter == null)
            {
                throw new ArgumentNullException(nameof(formatter));
            }

            return formatter.Format(Guid);
        }
        public GuidManager NewGuid()
        {
            Guid = Guid.NewGuid();
            return this;
        }
    }
}
