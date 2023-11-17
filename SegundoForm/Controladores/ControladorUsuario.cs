using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static SegundoForm.FormReg;

namespace SegundoForm.Controladores
{
    public partial class ControladorUsuario : Form
    {
        public ControladorUsuario()
        {
            InitializeComponent();
        }

        private void ControladorForm1_Load(object sender, EventArgs e)
        {

        }

        public void cargarUsuarios()
        {
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("root", "1234"));
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("juan", "4321"));
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("jaime", "4444"));
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("jose", "1111"));
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("javier", "2222"));
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario("jorge", "3333"));

        }

        public void escribirXML(List<Usuario> lista)
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(lista.GetType());
                    serializer.Serialize(writer, lista, namespaces);
                }
            }
            catch (Exception e) { }
        }

        public void leerXML(List<Usuario> lista)
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new
                    XmlSerializer(lista.GetType());
                    lista = (List<Usuario>)serializer.Deserialize(reader);
                    System.Console.WriteLine(xml);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }

        public void validarUsuario(int contador, string usuario, string pass)
        {
            int posicion = ListaDatosUsuarios.listaUsuarios.FindIndex(x => x.Id == usuario);
            if (posicion != -1 && ListaDatosUsuarios.listaUsuarios[posicion].Clave == pass)
            {
                this.Close();
                Principal pr = new Principal();
                pr.Show();
            }
            else
            {
                contador++;
            }

            if (contador == 3)
            {
                MessageBox.Show("3 intentos incorrectos");
                Application.Exit();
                contador = 0;
            }

        }
        

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Button btnGuardar;
    }

    public static class ListaDatosUsuarios
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
    }
}
