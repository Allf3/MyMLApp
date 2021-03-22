using System;
using MyMLAppML.Model;

namespace MyMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Add input data
            ModelInput input = new ModelInput()
            {
                SentimentText = Convert.ToString(Console.ReadLine())
            };

            
            var result = ConsumeModel.Predict(input);

            

            string sentimentstring = result.Prediction == "1" ? "Negative" : "Positive";

            Console.WriteLine("Using model to make single prediction -- Comparing actual Sentiment with predicted Sentiment from sample data...\n\n");
            Console.WriteLine($"SentimentText: {input.SentimentText}");
            Console.WriteLine($"\n\nPredicted Sentiment value {result.Prediction} \nPredicted Sentiment scores: [{String.Join(",", result.Score)}]\n\n");
            Console.WriteLine($"\n\nPredicted Sentiment: {sentimentstring}");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
