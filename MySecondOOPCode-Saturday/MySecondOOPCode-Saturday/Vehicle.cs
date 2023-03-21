using System;
using System.Collections.Generic;
using System.Text;

namespace MySecondOOPCode_Saturday
{
    public abstract class Vehicle
    {
        #region Properties

        public String Brand { get; set; }

        public String Model { get; set; }

        public String Reference { get; set; }

        #endregion

        #region Methods

        //Método no lleva llaves porque no tiene implementación por ser abstracto
        public abstract decimal CalculateFinalPrice();

        public override string ToString()
        {
            return  $"--------VEHICLE-------- \n\t" +
                    $" Brand............{Brand} \n\t" +
                    $" Model............{Model} \n\t" +
                    $" Reference........{Reference} \n\t";
        }

        #endregion

    }
}
