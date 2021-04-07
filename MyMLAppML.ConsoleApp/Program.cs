// This file was auto-generated by ML.NET Model Builder. 

using System;
using MyMLAppML.Model;

namespace MyMLAppML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Date = @"2014-05-02 00:00:00",
                Bedrooms = 3F,
                Bathrooms = 1.5F,
                Sqft_living = 1340F,
                Sqft_lot = 7912F,
                Floors = 1.5F,
                Waterfront = 0F,
                View = 0F,
                Condition = 3F,
                Sqft_above = 1340F,
                Sqft_basement = 0F,
                Yr_built = 1955F,
                Yr_renovated = 2005F,
                City = @"Shoreline",
                Statezip = @"WA 98133",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Price with predicted Price from sample data...\n\n");
            Console.WriteLine($"Date: {sampleData.Date}");
            Console.WriteLine($"Bedrooms: {sampleData.Bedrooms}");
            Console.WriteLine($"Bathrooms: {sampleData.Bathrooms}");
            Console.WriteLine($"Sqft_living: {sampleData.Sqft_living}");
            Console.WriteLine($"Sqft_lot: {sampleData.Sqft_lot}");
            Console.WriteLine($"Floors: {sampleData.Floors}");
            Console.WriteLine($"Waterfront: {sampleData.Waterfront}");
            Console.WriteLine($"View: {sampleData.View}");
            Console.WriteLine($"Condition: {sampleData.Condition}");
            Console.WriteLine($"Sqft_above: {sampleData.Sqft_above}");
            Console.WriteLine($"Sqft_basement: {sampleData.Sqft_basement}");
            Console.WriteLine($"Yr_built: {sampleData.Yr_built}");
            Console.WriteLine($"Yr_renovated: {sampleData.Yr_renovated}");
            Console.WriteLine($"City: {sampleData.City}");
            Console.WriteLine($"Statezip: {sampleData.Statezip}");
            Console.WriteLine($"\n\nPredicted Price: {predictionResult.Score}\n\n");           
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
