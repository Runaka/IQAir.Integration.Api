# IQAir.Integration.Api
Fast and secure access from your computer or server to [global air monitoring pollution service](https://www.iqair.com/).
Only a few lines of code are needed to begin getting data from a different places arround the word. 

I wrote this library for monitoring air pollution in Telegram bots:
1) For [India](t.me/pollution_india_bot) (Delhi, Mumbai, Kolkata, etc.)
2) For [Uzbekistan](t.me/havo_index_bot) (Tashkent, Samarkand, Bukhara, etc.)

## 🚀 Quick Start with the Console Sample
How start sample console project.
1) Register on [iqair.com](https://www.iqair.com/us/support/knowledge-base/KA-04891-US) to create your account.
2) Obtain an API Access Token by following [these instruction](https://www.iqair.com/newsroom/how-can-i-access-air-pollution-data-through-airvisual-s-air-quality-api).
3) Configure the API Key in your ``appsettings.json`` file:
```
"IQAirV2Options": {
    "ApiKey": "set you api key!",
```
4) Set your location (Country, State and City) in the ``appsettings.json``
```
"MeasurementCityOptions": {
      "Country": "India",
      "State": "Delhi",
      "City": "Delhi"
    },
```
5) Run the console application to see the live air quality data.

![Console work screen](./docs/console-sample.jpg)

## 📦 Installation
1) Install the package via NuGet:
```
dotnet add package IQAir.Integration.Api
```
2) Configure an API Key in your appsettings.json file:
```
"IQAirV2Options": {
    "ApiKey": "set you api key!",
```
3) Register the service in your ``Program.cs`` file:
```
// Add the IQAir integration to your service collection
builder.Services.AddIQAirOpenApiIntegration(config);
```

## ✨ Features
- 🚀 Fast & Lightweight: Optimized for high-performance console applications and high-traffic Telegram bots.

- 💉 Dependency Injection Ready: Seamlessly integrates with .NET Host and IServiceCollection using the AddIQAirOpenApiIntegration extension.

- 🏗️ Strongly Typed Models: No more manual JSON parsing. Provides clean C# classes for Cities, States, and Air Quality Indexes (AQI).

- ⚡ Fully Asynchronous: Built from the ground up using async/await to ensure non-blocking I/O operations.

- 🌍 Global Coverage: Access real-time air quality and weather data for thousands of cities in India, Uzbekistan, and across the globe.

- 🛡️ Secure Configuration: Uses the modern IOptions pattern for safe API key management via appsettings.json or Environment Variables.
