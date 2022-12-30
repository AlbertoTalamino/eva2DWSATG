using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eva2DWSATG.Pages.Consultas
{
    public class InsertModel : PageModel
    {
        //Obtengo el contexto
        public eva2DWSATG.Models.BdEvaluacionContext db = new eva2DWSATG.Models.BdEvaluacionContext();

        //Obtengo los valores del formulario
        [BindProperty]
        public string codAlum { get; set; }
        [BindProperty]
        public int NotaEv { get; set; }
        [BindProperty]
        public string codEV { get; set; }


        public IActionResult OnPostSubmit()
        {
            //Instancia de la clase alumno con los parámetros recogidos por la vista
            eva2DWSATG.DTOs.AlumDTO alumnDTO = new eva2DWSATG.DTOs.AlumDTO(codAlum, NotaEv, codEV);

            //DTO to DAO
            eva2DWSATG.Models.EvaTchNotasEvaluación alumnDAO = eva2DWSATG.ToDAO.AlumToDAO.DtoAlumnToDao(alumnDTO);

            //Insert
            try
            {
                Console.WriteLine("Entando en insert");
                db.EvaTchNotasEvaluacións.Add(alumnDAO);
                db.SaveChanges();
                Console.WriteLine("Saliendo de insert");

                return RedirectToPage("../Index");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error en insert: " + ex.Message);
            }

            return null;
        }

    }
}
