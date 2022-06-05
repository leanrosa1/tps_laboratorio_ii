using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Unidad 13 – Interfaces 
    /// </summary>
    public class Empleado : IPersona
    {
        #region Fields
        private string nombre;
        private string apellido;
        private int dni;
        #endregion

        #region Constructors
        public Empleado() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Empleado(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
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
        /// Retorna nombre + apellido
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
        /// Retorna string con nombre completo y dni de la instancia
        /// </summary>
        public string Ficha
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"NOMBRE COMPLETO: {this.NombreCompleto}");
                sb.AppendLine($"DNI: {this.Dni}");
                return sb.ToString();
            }
        }
        #endregion
    }
}
