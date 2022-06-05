using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Unidad 13 – Interfaces 
    /// </summary>
    public class Vecino : IPersona
    {
        #region Fields
        private string nombre;
        private string apellido;
        private string direccion;
        private DateTime fechaDeNacimiento;
        private List<Reclamo> reclamos;
        private int dni;
        #endregion

        #region Constructors
        public Vecino()
        {
            this.reclamos = new List<Reclamo>();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Vecino
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="direccion"></param>
        /// <param name="fechaNac"></param>
        /// <param name="dni"></param>
        public Vecino(string nombre, string apellido, string direccion, DateTime fechaNac, int dni) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.FechaDeNacimiento = fechaNac;
            this.Dni = dni;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Retorna o establece un valor string en el atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Retorna o establece un valor string en el atributo apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// Retorna o establece un valor string en el atributo direccion
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        /// <summary>
        /// Retorna o establece un valor DateTime en el atributo fechaDeNacimiento
        /// </summary>
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                this.fechaDeNacimiento = value;
            }
        }

        /// <summary>
        /// Retorna o establece un valor List<Reclamo> en el atributo reclamos
        /// </summary>
        public List<Reclamo> Reclamos
        {
            get
            {
                return this.reclamos;
            }
            set
            {
                this.reclamos = value;
            }
        }

        /// <summary>
        /// Retorna nombre + apellido de la instancia
        /// </summary>
        public string NombreCompleto
        {
            get
            {
                return $"{this.nombre} {this.apellido}";
            }
        }

        /// <summary>
        /// Retorna o establece un valor int en el atributo dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        /// <summary>
        /// Retorna string con nombre completo, direccion, fecha de nacimiento,dni y reclamos de la instancia
        /// </summary>
        public string Ficha
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"NOMBRE COMPLETO: {this.NombreCompleto}");
                sb.AppendLine($"DIRECCION: {this.Direccion}");
                sb.AppendLine($"FECHA DE NACIMIENTO: {this.FechaDeNacimiento}");
                sb.AppendLine($"DNI: {this.Dni}");
                sb.AppendLine(" ");
                for (int i = 0; i < this.Reclamos.Count; i++)
                {
                    sb.AppendLine($"-----Reclamo {i + 1}-----");
                    sb.AppendLine(this.reclamos[i].ObtenerInformacion());
                }
                return sb.ToString();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Agrega a la instancia el reclamo recibido por parametro si no es nulo
        /// </summary>
        /// <param name="reclamo"></param>
        public void AgregarReclamo(Reclamo reclamo)
        {
            if (reclamo != null)
            {
                this.reclamos.Add(reclamo);
            }
        }
        #endregion
    }
}
