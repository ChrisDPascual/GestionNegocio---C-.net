using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Organizacion
{
    public sealed class Cliente : Duenio
    {
        static private int cantidadCompras;
        private float dinero;

        #region "Constructores"
        static Cliente() 
        {
            cantidadCompras = 0;
        }

        public Cliente() : base()
        {

        }

        public Cliente(int dinero) 
        {
            this.dinero = dinero;
        }
        public Cliente(string nombre, string apellido, long DNI, string genero, DateTime fecha) :
        base(nombre, apellido, DNI, genero, fecha)
        {
           
        }

        public Cliente(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono) : 
            this(nombre, apellido, DNI, genero, fecha)
        {
            this.telefono = telefono;
        }

        public Cliente(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono, string email) : 
            this(nombre, apellido, DNI, genero, fecha, telefono)
        {
            this.email = email;
        }

        public Cliente(string nombre, string apellido, long DNI, string genero, DateTime fecha, long telefono, string email, string domicilio) : 
            this(nombre, apellido, DNI, genero, fecha, telefono, email)
        {
            this.domicilio = domicilio;
        }
        #endregion

        #region "Geters y Setters"
        public float GetSetDinero 
        {
            get { return this.dinero; }
            set { this.dinero = value; }
        }
        public int GetSetCantidadCompras 
        {
            get { return cantidadCompras; }
        }
        #endregion
        
        public static bool operator==(Cliente c1, Cliente c2) 
        {
            bool retorno = false;
            if(!(c1 is null || c2 is null)) 
            {
                if(c1.GetSetDNI == c2.GetSetDNI) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2) 
        {
            return !(c1 == c2);
        }

        public void AumentarContadorDeCompras(bool compra) 
        {
            if(compra == true) 
            {
                cantidadCompras++;
            }
        }

        public bool BuscarClienteDNI(Duenio d, long DNI)
        {
            bool validacion = false;
            if (!(d is null) || DNI < 1)
            {
                foreach (var item in d.GetSetListadoClientes)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        validacion = true;
                        break;
                    }
                }
            }
            return validacion;
        }

        public Cliente RetornarUnCliente(Duenio d, long DNI)
        {
            Cliente unCliente = null;
            if (BuscarClienteDNI(d, DNI))
            {
                foreach (var item in d.GetSetListadoClientes)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        unCliente = item;
                        break;
                    }
                }
            }

            return unCliente;
        }

        public string MostrarUnCliente(Duenio d, long DNI)
        {
            StringBuilder cadena = new StringBuilder();
            int bandera = 0;

            if (BuscarClienteDNI(d, DNI))
            {
                foreach (var item in d.GetSetListadoClientes)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        cadena.AppendLine($"Nombre: {item.GetSetNombre}");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.AppendLine($"DNI: {item.GetSetDNI}");
                        cadena.Append($"Sexo: {item.GetSetGenero}\t");
                        cadena.AppendLine($"edad: {item.GetEdad(item.GetSetFechaNacimiento)}");
                        cadena.AppendLine($"Email: {item.GetSetEmail}");
                        cadena.AppendLine($"Direccion: {item.GetSetDomicilio}");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
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

        public string ValidarCliente(Duenio d, string nombre, string apellido, long DNI, string genero, DateTime fechaNac)
        {
            string cadena = string.Empty;
            StringBuilder Error = new StringBuilder();
            int edad;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero) || d is null)
            {
                Error.AppendLine("Complete nombre, apellido y genero");
            }

            if (!(DNI >= 999999 && DNI <= 99999999))
            {
                Error.AppendLine("Ingrese un DNI valido");
            }
            else
            {
                    if (BuscarClienteDNI(d, DNI))
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

            cadena = Convert.ToString(Error);
            return cadena;
        }

        public bool ModificarCliente(Duenio d, Cliente c, long DNI)
        {
            bool validacion = false;
            if (BuscarClienteDNI(d, DNI) || !(c is null))
            {
                foreach (var item in d.GetSetListadoClientes)
                {
                    if (DNI == item.GetSetDNI)
                    {
                        item.GetSetNombre = c.GetSetNombre;
                        item.GetSetApellido = c.GetSetApellido;
                        item.GetSetDNI = c.GetSetDNI;
                        item.GetSetDomicilio = c.GetSetDomicilio;
                        item.GetSetFechaNacimiento = c.GetSetFechaNacimiento;
                        item.GetSetGenero = c.GetSetGenero;
                        item.GetSetEmail = c.GetSetEmail;
                        item.GetSetelefono = c.GetSetelefono;
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }
    }
}
