namespace OtecLibrary
{
    public class Coordinador : Curso
    {
        public Coordinador()
        {

        }
        public string nombreCoordinador;
        private string NombreCoordinador {
            get { return nombreCoordinador; }
            set { nombreCoordinador = value; }
        }
    }
}
