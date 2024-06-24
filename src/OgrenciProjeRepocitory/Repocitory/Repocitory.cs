using OgrenciProjeRepocitory.Models.Data;
using OgrenciProjeRepocitory.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OgrenciProjeRepocitory.Models.Data.OgrenciContext;

namespace OgrenciProjeRepocitory.Repocitory
{
    public class Repocitory
    {       
        public class RepBolum: BaseRepocitory<Bolum>
        {
            public RepBolum(OgrenciContext db): base(db) 
            {
                // Database bağlantısı için bu
            }
        }

        public class RepOgrenci : BaseRepocitory<Ogrenci>
        {
            public RepOgrenci(OgrenciContext db) : base(db)
            {
                // Database bağlantısı için bu
            }
            public ICollection<OgrenciDTO> GetOgrenciler(int id)
            {
                return Set().Select(x => new OgrenciDTO
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    BolumId = x.BolumId
                }).Where(x => x.BolumId == id).ToList();
            }
        }
    }
}
