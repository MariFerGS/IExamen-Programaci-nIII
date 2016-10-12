using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDeAlgoritmos
{
    public class DiagonalDifference
    {//clase publica 
        public int matrix(string matriz)
        {//metodo publico que ingresa string y devuelve la diferencia de la suma del total de las diagonales de una matriz
            string[] filas = matriz.Split('|');//separa la cadena ingresada en el simbolo | para saber cuantas filas son
            int diagonalPrincipal = 0;//variable que nos ayuda almacenar el total de la primera diagonal
            int diagonalSecundaria = 0;//variable que nos ayuda almacenar el total de la segunda diagonal
            int totalDiferenciaSuma = 0;//variable que contiene el totalde las suma de las diagonales menos el resultado de ambas
            matriz = matriz.Replace(' ', ',');//remplaza los espacios por comas
            matriz = matriz.Replace('|', ',');// remplaza la barra por comas
            int cantidadmatriz = filas.Length;//variable que almacena el total de filas
            int[,] tamanoMatriz = new int[cantidadmatriz, cantidadmatriz];//tamaño de la matriz por filas y columnas, como es cuadrada ambas medidas son iguales
            String[] subcadena = matriz.Split(',');//separa la cadena donde existan comas y la asigna a una nueva variable
            int contador = 0;//contador para pasar de string a int
               //for que recorre el string original por filas y columnas desde la posiciòn 0 hasta el tamaño de la matriz
            for (int i = 0; i < cantidadmatriz; i++)
            {
                for (int y = 0; y < cantidadmatriz; y++)
                {
                    //los acomoda como matriz y los convierte a int creando una nueva subcadena
                    tamanoMatriz[i, y] = Convert.ToInt32(subcadena[contador]);
                    contador++;//almacena los nuevos numeros
                }

            }
//Recorre filas y columnas e Imprime la nueva matriz con los nuevos valores

            for (int i = 0; i < cantidadmatriz; i++)
            {
                for (int j = 0; j < cantidadmatriz; j++)

                    Console.Write(tamanoMatriz[i, j] + "\t");

                Console.WriteLine();


            }
               //Recorre la nueva matriz y va sumando los numeros de la diagonal principal
            for (int i = 0; i < cantidadmatriz; i++)
            {
                diagonalPrincipal = diagonalPrincipal + tamanoMatriz[i, i];
            }
            //Recorre la nueva matriz por filas y columnas, va sumando los numeros de la diagonal secundaria
            for (int i = 0; i < cantidadmatriz; i++)
            {
                for (int j = 0; j < cantidadmatriz; j++)
                {
                    if ((cantidadmatriz + 1) == (i + j +2))///pregunta que si el tamaño de la matriz + 1 es igual al numero de la fila+la columna + el numero 2
                        diagonalSecundaria += tamanoMatriz[i, j];//acumula los numeros seleccionados arriba y los suma entre si, la suma la signa a la variable diagonall secundaria
                }
            }

            Console.WriteLine();//imprime espacio
            Console.WriteLine("Suma de los valores de la diagonal principal: " + diagonalPrincipal);//imprime el total de la diagonal principal
            Console.WriteLine("Suma de los valores de la diagonal secundaria: " + diagonalSecundaria);//imprime el total de la suma de la diagonal secundaria
            totalDiferenciaSuma = diagonalPrincipal - diagonalSecundaria;//total de la diferencia de la suma de las diagonales
            Console.WriteLine("Total diagonales: " + totalDiferenciaSuma);//muestra la resta del total de las diagonales
            Console.ReadLine();//mantiene el programa en ejecuciòn hasta que se presione alguna tecla
            return totalDiferenciaSuma;//retorna el valor de la deferencia de la suma

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DiagonalDifference sumadiagonales = new DiagonalDifference();//intancia de la clase diagonal difference
            string matrizDeNumeros = "4 5 2 12 3|11 6 4 2 2|4 6 3 2 5|11 3 6 7 2|4 4 1 5 6";//string que recibe el metodo
            int matriz = sumadiagonales.matrix(matrizDeNumeros);//llama al metodo y a la clase para pasarle el string definido

            CamelCase words = new CamelCase();//instancia de la clase CamelCase
            string chainWords = "arrozConLecheMeQuieroCasarConUnaSeñoritaDeLaCapital";//string que va a recibir el metodo
            int totalWords = words.calculate(chainWords);//llama al metodo y a la clase para pasarle el string definido anteriormente,
            //con el fin de que retorne en un int el total de palabras que tiene el string.



        }
    }
}


