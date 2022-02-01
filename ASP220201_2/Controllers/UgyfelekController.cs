using ASP220201_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220201_2.Controllers
{
    public class UgyfelekController : Controller
    {
        //kamu db:
        private static List<Ugyfel> _ugyfelek = new List<Ugyfel>()
        {
            new Ugyfel() { Id = 1, Nev = "Lapos Elemér", Szuletett = new DateTime(1987, 07, 01), },
            new Ugyfel() { Id = 2, Nev = "Para Zita", Szuletett = new DateTime(2010, 09, 10), },
            new Ugyfel() { Id = 3, Nev = "Füty Imre", Szuletett = new DateTime(1990, 07, 11), },
        };


        // GET: Ugyfelek
        public ActionResult Index()
        {
            var ugyfelLista = new UgyfelListaViewModel()
            {
                Ugyfelek = _ugyfelek,
            };
            return View(ugyfelLista);
        }

        // GET: Ugyfelek/Reszletek/{id}
        public ActionResult Reszletek(int id)
        {
            var ugyfel = _ugyfelek.Where(x => x.Id == id).First();
            return View(ugyfel);
        }
    }
}