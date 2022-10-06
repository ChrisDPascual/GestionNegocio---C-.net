using System;

namespace Validaciones
{
    public class Validaciones
    {
        public static bool ValidarNombres(string nombre)
        {
            bool validacion = false;

            if (!(string.IsNullOrWhiteSpace(nombre)))
            {
                validacion = true;
            }
            return validacion;
        }

        public static bool ValidarNumeroMayorCero(int numero)
        {
            bool validacion = false;
            if (numero > 0)
            {
                validacion = true;
            }
            return validacion;
        }

        public static bool VerificacionPago(float pago, float total) 
        {
            bool retorno = false; ;
            if(total>=pago && pago > 0) 
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool ValidarFecha(int dia, int mes, int año) 
        {
            bool validacion = false;
            int banderaD = 0;
            int banderaM = 0;
            int banderaA = 0;

            if(dia>0 && dia < 32) 
            {
                banderaD = 1;
            }

            if(mes>0 && mes < 13) 
            {
                if (ValidarMes(dia, mes, año)) 
                {
                    banderaM = 1;
                }
            }

            if (año > 1900) 
            {
                banderaA = 1;
            }

            if(banderaA==1 && banderaD ==1 && banderaM == 1) 
            {
                validacion = true;
            }

            return validacion;
        }

        public static bool ValidarMes(int dia, int mes,int anio) 
        {
            bool validacion = false;

            if(mes == 2) 
            {
                if(dia == 29 && AñoBisiesto(anio)) 
                {
                    validacion = true;
                }
                else 
                {
                    if (dia < 29)
                    {
                        validacion = true;
                    }
                }
            }
            else 
            {
                if(mes ==4 || mes==6 || mes==9 || mes == 11) 
                {
                    if (dia < 31) 
                    {
                        validacion = true;
                    }
                }
                else 
                {
                    if(mes == 1 || mes == 3 || mes==5 || mes ==7 || mes == 8 || mes ==10 || mes == 12) 
                    {
                        if(dia < 32) 
                        {
                            validacion = true;
                        }
                    }
                }
            }

            return validacion;
        }

        public static bool AñoBisiesto(int anio) 
        {
            bool validacion = false;

            if(anio % 4 == 0 && anio % 400 == 0 && anio % 100 == 0) 
            {
                validacion = true;
            }

            return validacion;
        }
    }
        
}
