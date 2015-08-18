using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSegmentExchangePattern
{
    public interface IModel
    {
        List<Segment> Outputs { get; set; }

        List<Data> Requirements { get; set; }
    }
}
