using System;
using System.Text.RegularExpressions;
using SopaDeLetras.Entidades;


namespace SopaDeLetras
{
    public class Program
    {

       

        static void Main(string[] args)
        {
            var SopaLetra = new SopaLetras();
            char[,] sopa;

            Console.WriteLine(" Ingrese la cantidad de columnas para la sopa de letras");
             SopaLetra.cantColumnas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ingrese la cantidad de columnas para la sopa de letras");
            SopaLetra.cantFilas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba palabras que desea utilizar en la sopa de letras, separadas por una coma (,). " +
                "              Todo caracter especial distinto sera tomado como un espacio:");
            SopaLetra.CadenaDePalabras = Console.ReadLine();
            
            SepararPalabras(SopaLetra);
            sopa = (char[,])ArmarSopa(SopaLetra);
            CargarPalabras(SopaLetra, sopa);
            EncontrarPalabra();

        }

      

        private static void SepararPalabras(SopaLetras entrada)
        {
            //Direccion
            // 1 = Arriba
            // 2 = Abajo
            // 3 = Izquierda
            // 4 = Derecha
            int[] Direccion = new int[] {1, 2,3,4 };
            int totalCoordenadas;
            
            var random = new Random();
            totalCoordenadas = entrada.cantColumnas * entrada.cantFilas;
            
            string[] palabras = entrada.CadenaDePalabras.Split(',');
            //Asigno el tamaño del array;
           
            //Por cada palabra, guardo sus letras
            foreach (var word in palabras)
            {
               
                var palabra = new Palabra();
                //Determino una direccion en la cual sera colocada la palabra
                palabra.Direccion = random.Next(0, Direccion.Length);
                palabra.PalabraCompleta = word;
                foreach (var letra in word)
                {
                    palabra.Letras.Add(letra);
                }
                palabra.CantLetras = word.Length;
                palabra.PosX = random.Next(0, entrada.cantFilas);
                palabra.PosY = random.Next(0, entrada.cantColumnas);
                //palabra.EmpiezaEn = random.Next(totalCoordenadas + 1);
                entrada.SopaPalabras.Add(palabra);
                
                
            }

            


        }

        private static Array ArmarSopa(SopaLetras entrada)
        {
            char[,] sopa = new char[entrada.cantFilas, entrada.cantColumnas];
            var random = new Random();

            for (int fila = 0; fila < sopa.GetLength(0); fila++)
            {

                for (int columna = 0; columna < sopa.GetLength(1); columna++)
                {
                    //Lleno la sopa de letras con letras
                    sopa[fila, columna] = (char)(random.Next(25) + 97);
                }


            }

            return sopa;
    

        }
        private static void CargarPalabras(SopaLetras entrada, char[,] sopa)
        {

            foreach (var palabra in entrada.SopaPalabras)
            {
                
               

            }
        }
        private static void EncontrarPalabra()
        {
            /*
            string[] palabras = entrada.Split(',');
            int total;
            Array.Sort(palabras);
            foreach (var palabra in palabras)
            {
                total = Regex.Matches(entrada, palabra).Count;
            System.Console.WriteLine($"Palabra: <{palabra}>, cantidad que repite: {total}");
            }
             */
            throw new NotImplementedException();
        }
    }
}
