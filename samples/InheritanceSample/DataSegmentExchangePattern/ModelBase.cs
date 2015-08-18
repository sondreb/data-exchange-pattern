using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSegmentExchangePattern
{
    public abstract class ModelBase : IModel
    {
        public List<Segment> Outputs { get; set; } = new List<Segment>();
        
        public List<Data> Requirements { get; set; } = new List<Data>();
    }
}
