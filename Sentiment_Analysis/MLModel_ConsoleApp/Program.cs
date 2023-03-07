using MLModel_ConsoleApp;
using System;
// Add input data
var sampleData = new MLModel.ModelInput()
{
    Col0 = "This restaurant was wonderful."
};

// Load model and predict output of sample data
var result = MLModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.Prediction == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");