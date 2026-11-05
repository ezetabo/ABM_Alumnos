namespace ContenedorAlumnos
{
    public class Alumno
    {
        private static int generarID = 0;
        private int id;
        private string nombre;
        private string apellido;
        private int edad;

        public Alumno(string nombre, string apellido, int edad)
        {
            this.id = generarID + 1;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            generarID++;
        }

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"Id: {id} - Alumno: {apellido}, {nombre} - Edad: {edad}";
        }
    }
}
