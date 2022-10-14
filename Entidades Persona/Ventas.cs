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
        private int cantidad;
        private int numeroFactura;
        private float total;
        public Ventas(string articulo, string categoria, float precio,int cantidad, int numeroFactura)
        {
            this.articulo = articulo;
            this.categoria = categoria;
            this.precio = precio;
            this.cantidad = cantidad;
            this.total = cantidad*precio;
            this.numeroFactura = numeroFactura;
        }

        public static bool operator ==(Ventas v1, Ventas v2) 
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

        public static bool operator !=(Ventas v1, Ventas v2) 
        {
            return !(v1 == v2);
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

        public int GetSetCantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public string MostrarVentas(Ventas v) 
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine($"articulo {v.GetSetArticulo}");
            cadena.AppendLine($"cantidad {v.GetSetCantidad}");
            cadena.AppendLine($"nro factura {v.GetSetNumeroFactura}");
            cadena.AppendLine($"total {v.GetSetTotal}");

            return Convert.ToString(cadena);
        }

    }
}
