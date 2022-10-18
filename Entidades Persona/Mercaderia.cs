using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Organizacion;


namespace Entidades_Organizacion
{
    public class Mercaderia
    {
        protected string articulo;
        private string marca;
        protected int codigo;
        protected string categoria;
        protected float precio;
        private int stock;
        private eTipoMercaderia tipo;

        public Mercaderia() 
        {
            this.articulo = "NN";
            this.categoria = "NN";
            this.precio = 0;
            this.stock = 0;
            this.tipo = eTipoMercaderia.Nulo;
            this.codigo = 0;
        }

        public Mercaderia(string nombre, string marca, int codigo, string categoria, eTipoMercaderia tipo, float precio, int stock) 
        {
            this.articulo = nombre;
            this.marca = marca;
            this.codigo = codigo;
            this.categoria = categoria;
            this.tipo = tipo;
            this.precio = precio;
            this.stock = stock;
        }

        #region "Get y Set"
        public string GetSetArticulo 
        {
            get { return this.articulo; }
            set { this.articulo = value; }
        }

        public string GetSetMarca 
        {
            get {return this.marca; }
            set {this.marca = value; }
        }

        public int GetCodigo 
        {
            get { return this.codigo; }
        }

        public string GetSetCategoria 
        {
            get {return this.categoria; }
            set {this.categoria = value; }
        }
        
        public eTipoMercaderia GetSetTipo 
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public float GetSetPrecio 
        {
            get {return this.precio; }
            set {this.precio = value; }
        }

        public int GetSetStock 
        {
            get {return this.stock; }
            set {this.stock = value; }
        }
        #endregion

       

        public static bool operator ==(Mercaderia m1 , Mercaderia m2) 
        {
            bool validacion = false;

            if(!(m1 is null && m2 is null)) 
            {
                if(m1.GetCodigo == m2.GetCodigo) 
                {
                    validacion = true;
                }
            }

            return validacion;
        }

        public static bool operator !=(Mercaderia m1, Mercaderia m2) 
        {
            return !(m1 == m2);
        }

        public string ValidarDatosMercaderia(string articulo, string marca,string categoria, string tipo, float precio, int stock) 
        {
            string cadena = string.Empty;
            StringBuilder texto = new StringBuilder();

            if (string.IsNullOrWhiteSpace(articulo)) 
            {
                texto.AppendLine("Ingrese el nombre del articulo");
            }

            if (string.IsNullOrWhiteSpace(marca)) 
            {
                texto.AppendLine("Ingrese la marca");
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                texto.AppendLine("Seleccione una categoria");
            }

            if (string.IsNullOrWhiteSpace(tipo))
            {
                texto.AppendLine("Seleccione un tipo");
            }

            if (precio<1)
            {
                texto.AppendLine("Ingrese un precio valido");
            }

            if(stock <0)
            {
                texto.AppendLine("Ingrese un stock valido");
            }

            cadena = Convert.ToString(texto);

            return cadena;
        }
    }
}