
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Organizacion;

namespace Entidades_Organizacion
{
    public  class Sobrecargas
    {
        public static Duenio SobreCargaDuenio() 
        {
            Duenio elDueño = new Duenio("Michael","Scott",35371754,"masculino",9999, new DateTime(1990,12,16));

            return elDueño;
        }

        public static Vendedor SobrecargaVendedor1()
        {
            Vendedor Vendedor = new Vendedor("Jim", "Halpert", 37480111, "masculino",new DateTime (2000,3,25),"activo",new DateTime(1993, 2, 2), 1137780934, "jimhalpert@gmail.com","Sucre 293");

            return Vendedor;
        }

        public static Vendedor SobrecargaVendedor2()
        {
            Vendedor Vendedor = new Vendedor("Dwight", "Schrute", 40111857, "masculino", new DateTime(1998, 5, 3), "activo", new DateTime(1994, 1, 7), 1587367248, "DSchrute@gmail.com", "pinzon 468");

            return Vendedor;
        }

        public static Vendedor SobrecargaVendedor3()
        {
            Vendedor Vendedor = new Vendedor("Pam", "Beesley", 32547110, "femenino", new DateTime(1999, 9, 1), "activo", new DateTime(1992, 12, 25), 1147856321, "PamB@yahoo.com", "cabildo 2225",DateTime.Now);

            return Vendedor;
        }

        public static Vendedor SobrecargaVendedor4()
        {
            Vendedor Vendedor = new Vendedor("Andy", "Bernard", 29800745, "masculino", new DateTime(2002, 8, 22), "despedido", new DateTime(1989, 7, 3), 1147521765, "AnBer@hotmail.com", "scranton 1725",DateTime.Now);

            return Vendedor;
        }

        public static Cliente Cliente1() 
        {
            Cliente cliente = new Cliente("generico", "generico", 11111111, "masculino", new DateTime(1991, 5, 5), 11111111, "sinmail@gmail.com","calle falsa 123");
            return cliente;
        }

        public static Cliente Cliente2()
        {
            Cliente cliente = new Cliente("Carlos", "Gomez", 12571874, "masculino", new DateTime(1995, 7, 19), 12348345, "CarloP@gmail.com", "Suipacha 123");
            return cliente;
        }

        public static Cliente Cliente3()
        {
            Cliente cliente = new Cliente("Juana", "Centurion", 25471812, "femenino", new DateTime(2005, 12, 9), 353775415, "JuanaStone@hotmail.com", "Florida 343");
            return cliente;
        }

        public static Cliente Cliente4()
        {
            Cliente cliente = new Cliente("Maria", "Schenardi", 31784554, "femenino", new DateTime(2001, 1, 25), 845124352, "Maria2001@hotmail.com", "Corrientes 1354");
            return cliente;
        }
        public static Mercaderia SobrecargaMercaderia1() 
        {
            Mercaderia Articulo = new Mercaderia("mouse","genius", 1705420, "perifericos", eTipoMercaderia.Generico, 1099, 10);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia2()
        {
            Mercaderia Articulo = new Mercaderia("placa de video GTX 16600 ti", "nvdia", 1110330, "placas de video", eTipoMercaderia.Gaming, 69999, 7);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia3()
        {
            Mercaderia Articulo = new Mercaderia("monitor","asus", 1050990, "perifericos", eTipoMercaderia.Gaming, 39000, 4);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia4()
        {
            Mercaderia Articulo = new Mercaderia("procesador intel core i7 10700","intel", 1238129, "procesadores", eTipoMercaderia.Diseño, 49999, 2);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia5()
        {
            Mercaderia Articulo = new Mercaderia("mouse m908","redragon", 1940214, "perifericos", eTipoMercaderia.Gaming, 5000, 1);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia6()
        {
            Mercaderia Articulo = new Mercaderia("Auriculares con microfono","generico", 1000331, "perifericos", eTipoMercaderia.Generico, 2399, 11);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia7()
        {
            Mercaderia Articulo = new Mercaderia("Tableta Grafica Digitalizadora","mac", 1113251, "perifericos", eTipoMercaderia.Diseño, 10999, 0);
            return Articulo;
        }

        public static Mercaderia SobrecargaMercaderia8()
        {
            Mercaderia Articulo = new Mercaderia("Funda netbook 14´","generico", 1686411, "accesorios", eTipoMercaderia.Generico, 2499, 3);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia9()
        {
            Mercaderia Articulo = new Mercaderia("teclado mecanico","hyperx", 1612286, "perifericos", eTipoMercaderia.Gaming, 7999, 2);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia10()
        {
            Mercaderia Articulo = new Mercaderia("placa de video Radeon Rx 500","amd", 1163521, "placas de video", eTipoMercaderia.Gaming, 79999, 2);
            return Articulo;

        }
        public static Mercaderia SobrecargaMercaderia11()
        {
            Mercaderia Articulo = new Mercaderia("mousepad","logitech",1155570, "accesorios", eTipoMercaderia.Generico, 799, 5);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia12()
        {
            Mercaderia Articulo = new Mercaderia("cable ethernet 2 metros","generico", 1896123, "accesorios", eTipoMercaderia.Generico, 399, 14);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia13()
        {
            Mercaderia Articulo = new Mercaderia("motherboard B560M DS3H", "gygabite", 1991335, "placas madre", eTipoMercaderia.Diseño, 18399, 9);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia14()
        {
            Mercaderia Articulo = new Mercaderia("disco duro 1 tera","kingston", 1669007, "almacenamiento", eTipoMercaderia.Generico, 7099, 1);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia15()
        {
            Mercaderia Articulo = new Mercaderia("memoria ram 16bg","kingston", 1776321, "memorias ram", eTipoMercaderia.Gaming, 14399, 11);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia16()
        {
            Mercaderia Articulo = new Mercaderia("impresora","hp", 1177119, "perifericos", eTipoMercaderia.Diseño, 29999, 0);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia17()
        {
            Mercaderia Articulo = new Mercaderia("windows 10","windows", 1966113, "software", eTipoMercaderia.Generico, 5000, 22);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia18()
        {
            Mercaderia Articulo = new Mercaderia("pendrive 64 gb","scandisk", 1602431, "almacenamiento", eTipoMercaderia.Generico, 5229, 17);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia19()
        {
            Mercaderia Articulo = new Mercaderia("memoria ram vyper 16gb","patriot", 1100663, "memorias ram", eTipoMercaderia.Gaming, 21999, 12);
            return Articulo;
        }
        public static Mercaderia SobrecargaMercaderia20()
        {
            Mercaderia Articulo = new Mercaderia("procesador ryzen 5","amd" ,1966111, "procesadores", eTipoMercaderia.Gaming, 61099, 0);
            return Articulo;
        }
    }
}
