# WEATHERMEN 

## Your friendly easy to use weather update website

This is an interactive website built using HTML, CSS, jQuery and Bootstrap to solve the following purposes: 

1) To give the current factual weather updates for a city of the users choice.
2) To provide weather statistics throughout the current day for a city of the users choice.
3) To predict the perfect holiday destination based on the users choice of Continent and weather types

The website has the following three tabs - 

## __*What's the Weather Like*__

* The first tab *(also the home page of the website)* provides information about the current weather details depending on the user's preference of City. 
* The API used for this can be found in the following link - [Click here for weather API](http://api.openweathermap.org/data/2.5/weather?q=Cincinnati,US&appid=ad9b2e59d88c9ce936545b2a3dcc99ad)
* Feel free to test the API with any city and country combination name by changing the 'q' parameter in the URL
* The output of the user request looks like [this](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/1_FrontScreen.JPG)
* If there is an erroneous input, there is a corresponding error message displayed to the user like [this](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/5_ErrorPage1.JPG)
* Kindly ensure that you provide only two letters for the Country field - US, UK, IN (for India) are some examples 

## _*Weather Forecast*_

* The second tab navigates the user to an interesting page where the user can derive all weather statistics for the entire day for the city of his preference
* The API used for this can be found [here](http://api.apixu.com/v1/forecast.json?q=London&key=7fdefa92b022483bb14214611172911)
* The output of the user request looks like [this](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/3_WeatherForecast.JPG)
* If there is an erroneous input, there is a corresponding error message displayed to the user like [this](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/4_ErrorPage2.JPG)

## _*Holiday Destination*_

* The third tab was created to consume a self designed API. It fetches data locally from a Database in my system through ADO.NET and C#
* Thus, the third tab might not produce effective results for any GitHub'er who might fork this. I will be updating this with a patch soon
* Having said that, this is how the output screen functions.
* Click [here](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/6_HD1.jpg) to see the variety of drop down options for the user's choice of weather preferences
* Click [here](https://github.com/Nitin2392/Weather-Forecast-Website/blob/master/Weather_Men/6_HD2.JPG) to see the final result based on the users choice of Continent and Weather preference
