using System;
using System.Collections.Generic;
using System.Text;
using MyMLAppML.Model;
using DataAccesLayer.Entity;

namespace MachineLearningLayer
{
    public interface IHousePricingService
    {
        int CreateHousePredict(ModelInput modeldata);
    }
}
