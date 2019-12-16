using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OgrenciProjeRepocitory.Models.View;
using static OgrenciProjeRepocitory.Models.Data.OgrenciContext;
using static OgrenciProjeRepocitory.Repocitory.Repocitory;

namespace OgrenciProjeRepocitory.Controllers
{
    public class BolumController : Controller
    {
        RepBolum _repBolum;
        BolumModel _model;
        public BolumController(RepBolum repBolum,BolumModel model)
        {
            _repBolum = repBolum;
            _model = model;
        }

        public async Task< IActionResult >Liste()
        {
            _model.Blist = await _repBolum.List();
            return View(_model);
        }
        

        [HttpGet]
        public async Task<IActionResult> Guncel(int id)
        {
            _model.bolum = await _repBolum.Find(id);
            _model.Baslik = "Güncelleme";
            _model.Mode = "Guncel"; //Metot ismi ile  aynı olmak zorunda bu kısım.
            _model.BtnText = "Güncelle";
            _model.BtnColor = "btn btn-primary";
            return View(_model);
        }
        [HttpPost]
        public async Task <IActionResult> Guncel(BolumModel model)
        {
            _repBolum.Update(model.bolum);
            await _repBolum.Comit();
            return RedirectToAction("Liste");
        }


        [HttpGet]
        public async Task<IActionResult> Sil(int id)
        {
            _model.bolum = await _repBolum.Find(id);
            _model.Baslik = "Silme İşlemi";
            _model.Mode = "Sil"; //Metot ismi ile  aynı olmak zorunda bu kısım.
            _model.BtnText = "Sil";
            _model.BtnColor = "btn btn-danger";
            return View("Guncel",_model);
        }
        [HttpPost]
        public async Task<IActionResult> Sil(BolumModel model)
        {
            _repBolum.Delete(model.bolum);
            await _repBolum.Comit();
            return RedirectToAction("Liste");
        }


        [HttpGet]
        public IActionResult Giris()
        {
            _model.Baslik = "Yeni Giris";
            _model.Mode = "Giris"; //Metot ismi ile  aynı olmak zorunda bu kısım.
            _model.BtnText = "Yeni Giris";
            _model.BtnColor = "btn btn-danger";
            return View("Guncel", _model);
        }
        [HttpPost]
        public async Task<IActionResult> Giris(BolumModel model)
        {
            _repBolum.Entry(model.bolum);
            await _repBolum.Comit();
            return RedirectToAction("Liste");
        }
    }
}