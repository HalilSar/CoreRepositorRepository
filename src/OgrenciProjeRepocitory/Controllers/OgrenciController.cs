using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OgrenciProjeRepocitory.Models.View;
using static OgrenciProjeRepocitory.Repocitory.Repocitory;
using OgrenciProjeRepocitory.Models.Data;
using static OgrenciProjeRepocitory.Models.Data.OgrenciContext;
using OgrenciProjeRepocitory.Models.DTO;

namespace OgrenciProjeRepocitory.Controllers
    
{
    public class OgrenciController : Controller
    {
        OgrenciModel _Model;
        RepOgrenci _repOgrenci;

        public OgrenciController(RepOgrenci repOgrenci, OgrenciModel Model)
        {
            _Model = Model;
            _repOgrenci = repOgrenci;
        }
        public IActionResult ListById(int id)
        {
            _Model.olist = _repOgrenci.GetOgrenciler(id);

            return View(_Model);
        }
    }
}