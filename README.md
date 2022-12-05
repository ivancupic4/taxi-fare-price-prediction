# ML.NET Taxi Fare Price Prediction

This Machine Learning project is a demonstration of the ML.NET's ability to train a model and use that model to make a prediction. 

This example uses ```taxi-fare-train.csv``` file with taxi fare data to train the model. The trainer used is ```LightGbmRegressionTrainer```. 

The columns from the source file used are: ```vendor_id```, ```rate_code```, ```passenger_count```, ```trip_time_in_secs```, ```trip_distance```, ```payment_type```. 
The column we are predicting is ```fare_amount```. 
