using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDeAlgoritmos
{
    public class CamelCase
    {//Clase publica CamelCase
        public int calculate(string chainCamelCase)//método público que recibe una cadena de caracteres y retorna el total de palabras que conforman la cadena. 
        {
            //declaración de variables de tipo int
            int capitalLetters = 0;//contador para las mayúsculas
            int lowerCase = 0;//contador para minúsculas
            int totalWord = 0;//variable que almacena la suma de las mayúsculas y minúsculas
            char positionLetters = chainCamelCase[0];//variable que contiene la letra en la posicion 0

            if (char.IsUpper(chainCamelCase[0]))//pregunta se el primer char esta en mayuscula imprime que no es correcto
            {

                Console.WriteLine("No es un string camelCase");
            }

            else
            {//si no
                for (int i = 0; i < chainCamelCase.Length; i++)//ciclo que recorre el string desde la posición cero hasta la longitud de la cadena.
                {
                    //pregunta si hay un caracter en mayuscula en la cadena desde la posicion 0
                    if (char.IsUpper(chainCamelCase[i]))
                    {//si hay mayuscula las acumula.
                        capitalLetters++;

                    }
                    //pregunta si hay un caracter en minuscula en la cadena ingresada desde la posicion 0
                    if (char.IsLower(chainCamelCase[0]))
                    {
                        if (lowerCase == 0)//si la minuscula esta en psoción 0 
                        {
                            lowerCase++;//acumula la minúscula.
                        }

                    }


                }
                //A la variable totalword se le asigna el resultado de la suma de mayúsculas y minúsculas.
                totalWord = lowerCase + capitalLetters;
                //imprime en pantalla el string ingresado con el total de palabras
                Console.WriteLine(string.Format(chainCamelCase + " tiene: {0} ", totalWord + " palabras"));

            }


            Console.ReadKey();//el programa no se cierra hasta que el usuario presione alguna tecla
            return totalWord;//retorna el numero total de palabras.





        }

    }
}
