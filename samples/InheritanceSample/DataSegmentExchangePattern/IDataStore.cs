using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSegmentExchangePattern
{
    public interface IDataStore
    {
        List<Segment> Segments { get; }

        T GetValueOrNull<T>(Data data) where T : class;
    }
}
