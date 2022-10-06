using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Organizacion;

namespace Entidades_Organizacion
{
    public  class Ventas : Mercaderia
    {
        protected int numeroFactura;
        protected float total;
        public Ventas(string articulo, string categoria, float precio,int cantidad) : base()
        {

            this.total = cantidad*precio;
        }

        public Ventas(string articulo, string categoria, float precio, int cantidad, int numeroFactura) : this(articulo,categoria,precio,cantidad)
        {
            this.numeroFactura = numeroFactura;
        }

        public static bool operator +(Ventas v1, Ventas v2) 
        {
            bool validacion = false;
            if( !(v1 is null || v2 is null)) 
            {
                if(v1.numeroFactura == v2.numeroFactura) 
                {
                    validacion = true;
                }
            }

            return validacion;
        }

        public float GetSetTotal 
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public int GetSetNumeroFactura
        {
            get {return this.numeroFactura; }
            set { this.numeroFactura = value; }
        }

    }
}
