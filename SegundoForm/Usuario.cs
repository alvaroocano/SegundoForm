using System.Windows.Forms.VisualStyles;

namespace SegundoForm
{

    internal class Usuario
    {
        private string id;
        private string clave;

        public Usuario()
        {
            id = "";
            clave = "";
        }

        public Usuario(string id, string clave)
        {
            this.id = id;
            this.clave = clave;
        }

        public string getId()
        {
            return id;
        }

        public string getClave()
        {
            return clave;
        }
    }

}