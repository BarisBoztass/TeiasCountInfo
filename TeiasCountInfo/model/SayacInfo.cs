﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiasCountInfo.model
{
   public class SayacInfo
    {
        public string eic { get; set; }
        public DateTime olcumZamani { get; set; }
        public int period { get; set; }
        public float tuketim { get; set; }
        public float uretim { get; set; }
        public float cekisEnduktif { get; set; }
        public float cekisKapasitif { get; set; }
        public float verisEnduktif { get; set; }
        public float verisKapasitif { get; set; }
    }
}
