using Microsoft.ML;
using static PricePrediction;

// Load the model
/*MLContext mLContext = new MLContext();
ITransformer mlModel = mLContext.Model.Load("PricePrediction.zip", out var model);
var predEngine = mLContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
*/

// Use the code below to add input data
var input = new ModelInput()
{
  Vendor_id = @"CMT",
  Rate_code = 1F,
  Passenger_count = 1F,
  Trip_time_in_secs = 1000F,
  Trip_distance = 100F,
  Payment_type = @"CRD",
};

// Make a single prediction on the sample data and print results
var predictionResult = PricePrediction.Predict(input);

// Try model on sample data
Console.WriteLine(predictionResult.Score);

Console.WriteLine($"\n\nPredicted Fare_amount: {predictionResult.Score}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();