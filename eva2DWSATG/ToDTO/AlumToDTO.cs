namespace eva2DWSATG.ToDTO
{
    public class AlumToDTO
    {
        //Método que convierte empleado DAO en empleado DTO
        public static eva2DWSATG.DTOs.AlumDTO DaoAlumnToDto(eva2DWSATG.Models.EvaTchNotasEvaluación alumDAO)
        {
            eva2DWSATG.DTOs.AlumDTO alumDTO = new eva2DWSATG.DTOs.AlumDTO();

            alumDTO.Md_uuid = alumDAO.MdUuid;
            alumDTO.Md_fch = (DateTime)alumDAO.MdFch;
            alumDTO.IdNotaEvaluacion = alumDAO.IdNotaEvaluacion;
            alumDTO.Cod_alumno = alumDAO.CodAlumno;
            alumDTO.Nota_evaluacion = (int)alumDAO.NotaEvaluacion;
            alumDTO.Cod_evaluacion = alumDAO.CodEvaluacion;

            return alumDTO;
        }
    }
}
