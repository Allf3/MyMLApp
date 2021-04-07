using System;
using System.Collections.Generic;
using System.Text;
using MyMLAppML.Model;

namespace DataAccesLayer.Entity
{
    public class House : ModelInput
    {       
        public int ID { get; set; }

        public float PredictedScore { get; set; }
    }
}
