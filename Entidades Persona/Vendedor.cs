using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Organizacion
{
    public sealed class Vendedor : Duenio
    {
       
        private DateTime fechaInicioActividad;
        private DateTime fechaFinActividad;
        private string estado;

        #region "Constructores"
        private Vendedor() : base()
        {
        }

        public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fechaNac, string estado, DateTime fechaInicioActividad) 
        : base(nombre, apellido, DNI, genero, fechaNac) 
        {
            this.legajo = GenerarLegajo(GetLista);
            this.estado = estado;
            this.fechaInicioActividad = fechaInicioActividad;
            this.fechaFinActividad = new DateTime(1, 1, 1);
            this.contraseña = CrearContraseña(nombre, apellido, this.legajo);
            this.usuario = CrearUsuario(nombre, apellido);
           

        }

        public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fecha, string estado, DateTime fechaInicioActividad,long telefono) :
         this(nombre, apellido, DNI, genero, fecha,estado,fechaInicioActividad)
        {
            this.telefono = telefono;
        }

        public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fecha, string estado, DateTime fechaInicioActividad, long telefono, string email) :
            this(nombre, apellido, DNI, genero, fecha, estado, fechaInicioActividad,telefono)
        {
            this.email = email;
        }

        public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fecha, string estado, DateTime fechaInicioActividad, long telefono, string email, string domicilio) :
            this(nombre, apellido, DNI, genero, fecha, estado, fechaInicioActividad,telefono,email)
        {
            this.domicilio = domicilio;
        }

        public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fecha, string estado, DateTime fechaInicioActividad, long telefono, string email, string domicilio, DateTime fechaFinActividad):
            this(nombre, apellido, DNI, genero, fecha, estado, fechaInicioActividad, telefono, email,domicilio)
        {
            this.fechaFinActividad = fechaFinActividad;
        }
        #endregion

        #region "Get y Set"
        public string GetSetEstado 
        {
            get {return this.estado; }
            set {this.estado = value; }
        }

        public DateTime GetSetInicioActividades 
        {
            get {return this.fechaInicioActividad; }
            set { this.fechaInicioActividad = value; }
        }

        public DateTime GetSetFinActividades
        {
            get {return this.fechaFinActividad; }
            set {this.fechaFinActividad = value; }
        }

        #endregion

        public static implicit operator int(Vendedor vendedores)
        {
            return Convert.ToInt32(vendedores.GetLegajo);
        }

        public static bool operator ==(int numero, Vendedor Vendedor)
        {
            bool retorno = false;
            if(!(Vendedor is null && numero<999)) 
            { 
                if(numero == Vendedor.GetLegajo) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(int numero, Vendedor Vendedor)
        {
            return !(numero == Vendedor);
        }

    }
}
