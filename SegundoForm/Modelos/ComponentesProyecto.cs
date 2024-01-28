using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoForm.Modelos
{
    public class ComponentesProyecto
    {
        private string codigoProyecto;
        private string IdEmpleado;
        private string puesto;
        private float porcentajeDeDedicacion;
        private decimal extras;

        public ComponentesProyecto(){}

        public ComponentesProyecto(string codigoProyecto, string idEmpleado, string puesto, float porcentajeDeDedicacion, decimal extras)
        {
            this.codigoProyecto = codigoProyecto;
            IdEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDeDedicacion = porcentajeDeDedicacion;
            this.extras = extras;
        }

        public string CodigoProyecto { get => codigoProyecto; set => codigoProyecto = value; }
        public string IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDeDedicacion { get => porcentajeDeDedicacion; set => porcentajeDeDedicacion = value; }
        public decimal Extras { get => extras; set => extras = value; }

        public void cambiarPorcentaje(float porcentaje)
        {
            this.porcentajeDeDedicacion = porcentaje;
        }

        public bool isJefe()
        {
            return this.Puesto.Equals("jefe");
        }
    }
}
