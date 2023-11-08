using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoForm
{
    public class Empleado
    {

        
        private readonly decimal id;
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string puesto;
        private string tlf;
        private string correo;
        private DateTime fecha_nacimiento;
        private decimal ss;
        private string comentario;


        public Empleado() { }

        public Empleado(decimal id, string dni, string nombre, string apellido1, string apellido2, string puesto, string tlf, string correo, DateTime fecha_nacimiento, decimal ss, string comentario) {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.puesto = puesto;
            this.tlf = tlf;
            this.correo = correo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.ss = ss;
            this.comentario = comentario;
        
        }

        public bool isJefe()
        {
            if(this.puesto == "jefe")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cambiarComentarios(string comentarioNuevo)
        {
            this.comentario = comentarioNuevo;
        }

        public decimal Id { get => id;  }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Tlf { get => tlf; set => tlf = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public decimal Ss { get => ss; set => ss = value; }
        public string Comentario { get => comentario; set => comentario = value; }
    }

}
