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
        private string empleadoNombre;
        private Guid identificador;
        private TipoDeReclamo tipo;
        private string observacion;
        #endregion

        #region Constructors
        public Reclamo()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Reclamo
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="empleadoNombre"></param>
        /// <param name="tipo"></param>
        /// <param name="observacion"></param>
        /// <param name="identificador"></param>
        public Reclamo(DateTime fecha, string empleadoNombre, TipoDeReclamo tipo, string observacion, Guid identificador)
        {
            this.Fecha = fecha;
            this.Empleado = empleadoNombre;
            this.Tipo = tipo;
            this.Observacion = observacion;
            this.Identificador = identificador;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Retorna o establece un valor Guid en el atributo identificador
        /// </summary>
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

        /// <summary>
        /// Retorna o establece un valor DateTime en el atributo fecha
        /// </summary>
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

        /// <summary>
        /// Retorna o establece un valor string en el atributo empleadoNombre
        /// </summary>
        public string Empleado
        {
            get
            {
                return this.empleadoNombre;
            }
            set
            {
                this.empleadoNombre = value;
            }
        }

        /// <summary>
        /// Retorna o establece un valor TipoDeReclamo en el atributo tipo
        /// </summary>
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

        /// <summary>
        /// Retorna o establece un valor string en el atributo observacion
        /// </summary>
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
        /// <summary>
        /// Retorna los valores en los atributos de la instancia
        /// </summary>
        /// <returns> String con fecha, nombre del empleado, tipo de reclamo y observación</returns>
        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"FECHA: {this.Fecha}");
            sb.AppendLine($"ATENDIDO POR: {this.Empleado}");
            sb.AppendLine($"TIPO DE RECLAMO: {this.Tipo}");
            sb.AppendLine($"OBSERVACION: {this.observacion}");
            return sb.ToString();
        }
        #endregion
    }
}
