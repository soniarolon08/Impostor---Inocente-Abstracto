using System;

public class Saboteador : Impostor
{
    #region Atributos

    #endregion

    #region Setters y Getters

        //Set
        public void SetSabotajesRealizados(int sabotajesrealizados){
            this.SabotajesRealizados = sabotajesrealizados;
        }

        //Get
        public string GetSabotajesRealizados(){
            return this.SabotajesRealizados;
        }

    #endregion

    #region Constructor

        //Constructor por defecto
        public Saboteador() : base ()
        {
            this.SaboteajesRealizados = 0;
        }
        // Constructor por parametros
        public Saboteador (string color, float peso, string nombre, int sabotajesrealizados) : base (color, peso, nombre)
        {
            this.SaboteajesRealizados = sabotajesrealizados;
        }

    #endregion

    #region Metodos

            public override void RealizarActoMalvado()
        {
            Console.WriteLine("Puedo realizar saboteos.");
        }
        
    #endregion
}