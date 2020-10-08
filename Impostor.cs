using System;

public abstract class Impostor
{
    #region Atributos 

        private string Color;
        private float Peso;
        private string Nombre;

    #endregion

    #region Constructor

        //Sobrecarga
        //Constructor por defecto

        public Impostor(){
            this.Color = "Negro";
            this.Peso = 12.2f;
            this.Nombre = "Federico";
        }

        //Primer constructor
        public Impostor (string color, float peso, string nombre){
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

    #region Metodos

        public void Correr(){
            Console.WriteLine("Puedo Correr.");
        }
        public void UsarPuertas(){
            Console.WriteLine("Puedo usar puertas.");
        }
        public abstract void RealizarActoMalvado();
        
    #endregion
}