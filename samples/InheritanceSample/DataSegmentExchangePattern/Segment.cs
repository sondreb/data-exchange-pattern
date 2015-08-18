using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSegmentExchangePattern
{
    public class Segment
    {
        private object value;

        public Segment(Data key)
        {
            this.Key = key;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Data Key { get; private set; }

        public object Value
        {
            get
            {
                return value;
            }
        }

        public bool HasValue
        {
            get
            {
                return value != null;
            }
        }
    }
}
