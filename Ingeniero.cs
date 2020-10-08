using System;

public class Ingeniero : Inocente
{
    #region Atributos

    #endregion

    #region Setters y Getters

        //Set
        public void SetNavegacionesAlineadas(int navegacionesalineadas){
            this.NavegacionesAlineadas = navegacionesalineadas;
        }

        //Get
        public string GetNavegacionesAlineadas(){
            return this.NavegacionesAlineadas;
        }
    #endregion

    #region Constructor

        //Constructor por defecto
        public Ingeniero() : base ()
        {
            this.NavegacionesAlineadas = 0;
        }

        // Constructor por parametros 
        public Ingeniero (string color, float peso, string nombre, int navegacionesalineadas) : base (color, peso, nombre)
        {
            this.NavegacionesAlineadas = navegacionesalineadas;
        }

    #endregion

    #region Metodos
    
        public override void RealizarTarea()
        {
            Console.WriteLine("Puedo alinear navegaciones.");
        }

    #endregion

}