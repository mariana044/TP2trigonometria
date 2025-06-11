using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using TP2trigonometria.Models;

namespace TP2trigonometria.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Triangulo modelo)
        {

            if (!ModelState.IsValid)
            {
                if (modelo.a + modelo.b <= modelo.c)
                {
                    ModelState.AddModelError("", "Los lados proporcionados no forman un triángulo válido");
                }
                return View(modelo);
            }


            double P = modelo.a + modelo.b + modelo.c;
            double S = P / 2;
            double A = Math.Sqrt(S * (S - modelo.a) * (S - modelo.b) * (S - modelo.c));

            string tipo;
            if (modelo.a == modelo.b && modelo.b == modelo.c)
                tipo = "Equilátero";
            else if (modelo.a == modelo.b || modelo.a == modelo.c || modelo.b == modelo.c)
                tipo = "Isóceles";
            else
                tipo = "Escaleno";


            double alpha = Math.Acos((Math.Pow(modelo.b, 2) + Math.Pow(modelo.c, 2) - Math.Pow(modelo.a, 2)) / (2 * modelo.b * modelo.c)) * (180 / Math.PI);
            double beta = Math.Acos((Math.Pow(modelo.a, 2) + Math.Pow(modelo.c, 2) - Math.Pow(modelo.b, 2)) / (2 * modelo.a * modelo.c)) * (180 / Math.PI);
            double gamma = Math.Acos((Math.Pow(modelo.a, 2) + Math.Pow(modelo.b, 2) - Math.Pow(modelo.c, 2)) / (2 * modelo.a * modelo.b)) * (180 / Math.PI);


            ViewBag.P = P;
            ViewBag.S = S;
            ViewBag.A = A;
            ViewBag.Tipo = tipo;
            ViewBag.Alpha = alpha;
            ViewBag.Beta = beta;
            ViewBag.Gamma = gamma;

            return View(modelo);

        }
    }
}
