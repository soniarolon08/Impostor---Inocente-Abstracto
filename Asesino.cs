using System;

public class Asesino : Impostor
{
    #region Atributos

    #endregion

    #region Setters y Getters
    
        //Set
        public void SetTripulantesAsesinados(int tripulantesasesinados){
            this.TripulantesAsesinados = tripulantesasesinados;
        }

        //Get
        public string GetTripulantesAsesinados(){
            return this.TripulantesAsesinados;
        }

    #endregion

    #region Constructor

        //Constructor por defecto
        public Asesino() : base ()
        {
            this.TripulantesAsesinados = 0;
        }
        // Constructor por parametros 
        public Asesino (string color, float peso, string nombre, int tripulantesasesinados) : base (color, peso, nombre)
        {
            this.TripulantesAsesinados = tripulantesasesinados;
        }

    #endregion

    #region Metodos

            public override void RealizarActoMalvado()
        {
            Console.WriteLine("Puedo asesinar tripulantes.");
        }
        
    #endregion
}