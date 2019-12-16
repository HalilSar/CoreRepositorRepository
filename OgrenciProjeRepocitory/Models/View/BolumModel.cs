using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OgrenciProjeRepocitory.Models.Data.OgrenciContext;

namespace OgrenciProjeRepocitory.Models.View
{
    public class BolumModel
    {
        public ICollection<Bolum> Blist { get; set; }
        public Bolum bolum { get; set; }
        public string Baslik { get; set; }
        public string Mode { get; set; }
        public string BtnText { get; set; }
        public string BtnColor { get; set; }
    }
}
