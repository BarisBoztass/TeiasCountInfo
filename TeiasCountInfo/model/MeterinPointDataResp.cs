using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiasCountInfo.model
{
    class MeterinPointDataResp
    {
        public string status { get; set; }
        public string errorCode { get; set; }
        public string cause { get; set; }
        List<VhsRespBody> vhsRespBodies { get; set; }

    }
}
