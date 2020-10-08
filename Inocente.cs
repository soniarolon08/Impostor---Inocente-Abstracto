using System;

// A la clase inocente la definimos como abstracta por lo tanto habra como minimo un 
// metodo abstracto (RealizarTarea())

public abstract class Inocente
{
    #region Atributos 

        private string Color;
        private float Peso;
        private string Nombre;

    #endregion

    #region Constructor
        
        //Sobrecarga
        //Constructor por defecto

        public Inocente(){
            this.Color = "Blanco";
            this.Peso = 10.2f;
            this.Nombre = "Pablo";
        }

        //Primer constructor

        public Inocente (string color, float peso, string nombre){
            this.Color = color;
            this.Peso = peso;
            this.Nombre = nombre;
        }
    #endregion

    #region Setters y Getters

        //Set
        public void SetColor(string color){
            this.Color = color;
        }
        public void SetPeso(float peso){
            this.Peso = peso;
        }
        public void SetNombre(string nombre){
            this.Nombre = nombre;
        }

        //Get
        public string GetColor(){
            return this.Color;
        }
        public float GetPeso(){
            return this.Peso;
        }
        public string GetNombre(){
            return this.Nombre;
        }

    #endregion

    // Un metodo abstracto solo esta definido y no tiene un cuerpo ejecutable predeterminado.
    // Las clases que hereden de una clase Abstracta SI O SI implementaran el o los metodos
    // abstractos definiendo el cuerpo del metodo abstracto.

    #region Metodos

        public void Correr(){
            Console.WriteLine("Puedo Correr.");
        }
        public void UsarPuertas(){
            Console.WriteLine("Puedo usar puertas.");
        }
        public abstract void RealizarTarea();
        
    #endregion
}