using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;
using DataAccesLayer.Entity;
using MyMLAppML.Model;
using System.Linq;

namespace MachineLearningLayer.HousePricingService
{
    public class HousePricingService : IHousePricingService
    {
        private readonly MachineContext _context;

        public HousePricingService(MachineContext context)
        {
            _context = context;
        }

        public int CreateHousePredict(ModelInput modeldata)
        {
            ModelOutput predictionResult = ConsumeModel.Predict(modeldata);

            House myHouse = new House
            {
                Date = modeldata.Date,
                Bedrooms = modeldata.Bedrooms,
                Bathrooms = modeldata.Bathrooms,
                Sqft_living = modeldata.Sqft_living / 0.0929f,
                Sqft_lot = modeldata.Sqft_lot / 0.0929f,
                Floors = modeldata.Floors,
                Waterfront = modeldata.Waterfront,
                View = modeldata.View,
                Condition = modeldata.Condition,
                Sqft_above = modeldata.Sqft_above / 0.0929f,
                Sqft_basement = modeldata.Sqft_basement / 0.0929f,
                Yr_built = modeldata.Yr_built,
                Yr_renovated = modeldata.Yr_renovated,
                City = modeldata.City,
                Statezip = modeldata.Statezip,
                PredictedScore = predictionResult.Score
            };

            _context.Houses.Add(myHouse);

            int result = _context.SaveChanges();

            return result;
        }

        public List<House> houses()
        {
            return _context.Houses.ToList();
        }
    }
}
