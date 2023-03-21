using System;
using System.Collections.Generic;
using System.Text;

namespace MySecondOOPCode_Saturday
{
    public class HumanPoweredVehicle : Vehicle
    {
        #region Propeties
        public decimal EnvironmentalSubsidy { get; set; }

        #endregion

        #region Methods
        //override hace sobrescritura del método abstracto
        public override decimal CalculateFinalPrice()
        {
            return EnvironmentalSubsidy;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Final price........{CalculateFinalPrice():C2}";
        }
        #endregion


    }
}
