namespace DAL.DTOs
{
    public class AlumDTO
    {

        //Propiedades
        string md_uuid; //Por ahora los rellenamos aleatoriamente
        DateTime md_fch;
        string cod_alumno;
        int nota_evaluacion;
        string cod_evaluacion;

        //Constructor
        public AlumDTO(string cod_alumno, int nota_evaluacion, string cod_evaluacion)
        {
            this.md_uuid = RamdomValue();
            this.md_fch = DateTime.Now;
            this.cod_alumno = cod_alumno;
            this.nota_evaluacion = nota_evaluacion;
            this.cod_evaluacion = cod_evaluacion;
        }

        //GETTERS AND SETTERS
        public string Md_uuid { get => md_uuid; set => md_uuid = value; }
        public DateTime Md_fch { get => md_fch; set => md_fch = value; }
        public string Cod_alumno { get => cod_alumno; set => cod_alumno = value; }
        public int Nota_evaluacion { get => nota_evaluacion; set => nota_evaluacion = value; }
        public string Cod_evaluacion { get => cod_evaluacion; set => cod_evaluacion = value; }


        //Método que genera un valor aleatorio para el campo MdUuid       
        string RamdomValue()
        {
            Random ran = new Random();
            return ("AS" + ran.Next());
        }

    }
}
