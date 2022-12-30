namespace eva2DWSATG.ToDAO
{
    public class AlumToDAO
    {

        //Método que convierte empleado DTO en empleado DAO
        public static eva2DWSATG.Models.EvaTchNotasEvaluación DtoAlumnToDao(eva2DWSATG.DTOs.AlumDTO alumDTO)
        {
            eva2DWSATG.Models.EvaTchNotasEvaluación alumDAO = new eva2DWSATG.Models.EvaTchNotasEvaluación();

            alumDAO.MdUuid = alumDTO.Md_uuid;
            alumDAO.MdFch = alumDTO.Md_fch;
            alumDAO.CodAlumno = alumDTO.Cod_alumno;
            alumDAO.NotaEvaluacion = alumDTO.Nota_evaluacion;
            alumDAO.CodEvaluacion = alumDTO.Cod_evaluacion;

            return alumDAO;
        }

    }
}
