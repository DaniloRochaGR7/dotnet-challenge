# Weather Data Analysis

This repository contains a solution with two simple projects and a library, written in .NET Core consolle application.

- Average Temperature - .NET Core Console Application
- WeatherObservation - .NET Core Rest API Application
- CommonResources - Class library with common resources between the other 2 applications

This code was written in adherence to the SOLID principles, which is why functions are isolated into separate classes each with a single responsibility. This design enhances maintainability and makes the code easier to understand and test.

## Average Temperature

This program fetches weather data from a JSON API and performs some analysis on it. The main steps are as follows:

1. **Fetch Weather Data**: The `FetchWeatherDataAsync` method fetches weather data from a specified URL. It uses the `JsonServices.GetJsonDataAsync` method to fetch the data and then deserializes it into a `WeatherData` object using `JsonSerializer.Deserialize`.

2. **Filter Observations**: The `FilterObservations` method filters the observations from the `WeatherData` object. It only keeps the observations where the name is "Adelaide Airport" and the observation time is within the last 72 hours.

3. **Calculate Average Temperature**: The `CalculateAverageTemperature` method calculates the average temperature from the filtered observations.

The program then prints the average temperature for the previous 72 hours.

In case of any exceptions during the execution, the program catches them and prints an error message.

To use this code, you need to call the `Main` method. It's an asynchronous method, so you need to use the `await` keyword when calling it.

## Weather Observation

This program fetches weather data from a JSON API and can filter for specific data on it. The `WeatherController` is a part of the API that handles requests related to weather data. It has two main endpoints:

1. `HttpGet` without parameters: This endpoint is used to fetch all weather data. When a request is made, it creates an HTTP client and sends a GET request to a specific URL. If the request is successful, it reads the content of the response as a string and returns it. If the request fails, it returns an error status code and a message indicating that an error occurred while fetching the weather data.

2. `HttpGet("{wmo}/{dataType}")`: This endpoint is used to fetch specific weather observation data. It takes two parameters: `wmo` and `dataType`. `wmo` is used to construct the URL for the GET request. If the request is successful, it reads the content of the response as a string, extracts the specific data type from the JSON string using the `ObservationUtils.ExtractSpecificValue` method, and returns it. If the request fails, it returns a BadRequest status with a message indicating that it failed to retrieve the specific data type.

For filtering the properties of the observations I opted for using Reflection in this context provides several benefits:

- Flexibility: Reflection allows the code to dynamically access properties of the Observation class at runtime. This means that the code can handle any property of the Observation class, even if the property was not known at compile time.

- Maintainability: With reflection, when new properties are added to the Observation class, the ExtractSpecificValue method does not need to be updated. It will automatically be able to handle the new properties.

- Simplicity: The use of reflection simplifies the code by eliminating the need for a large switch statement or dictionary to map property names to their values. Instead, the property names are used directly to access their values.

Using reflections allowed me to simply search for each property in both forms, as defined on the json response and also on the class model created to deserialize the object.

However, it's important to note that reflection can be slower than direct property access and should be used judiciously. In this case, the benefits of flexibility, maintainability, and simplicity outweigh the potential performance cost.
