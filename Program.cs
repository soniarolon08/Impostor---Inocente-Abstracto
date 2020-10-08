using System;

namespace Abstracto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inocentes

            //Objetos

            Mecanico _mecanico = new Mecanico ("Rosa", 60.1f, "Melanie", 4);
            Ingeniero _ingeniero = new Ingeniero ("Celeste", 80.3f, "Sandra", 2);
            Seguridad _seguridad = new Seguridad ("Violeta", 20.5f, "Sabrina", 5);

            Mecanico _mecanico2 = new Mecanico ();
            Ingeniero _ingeniero2 = new Ingeniero ();
            Seguridad _seguridad2 = new Seguridad ();

            
            //HERENCIA DE ATRIBUTOS / USO DE METODOS - inocentes

            Console.WriteLine("\n------------ INOCENTES ----------------\n");

            Console.WriteLine("\n------------ MECANICOS ----------------\n");

            //#1
            Console.WriteLine(_mecanico.GetColor());
            Console.WriteLine(_mecanico.GetPeso().ToString() + "Kg");
            Console.WriteLine(_mecanico.GetNombre());

            _mecanico.RealizarTarea();
            _mecanico.Correr();
            _mecanico.UsarPuertas();

            //#2
            _mecanico2.RealizarTarea();
            _mecanico2.Correr();
            _mecanico2.UsarPuertas();

            Console.WriteLine("\n------------ INGENIEROS ----------------\n");

            //#1
            Console.WriteLine(_ingeniero.GetColor());
            Console.WriteLine(_ingeniero.GetPeso().ToString() + "Kg");
            Console.WriteLine(_ingeniero.GetNombre());

            _ingeniero.RealizarTarea();
            _ingeniero.Correr();
            _ingeniero.UsarPuertas();

            //#2
            _ingeniero2.RealizarTarea();
            _ingeniero2.Correr();
            _ingeniero2.UsarPuertas();
            
            Console.WriteLine("\n------------ GUARDIAS ----------------\n");

            //#1
            Console.WriteLine(_seguridad.GetPeso().ToString() + "Kg");
            Console.WriteLine(_seguridad.GetNombre());
            Console.WriteLine(_seguridad.GetColor());

            _seguridad.RealizarTarea();
            _seguridad.Correr();
            _seguridad.UsarPuertas();
            
            //#2

            _seguridad2.RealizarTarea();
            _seguridad2.Correr();
            _seguridad2.UsarPuertas();

            //Impostores

            //Objetos
            Asesino _asesino = new Asesino ("Negro", 30.6f, "Sonia", 1);
            Saboteador _saboteador = new Saboteador ("Rojo", 25.1f, "Tobias", 3);

            Asesino _asesino2 = new Asesino ();
            Saboteador _saboteador2 = new Saboteador ();

            //HERENCIA DE ATRIBUTOS / USO DE METODOS - impostores 

            Console.WriteLine("\n------------ IMPOSTORES ----------------\n");

            Console.WriteLine("\n------------ ASESINOS ----------------\n");

            //#1
            Console.WriteLine(_asesino.GetPeso().ToString() + "Kg");
            Console.WriteLine(_asesino.GetNombre());
            Console.WriteLine(_asesino.GetColor());

            _asesino.RealizarActoMalvado();
            _asesino.Correr();
            _asesino.UsarPuertas();

            //#2
            _asesino2.RealizarActoMalvado();
            _asesino2.Correr();
            _asesino2.UsarPuertas();

            Console.WriteLine("\n------------ SABOTEADORES ----------------\n");

            //#1
            Console.WriteLine(_saboteador.GetPeso().ToString() + "Kg");
            Console.WriteLine(_saboteador.GetNombre());
            Console.WriteLine(_saboteador.GetColor());

            _saboteador.RealizarActoMalvado();
            _saboteador.Correr();
            _saboteador.UsarPuertas();

            //#2
            _saboteador2.RealizarActoMalvado();
            _saboteador2.Correr();
            _saboteador2.UsarPuertas();


        }
    }
}
