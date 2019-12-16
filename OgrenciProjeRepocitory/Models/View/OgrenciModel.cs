using OgrenciProjeRepocitory.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OgrenciProjeRepocitory.Models.Data.OgrenciContext;

namespace OgrenciProjeRepocitory.Models.View
{
    public class OgrenciModel
    {
        public ICollection<OgrenciDTO> olist { get; set; }
    }
}
