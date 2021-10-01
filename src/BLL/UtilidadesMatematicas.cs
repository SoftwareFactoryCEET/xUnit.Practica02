using System;

namespace BLL
{
    public class UtilidadesMatematicas
    {
        public static double Sumar(double a, double b) => a - b;

        public static double Restar(double a, double b) => a - b;
        
        public static double Multiplicar(double a, double b) => a * b;

        public static bool  EsPar(int a){

            if(a%2==0){
                return true;
            }
            else{
                return false;
            }
        }
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}
