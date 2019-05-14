How to test any APIs

1. Grab the base uri string, such as "https://samples.openweathermap.org", and put it in the constructor of Uri method in Helper/Helper.cs file. Give an appropriate name to the containing class, in this case it is WeatherAPI.

2. In HomeController.cs, put the rest of the API query parameters in client.GetAsync method. Also change the API class name at the beginning.

3. Create a class model that you want to represent the API data (it can be a subsection of the whole response from the API). 

For example, using the openweathermap sample API link: 
https://samples.openweathermap.org/data/2.5/forecast?id=524901&appid=b1b15e88fa797225412429c1c50c122a1

After you enter the above link in the browser, you will get a response in a form of a complex JSON string in your browser. But let say you only want to know a subsection of the response, such as the city object, you'll create an object class model in your application to receive and display the data. Because the city object has another object within it, which is coord, you'll have to create another class model represents the object.

4. Create a reference to the class you want to model at the start of Index method, assign null to it.

5. Parse the result string into JSon Object, and use it to query and descend to the section of the json string that you want. 

6. After you get to where you want, convert the object back to string with jsonObject.ToString(Formatting.None) method to be used in JsonConvert.DeserializeObject<TargetedObject>() method, and assign it to your object reference.
    
7. Finally use the object as argument of the View() method. Then right click, choose Add View, let the view name stay as "Index", choose a template (Either Details (for one object) or List (for collection of objects)). The choose the model class as the class you passed into the view, and add.

8. Run the application with Ctrl-F5 to see the API data for the object being displayed in Index page.