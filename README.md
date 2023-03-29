# MediaLibrarian
Media Librarian is a media aggregator for Movies, Music, Books, Video Games and TV Shows. Add and Edit your favorites, give them a rating or delete them all together. This Web App was built in C# using the MVC design pattern, Entity Framework to handle the entities with a SQL database all with Bootstrap for the front end.  

![image](https://user-images.githubusercontent.com/97712526/228086550-68d9c6fd-1ad9-4026-b530-5bc548cd96ea.png)
![image](https://user-images.githubusercontent.com/97712526/228086615-4dce04ef-4c1e-4bee-8b8b-63695ccea236.png)
![image](https://user-images.githubusercontent.com/97712526/228086662-ee85a6c4-7a93-4c27-8d62-9e1cc54ecde6.png)


<h3> SET UP </H3>

Step One: In "appsettings.json", add your connection string: 

```C#
{
  "ConnectionStrings": {
    "DefaultConnection": "ADD SQL CONNECTION STRING HERE"
  },


  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```


Step Two: Use the Package Manager Console to Update-Database:
![image](https://user-images.githubusercontent.com/97712526/228086085-3773d3fc-3890-46c1-a375-0280dd6f43fe.png)

Step Three (Optional): There is Seed Data ready to be added to your SQL Db. If you would like to add this data,  pen Powershell and enter: 
![image](https://user-images.githubusercontent.com/97712526/228086339-b5e2a8cc-bf4a-47e2-ae46-b6c21e54f8f4.png)


<h3>The following Code Kentucky requirements were met:</h3>

1. Make your application a CRUD API
2. Make your application asynchronous
3. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program. (found in the Seed class under the Data folder)
