namespace Caja_UNAPEC
{
    public class Usuario
    {
        private string Identificador;
        private string Nombre;
        private string Acceso;
        private string Estado;

        public string Identificador_O  // property
        {
            get { return Identificador; }   // get method
            set { Identificador = value; }  // set method
        }

        public string Nombre_O  // property
        {
            get { return Nombre; }   // get method
            set { Nombre = value; }  // set method
        }

        public string Acceso_O  // property
        {
            get { return Acceso; }   // get method
            set { Acceso = value; }  // set method
        }

        public string Estado_O  // property
        {
            get { return Estado; }   // get method
            set { Estado = value; }  // set method
        }
    }
}
