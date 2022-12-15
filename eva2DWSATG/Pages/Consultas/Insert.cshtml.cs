using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eva2DWSATG.Pages.Consultas
{
    public class InsertModel : PageModel
    {
        //Obtengo el contexto
        public DAL.Models.BdEvaluacionContext db = new DAL.Models.BdEvaluacionContext();

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
            DAL.DTOs.AlumDTO alumnDTO = new DAL.DTOs.AlumDTO(codAlum, NotaEv, codEV);

            //DTO to DAO
            DAL.Models.EvaTchNotasEvaluación alumnDAO = DAL.ToDAO.AlumToDAO.DtoAlumnToDao(alumnDTO);

            //Insert
            try
            {
                Console.WriteLine("Entando en insert");
                db.EvaTchNotasEvaluacións.Add(alumnDAO);
                db.SaveChanges();
                Console.WriteLine("Saliendo de insert");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error en insert: " + ex.Message);
            }
            

            return RedirectToPage("../Index");
        }

    }
}
