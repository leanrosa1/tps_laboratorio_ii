using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reclamo
    {
        #region Fields
        private DateTime fecha;
        private Vecino vecino;
        private Empleado empleado;
        private Guid identificador;
        private TipoDeReclamo tipo;
        private string observacion;
        #endregion

        #region Constructors
        public Reclamo()
        {
            this.empleado = new Empleado();
        }

        public Reclamo(DateTime fecha, Vecino vecino, Empleado empleado, TipoDeReclamo tipo, string observacion, Guid identificador)
        {
            this.Fecha = fecha;
            this.Vecino = vecino;
            this.Empleado = empleado;
            this.Tipo = tipo;
            this.Observacion = observacion;
            this.Identificador = identificador;
        }
        #endregion

        #region Properties

        public Guid Identificador
        {
            get
            {
                return this.identificador;
            }
            set
            {
                this.identificador = value;
            }
        }
        public DateTime Fecha 
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        private Vecino Vecino
        {
            get
            {
                return this.vecino;
            }
            set
            {
                this.vecino = value;
            }
        }

        private Empleado Empleado
        {
            get
            {
                return this.empleado;
            }
            set
            {
                this.empleado = value;
            }
        }

        public TipoDeReclamo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public string Observacion
        {
            get
            {
                return this.observacion;
            }
            set
            {
                this.observacion = value;
            }
        }
        #endregion

        #region Methods
        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"FECHA: {this.Fecha}");
            //sb.AppendLine($"VECINO: {this.vecino.Ficha}");
            sb.AppendLine($"ATENDIDO POR: {this.Empleado.Ficha}");
            sb.AppendLine($"TIPO DE RECLAMO: {this.Tipo}");
            sb.AppendLine($"OBSERVACION: {this.observacion}");
            return sb.ToString();
        }
        #endregion
    }
}
