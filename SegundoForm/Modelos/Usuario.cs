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
            this.Id = id;
            this.Clave = clave;
        }

        public string Id { get => id; set => id = value; }
        public string Clave { get => clave; set => clave = value; }
    }

}