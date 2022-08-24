using System;

namespace PrimeraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo"); // comentario

            /*
             * ESTE ES EL EJEMPLO
             * DE UN COMENTARIO
             * DE VARIAS LINEAS
             */

            string texto;
            texto = "Hola desde variable string";
            Console.WriteLine(texto);

            // division en consola
            // el resultado es entero ya que ambos numeros lo son
            Console.WriteLine(5 / 2);

            // concatenar strings con operador +
            int edad = 35;
            Console.WriteLine("Tu edad es " + edad + " años");

            // incrementar edad
            //edad = edad + 1;
            edad++;

            // interpolación de strings
            Console.WriteLine($"Tu edad con interpolacion es {edad} años");

            // OPERADORES DE ASIGNACION

            byte numero = 30;
            //numero = Convert.ToByte(numero + 10);
            numero += 10;
            Console.WriteLine(numero);

            // asignaciones multiples

            int numero1;
            int numero2;
            int numero3;

            numero1 = numero2 = numero3 = 27;

            Console.WriteLine($"{numero1} desde numero1");

            // DECLARACIONES IMPLICITAS DE VARIABLES

            // al declarar la variable si no especificamos el tipo lo asigna automaticamente
            var numeroImplicito = 26;

            // conversion implicita
            double numeroDouble = 10;
            Console.WriteLine(numeroDouble);

            // conversion explicita
            // perdemos informacion ya que un tipo entero no puede contener decimal
            int doubleAInt = (int)10.5;
            Console.WriteLine(doubleAInt);

            // convertir de texto a numero
            Console.WriteLine("Ingrese el primer valor numerico");
            int valorIntroducido1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor numerico");
            int valorIntroducido2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El valor de la multiplicacion de {valorIntroducido1} y {valorIntroducido2} es {valorIntroducido1 * valorIntroducido2}");


            // CONSTANTES
            // las constantes no varian y se deben asignar en la declaración
            // suelen escribirse en mayusculas

            const int NUMEROCONSTANTE = 5;
        }
    }
}
