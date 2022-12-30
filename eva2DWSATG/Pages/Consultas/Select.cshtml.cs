using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eva2DWSATG.Pages.Consultas
{
    public class SelectModel : PageModel
    {
        //Obtengo el contexto
        public eva2DWSATG.Models.BdEvaluacionContext db = new eva2DWSATG.Models.BdEvaluacionContext();

        //Obtengo los valores del formulario
        [BindProperty]
        public string codAlumn { get; set; }
        [BindProperty]
        public string codEV { get; set; }




        public void OnPostcodEmpleado()
        {
            var alumn = db.EvaTchNotasEvaluacións.Where(e => e.CodAlumno == codAlumn).FirstOrDefault();

            //DAO to DTO
            eva2DWSATG.DTOs.AlumDTO alumnDTO = eva2DWSATG.ToDTO.AlumToDTO.DaoAlumnToDto(alumn);

            ViewData["warningMessage"] = " ";

            if (alumnDTO != null)
            {
                ViewData["alumn1"] = alumnDTO;
            }
            else
            {
                ViewData["warningMessage"] = "ERROR (The user doesn't exits)!";
            }
        }

        public void OnPostevEmpleado()
        {
            var alumn = db.EvaTchNotasEvaluacións.Where(e => e.CodEvaluacion == codEV).FirstOrDefault();

            //DAO to DTO
            eva2DWSATG.DTOs.AlumDTO alumnDTO = eva2DWSATG.ToDTO.AlumToDTO.DaoAlumnToDto(alumn);

            ViewData["warningMessage"] = " ";

            if (alumnDTO != null)
            {
                ViewData["alumn2"] = alumnDTO;
            }
            else
            {
                ViewData["warningMessage"] = "ERROR (The user doesn't exits)!";
            }
        }
    }
}
