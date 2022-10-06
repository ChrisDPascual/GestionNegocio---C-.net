using System;
using Validaciones;

namespace Entidades_Organizacion
{
    public abstract class Organizacion
    {
        protected string nombre;
        protected string apellido;
        protected long DNI;
        protected string genero;
        protected DateTime fechaNacimiento;
        protected long telefono;
        protected string domicilio;
        protected string email;

        protected Organizacion() 
        {
            this.nombre = "NN";
            this.apellido = "NN";
            this.DNI = 0;
            this.genero = "NN";
            this.fechaNacimiento = new DateTime(1, 1, 1);
            this.telefono = 0;
            this.domicilio = "NN";
            this.email = "NN";
        }

        public Organizacion(string nombre, string apellido, long DNI, string genero, DateTime fecha) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
            this.genero = genero;
            this.fechaNacimiento = fecha;
        }

        public Organizacion(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono) : this(nombre, apellido, DNI, genero, fecha) 
        {
            this.telefono = telefono;
        }

        public Organizacion(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono, string email) : this(nombre, apellido, DNI, genero, fecha, telefono)
        {
            this.email = email;
        }

        public Organizacion(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono,string email,string domicilio) : this(nombre, apellido, DNI, genero, fecha, telefono,email)
        {
            this.domicilio=domicilio;
        }
        public string GetSetNombre
        {
            get { return this.nombre; }
            set {this.nombre = value; }
        }
        public string GetSetApellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string GetSetGenero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }
        public string GetSetDomicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }
        public string GetSetEmail
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public DateTime GetSetFechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public int GetEdad(DateTime fechaNacimiento)
        {
            int edad = 0;
            DateTime fechaActual = new DateTime();
            fechaActual= DateTime.Now;
            if (fechaNacimiento < fechaActual)
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
            }
    
            return edad;

        }

        public long GetSetDNI
        {
            get { return this.DNI; }
            set { this.DNI = value; }
        }

        public long GetSetelefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
    }

 
}
