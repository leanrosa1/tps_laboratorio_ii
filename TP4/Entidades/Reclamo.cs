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
        private int id;
        private DateTime fecha;
        private string empleadoNombre;
        private int empleadoDni;
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
        /// /// <param name="empleadoDni"></param>
        /// <param name="tipo"></param>
        /// <param name="observacion"></param>
        /// <param name="identificador"></param>
        public Reclamo(DateTime fecha, string empleadoNombre, int empleadoDni, TipoDeReclamo tipo, string observacion, Guid identificador, int id)
            :this(fecha, empleadoNombre, empleadoDni, tipo, observacion, identificador)
        {
            this.id = id;
        }

        public Reclamo(DateTime fecha, string empleadoNombre, int empleadoDni, TipoDeReclamo tipo, string observacion, Guid identificador)
        {
            this.Fecha = fecha;
            this.EmpleadoNombre = empleadoNombre;
            this.EmpleadoDni = empleadoDni;
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
        public string EmpleadoNombre
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

        public string TipoDeReclamoFriendly
        {
            get
            {
                string ret = string.Empty;
                if (this.tipo == TipoDeReclamo.AlumbradoPublico)
                {
                    ret = "Alumbrado público";
                }
                else if (this.tipo == TipoDeReclamo.PodaDeArbol)
                {
                    ret = "Poda de árbol";
                }
                else if (this.tipo == TipoDeReclamo.RuidosMolestos)
                {
                    ret = "Ruidos molestos";
                }
                else
                {
                    ret = "Otros";
                }
                return ret;
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

        /// <summary>
        /// Retorna o establece un valor int en el atributo empleadoDni
        /// </summary>
        public int EmpleadoDni
        {
            get
            {
                return this.empleadoDni;
            }
            set
            {
                this.empleadoDni = value;
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
            sb.AppendLine($"ATENDIDO POR: {this.EmpleadoNombre}");
            sb.AppendLine($"TIPO DE RECLAMO: {this.TipoDeReclamoFriendly}");
            sb.AppendLine($"OBSERVACION: {this.observacion}");
            return sb.ToString();
        }


        #endregion
    }
}
