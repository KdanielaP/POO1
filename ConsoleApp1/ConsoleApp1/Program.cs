using System;

namespace ConsoleAPP1
{

    // Abstracción
    public abstract class Animal
    {
        public abstract void EmitirSonido();
    }

    // Encapsulación
    public class Perro : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Guau guau!");
        }
    }

    public class Gato : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Miau miau!");
        }
    }

    // Polimorfismo
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine("Examinando al animal...");
            animal.EmitirSonido();
        }
    }

    // Herencia
    public class PerroCaliente : Perro
    {
        public void Servir()
        {
            Console.WriteLine("¡Listo para servir como un perro caliente!");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Perro perro = new Perro();
            Gato gato = new Gato();

            Veterinario veterinario = new Veterinario();
            veterinario.Examinar(perro);
            veterinario.Examinar(gato);

            PerroCaliente perroCaliente = new PerroCaliente();
            perroCaliente.EmitirSonido();
            perroCaliente.Servir();
        }
    }
}