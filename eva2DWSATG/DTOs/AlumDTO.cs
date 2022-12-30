namespace eva2DWSATG.DTOs
{
    public class AlumDTO
    {

        //Propiedades
        string md_uuid; //Por ahora los rellenamos aleatoriamente
        DateTime md_fch;
        long idNotaEvaluacion;
        string cod_alumno;
        int nota_evaluacion;
        string cod_evaluacion;

        //Constructores
        public AlumDTO(string cod_alumno, int nota_evaluacion, string cod_evaluacion)
        {
            this.md_uuid = RandomValue();
            this.md_fch = DateTime.Now;
            this.cod_alumno = cod_alumno;
            this.nota_evaluacion = nota_evaluacion;
            this.cod_evaluacion = cod_evaluacion;
        }

        public AlumDTO()
        {
            
        }

        //GETTERS AND SETTERS
        public string Md_uuid { get => md_uuid; set => md_uuid = value; }
        public DateTime Md_fch { get => md_fch; set => md_fch = value; }
        public string Cod_alumno { get => cod_alumno; set => cod_alumno = value; }
        public int Nota_evaluacion { get => nota_evaluacion; set => nota_evaluacion = value; }
        public string Cod_evaluacion { get => cod_evaluacion; set => cod_evaluacion = value; }
        public long IdNotaEvaluacion { get => idNotaEvaluacion; set => idNotaEvaluacion = value; }



        //Método que genera un valor aleatorio para el campo MdUuid       
        string RandomValue()
        {
            Random ran = new Random();
            return ("AS" + ran.Next());
        }

    }
}
