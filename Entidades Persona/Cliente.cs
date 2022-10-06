using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Organizacion
{
    public sealed class Cliente : Organizacion
    {
        static private int cantidadCompras;
        private float dinero;

        static Cliente() 
        {
            cantidadCompras = 0;
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

        public float GetSetDinero 
        {
            get { return this.dinero; }
            set { this.dinero = value; }
        }
        public int GetSetCantidadCompras 
        {
            get { return cantidadCompras; }
        }

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
        
    }
}
