using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eva2DWSATG.Pages.Consultas
{
    public class SelectModel : PageModel
    {
        //Obtengo el contexto
        public DAL.Models.BdEvaluacionContext db = new DAL.Models.BdEvaluacionContext();

        //Obtengo los valores del formulario
        [BindProperty]
        public string codAlumn { get; set; }
        [BindProperty]
        public string codEV { get; set; }




        public void OnPostcodEmpleado()
        {



            var alumn = db.EvaTchNotasEvaluacións.Where(e => e.CodAlumno == codAlumn).FirstOrDefault();



            ViewData["warningMessage"] = " ";

            if (alumn != null)
            {
                ViewData["alumn1"] = alumn;
            }
            else
            {
                ViewData["warningMessage"] = "ERROR (The user doesn't exits)!";
            }
        }

        public void OnPostevEmpleado()
        {


            var alumn = db.EvaTchNotasEvaluacións.Where(e => e.CodEvaluacion == codEV).FirstOrDefault();


            ViewData["warningMessage"] = " ";

            if (alumn != null)
            {
                ViewData["alumn2"] = alumn;
            }
            else
            {
                ViewData["warningMessage"] = "ERROR (The user doesn't exits)!";
            }
        }
    }
}
