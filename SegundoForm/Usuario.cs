using System.Windows.Forms.VisualStyles;

namespace SegundoForm
{

    public class Usuario
    {
        private string id;
        private string clave;

        public Usuario()
        {

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