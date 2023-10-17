using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoForm;

namespace SegundoForm
{
    internal class Proyecto
    {
        private string codigo; 
        private string descripcion ;
        private DateTime fechaInicio ;
        private DateTime fechaFin ;
        private string estado ;
        private double presupuestoInicial ;
        private double presupuestoActual ;
        private string cambios ;
        private int codCliente ;

        public Proyecto()
        {
            this.Codigo = null;
            this.Descripcion = "";
            this.FechaInicio = DateTime.Now;
            this.FechaFin = DateTime.Now;
            this.Estado = "";
            this.PresupuestoInicial = 0;
            this.PresupuestoActual = 0;
            this.Cambios = "";
            this.CodCliente = 0;
        }

        public Proyecto(string codigo, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado, double presupuestoInicial, double presupuestoActual, string cambios, int codCliente)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Estado = estado;
            this.PresupuestoInicial = presupuestoInicial;
            this.PresupuestoActual = presupuestoActual;
            this.Cambios = cambios;
            this.CodCliente = codCliente;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public double PresupuestoInicial { get => presupuestoInicial; set => presupuestoInicial = value; }
        public double PresupuestoActual { get => presupuestoActual; set => presupuestoActual = value; }
        public string Cambios { get => cambios; set => cambios = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
    }


}
