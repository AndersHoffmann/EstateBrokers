
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.EvaluateProperty
{
    //GRASP - Low coupling
    public class EvaluatePropertyRequestModel
    {
        public int SquareMeter { get; set; }
        public int HouseCondition { get; set; }
        public bool IsDesignerHouse { get; set; }
        public bool  HasGarden { get; set; }
        public bool HasBasement { get; set; }
        public bool HasGarage { get; set; }
    }
}
