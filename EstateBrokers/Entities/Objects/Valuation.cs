using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Objects
{
    public class Valuation
    {
        public double BasePrice { get; set; } = 5000;
        public int SquareMeter { get; set; }
        public int HouseCondition { get; set; }
        public bool IsDesignerHouse { get; set; }
        public bool HasGarden { get; set; }
        public bool HasBasement { get; set; }
        public bool HasGarage { get; set; }
        public double EstimatedValuation { get; set; }

        public Valuation(int squareMeter, int houseCondition, bool isDesignerHouse, bool hasGarden, bool hasBasement, bool hasGarage)
        {
            SquareMeter = squareMeter;
            HouseCondition = houseCondition;
            IsDesignerHouse = isDesignerHouse;
            HasGarden = hasGarden;
            HasBasement = hasBasement;
            HasGarage = hasGarage;
        }

        //Grasp - Information Expert
        public double CalculateValuation()
        {
            double calculatedValuation = BasePrice;

            double conditionMultiplier = HouseCondition;

            calculatedValuation *= 1 + conditionMultiplier / 20;

            calculatedValuation = IsDesignerHouse ? calculatedValuation * 1.6 : calculatedValuation;
            calculatedValuation = HasBasement ? calculatedValuation * 1.2 : calculatedValuation;
            calculatedValuation = HasGarden ? calculatedValuation * 1.2 : calculatedValuation;
            calculatedValuation = HasGarage ? calculatedValuation * 1.1 : calculatedValuation;

            double evaluation = calculatedValuation * SquareMeter;

            return evaluation;
        }

    }

    
}
