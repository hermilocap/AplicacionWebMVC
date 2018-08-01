using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWebMVC.Models;

namespace AplicacionWebMVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();

            Persona persona = new Persona();
            persona.codigo = 1;
            persona.nombre = "Hermilo";
            persona.apellido = "Santiago";
            lista.Add(persona);

            Persona persona2 = new Persona();
            persona2.codigo = 2;
            persona2.nombre = "Andrea";
            persona2.apellido = "Bracamontes";
            lista.Add(persona2);

            Persona persona3 = new Persona();
            persona3.codigo = 3;
            persona3.nombre = "Pedro";
            persona3.apellido = "Lopez";
            lista.Add(persona3);

            return View(lista);
        }
    }
}