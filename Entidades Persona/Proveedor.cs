using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Organizacion
{
    public class Proveedor : Duenio
    {
        private string nombreFicticio;
        private long CUIL;
        private List<Mercaderia> listadoMercaderia;
        public Proveedor()
        {
        }
        public Proveedor(string nombre, long CUIL) : base()
        {
            this.nombreFicticio = nombre;
            this.CUIL = CUIL;
            this.listadoMercaderia = new List<Mercaderia>();
        }

        public string GetNombreFicticio 
        {
            get { return this.nombreFicticio; }
        }
        public List<Mercaderia> GetListaProveedor
        {
            get { return this.listadoMercaderia; }
            set { this.listadoMercaderia = value; }

        }

        public static bool operator +(Proveedor p, Mercaderia m)
        {
            bool retorno = true;
            if (!(p is null || m is null))
            {
                foreach (var item in p.GetListaProveedor)
                {
                    if (m.GetCodigo == item.GetCodigo)
                    {
                        retorno = false;
                        break;
                    }
                }
            }

            if (retorno == true)
            {
                p.GetListaProveedor.Add(m);
            }

            return retorno;
        }
        public static bool operator ==(Proveedor p, Mercaderia m)
        {
            bool retorno = false;

            if (!(p is null || m is null))
            {
                foreach (var item in p.GetListaProveedor)
                {
                    if (m.GetCodigo == item.GetCodigo)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Proveedor p, Mercaderia m)
        {
            return !(p == m);
        }
        public bool ComprarMercaderia(Proveedor p, int codigo, int cantidad)
        {
            bool retorno = false;
            if (!(p is null))
            {
                foreach (Mercaderia item in p.GetListaProveedor)
                {
                    if (codigo == item.GetCodigo)
                    {
                        if (item.GetSetStock >= cantidad)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }

        public string buscarNombreProveedor(int codigo) 
        {
            string retorno = string.Empty;

         
                foreach(Mercaderia item in this.GetListaProveedor) 
                {
                    if(item.GetCodigo == codigo) 
                    {
                        retorno = this.nombreFicticio;
                        break;
                    }
                }
            

            return retorno;
        }
    }
}
