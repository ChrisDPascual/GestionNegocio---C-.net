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
        public Vendedor() : base()
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
        #region "Sobrecargas"
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
        #endregion

        public bool VerificarLegajo(int numeroLegajo, Duenio d)
        {
            bool retorno = false;

            if (numeroLegajo > 0 || !(d is null))
            {
                foreach (var item in d.GetLista)
                {
                        if (numeroLegajo == item.GetLegajo)
                        {
                            retorno = true;
                            break;
                        }                
                }
            }

            return retorno;
        }

        public string MostrarUnEmpleado(int legajo, Duenio d)
        {
            StringBuilder cadena = new StringBuilder();
            int bandera = 0;
            if (!(d is null) && legajo > 0)
            {
                foreach (var item in d.GetLista)
                {
                    if (legajo == item.GetLegajo)
                    {
                        cadena.Append($"Nombre: {item.GetSetNombre}\t");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.Append($"DNI: {item.GetSetDNI}\t");
                        cadena.Append($"Genero: {item.GetSetGenero}\t");
                        cadena.AppendLine($"Edad: {item.GetEdad(item.fechaNacimiento)}\t");
                        cadena.Append($"Estado: {item.GetSetEstado}\t");
                        cadena.Append($"Legajo: {item.GetLegajo}\t");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
                        cadena.Append($"email: {item.GetSetEmail}\t");
                        cadena.AppendLine($"domicilio: {item.GetSetDomicilio}");
                        cadena.Append("Inicio de actividades: " + item.GetSetInicioActividades.ToString("dd/MM/yyyy"));

                        if (item.GetSetEstado == "despedido")
                        {

                            cadena.AppendLine("\tFecha de despido: " + item.GetSetFinActividades.ToString("dd/MM/yyyy\n"));
                        }
                        cadena.AppendLine();
                        cadena.AppendLine();
                        bandera = 1;
                        break;
                    }

                }
            }
            if (bandera == 1)
            {
                return Convert.ToString(cadena);
            }
            else
            {
                return string.Empty;
            }

        }

        public string MostrarEmpleados(string filtro, Duenio d)
        {
            StringBuilder cadena = new StringBuilder();
            if (!(string.IsNullOrWhiteSpace(filtro) || d is null))
            {
                

                if (filtro == "todos")
                {
                    foreach (var item in d.GetLista)
                    {

                            if(item.GetLegajo > 0) 
                            {
                                cadena.AppendLine(MostrarUnEmpleado(item.GetLegajo, d));
                            }                  

                    }
                }
                else 
                {
                    foreach (var item in d.GetLista)
                    {

                        if (item.GetSetEstado == filtro)
                        {
                            cadena.AppendLine(MostrarUnEmpleado(item.GetLegajo, d));
                        }
                    }
                }
            }

            return Convert.ToString(cadena);
        }

        public bool ComparaDNI(Duenio d, long DNI)
        {
            bool retorno = false;
            if (!(d is null) && DNI > 0)
            {
                foreach (var item in d.GetLista)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public string ValidarNuevoEmpleado(Duenio d, string nombre, string apellido, long DNI, string genero, DateTime fechaNac, string estado, DateTime inicioActividades)
        {
            string cadena = string.Empty;
            StringBuilder Error = new StringBuilder();
            int edad;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(estado) || d is null)
            {
                Error.AppendLine("Complete nombre, apellido y genero");
            }

            if (!(DNI >= 999999 && DNI <= 99999999))
            {
                Error.AppendLine("Ingrese un DNI valido");
            }
            else
            {
                if (ComparaDNI(d,DNI))
                {
                    Error.AppendLine("El DNI ya se encuentra registrado");
                }
                
            }

            if (!(Validaciones.Validaciones.ValidarFecha(fechaNac.Day, fechaNac.Month, fechaNac.Year)))
            {
                Error.AppendLine("la fecha ingresada no es valida");
            }
            else
            {
                edad = d.GetEdad(fechaNac);
                if (edad < 17)
                {
                    Error.AppendLine("No tiene edad suficiente para trabajar");
                }
            }

            if (inicioActividades > DateTime.Now)
            {
                Error.AppendLine("No concuerda la fecha de inicio"); ;
            }
            cadena = Convert.ToString(Error);
            return cadena;
        }

        public string ValidarCambioDatosEmpleado(Duenio d, string nombre, string apellido, long DNI, string genero, DateTime fechaNac, string estado)
        {
            string cadena = string.Empty;
            StringBuilder Error = new StringBuilder();
            int edad;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(estado) || d is null)
            {
                Error.AppendLine("Complete nombre, apellido y genero");
            }

            if (!(DNI >= 999999 && DNI <= 99999999))
            {
                Error.AppendLine("Ingrese un DNI valido");
            }
            else
            {
                if (ComparaDNI(d, DNI) == false)
                {
                    Error.AppendLine("El DNI ingresado no se encuentra sociado a ningun empleado");
                }

            }

            if (!(Validaciones.Validaciones.ValidarFecha(fechaNac.Day, fechaNac.Month, fechaNac.Year)))
            {
                Error.AppendLine("la fecha ingresada no es valida");
            }
            else
            {
                edad = d.GetEdad(fechaNac);
                if (edad < 17)
                {
                    Error.AppendLine("No tiene edad suficiente para trabajar");
                }
            }

            cadena = Convert.ToString(Error);
            return cadena;
        }

        public Vendedor RetornarUnVendedor(Duenio d, int legajo)
        {
            Vendedor unVendedor = null;
            if (!(d is null) && legajo > 0)
            {
                foreach (var item in d.GetLista)
                {
                    if (item.GetLegajo == legajo)
                    {
                        unVendedor = item;
                        break;
                    }
                }
            }

            return unVendedor;
        }
    }
}
