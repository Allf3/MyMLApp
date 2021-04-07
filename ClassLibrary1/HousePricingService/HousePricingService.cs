﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;
using DataAccesLayer.Entity;
using MyMLAppML.Model;

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
                Sqft_living = modeldata.Sqft_living,
                Sqft_lot = modeldata.Sqft_lot,
                Floors = modeldata.Floors,
                Waterfront = modeldata.Waterfront,
                View = modeldata.View,
                Condition = modeldata.Condition,
                Sqft_above = modeldata.Sqft_above,
                Sqft_basement = modeldata.Sqft_basement,
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
    }
}