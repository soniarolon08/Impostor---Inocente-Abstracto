using System;

public class Seguridad : Inocente
{
    #region Atributos

    #endregion

    #region Setters y Getters

        //Set
        public void SetCamarasRevisadas(int camarasrevisadas){
            this.CamarasRevisadas = camarasRevisadas;
        }

        //Get
        public string GetCamarasRevisadas(){
            return this.CamarasRevisadas;
        }

    #endregion

    #region Constructor

        //Constructor por defecto
        public Seguridad() : base ()
        {
            this.CamarasRevisadas = 0;
        }
        // Constructor por parametros 
        public Seguridad (string color, float peso, string nombre, int camarasrevisadas) : base (color, peso, nombre)
        {
            this.CamarasRevisadas = camarasrevisadas;
        }

    #endregion

    #region Metodos

            public override void RealizarTarea()
        {
            Console.WriteLine("Puedo revisar camaras de seguridad.");
        }

    #endregion
}