namespace DAL.ToDAO
{
    public class AlumToDAO
    {

        //Método que convierte empleado DTO en empleado DAO
        public static DAL.Models.EvaTchNotasEvaluación DtoAlumnToDao(DAL.DTOs.AlumDTO alumDTO)
        {
            DAL.Models.EvaTchNotasEvaluación alumDAO = new DAL.Models.EvaTchNotasEvaluación();

            alumDAO.MdUuid = alumDTO.Md_uuid;
            alumDAO.MdFch = alumDTO.Md_fch;
            alumDAO.CodAlumno = alumDTO.Cod_alumno;
            alumDAO.NotaEvaluacion = alumDTO.Nota_evaluacion;
            alumDAO.CodEvaluacion = alumDTO.Cod_evaluacion;

            return alumDAO;
        }

    }
}
