using System;

public class Mecanico : Inocente
{
    #region Atributos

    #endregion

    #region Setters y Getters

        //Set
        public void SetNucleosReparados(int nucleosreparados){
            this.NucleosReparados = nucleosreparados;
        }

        //Get
        public string GetNucleosReparados(){
            return this.NucleosReparados;
        }
        
    #endregion

    #region Constructor

        //Constructor por defecto
        public Mecanico() : base ()
        {
            this.NucleosReparados = 0;
        }

        //Constructor por parametros

        public Mecanico(string color, float peso, string nombre, int nucleosreparados) : base (color, peso, nombre)
        {
            this.NucleosReparados = nucleosreparados;
        }

    #endregion

    #region Metodos

    // Se usa el override cuando vamos a programar el cuerpo de nuestro metodo abstracto.
    // Definir un solo metodo realizar tarea y despues cada clase hija va a poder hacer la tarea de la forma que quiera.
    // Esto tiene que ver con el tema polimorfismo.
    
        public override void RealizarTarea()
        {
            Console.WriteLine("Puedo reparar el nucleo.");
        }

    #endregion
}