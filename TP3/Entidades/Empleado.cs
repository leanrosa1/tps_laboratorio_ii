using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : IPersona
    {
        #region Fields
        private string nombre;
        private string apellido;
        private int dni;
        #endregion

        #region Constructors
        public Empleado() { }

        public Empleado(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }
        #endregion

        #region Properties
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
        public string NombreCompleto
        {
            get
            {
                return $"{this.nombre} {this.apellido}";
            }
        }

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
