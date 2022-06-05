using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
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
