using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiasCountInfo.model
{
    public class MeteringPointDataReq
    {
        public DateTime baslangicDt{ get; set; }
        public DateTime bitisDt { get; set; }
        public int period { get; set; }
        public List<SayacEicList> sayacEicLists { get; set; }

    }
}
