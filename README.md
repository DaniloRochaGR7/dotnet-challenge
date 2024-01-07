# dotnet-challenge

# Weather Data Analysis

This repository contains a solution with two simple projects written in .NET Core consolle application.

This code was written in adherence to the SOLID principles, which is why functions are isolated into separate classes each with a single responsibility. This design enhances maintainability and makes the code easier to understand and test.

## Average Temperature

This program fetches weather data from a JSON API and performs some analysis on it. The main steps are as follows:

1. **Fetch Weather Data**: The `FetchWeatherDataAsync` method fetches weather data from a specified URL. It uses the `JsonServices.GetJsonDataAsync` method to fetch the data and then deserializes it into a `WeatherData` object using `JsonSerializer.Deserialize`.

2. **Filter Observations**: The `FilterObservations` method filters the observations from the `WeatherData` object. It only keeps the observations where the name is "Adelaide Airport" and the observation time is within the last 72 hours.

3. **Calculate Average Temperature**: The `CalculateAverageTemperature` method calculates the average temperature from the filtered observations.

The program then prints the average temperature for the previous 72 hours.

In case of any exceptions during the execution, the program catches them and prints an error message.

To use this code, you need to call the `Main` method. It's an asynchronous method, so you need to use the `await` keyword when calling it.
