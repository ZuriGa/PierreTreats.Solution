# Pierre's Sweet and Savory Treats

#### Pierre's Treats is an MVC application with user authentication and comprehensive CRUD (Create, Read, Update, Delete) functionality,a versatile many-to-many relationship system. Pierre's Treats provides users with a dynamic platform to explore, create, and manage culinary creations.

#### By Zuri Gallegos 👩🏾‍💻

## Technologies Used

* C#
* HTML
* CSS
* Bootstrap
* .NET
* VScode
* MySQL Workbench
* Entity Framework Core 6.0
* Pomelo.EntityFrameworkCore.MySql


## Key Features

### User Authentication
* Users can register, log in, and log out securely.
* Only logged-in users have access to create, update, and delete functionality.
* All users, whether logged in or not, can browse and view treats and flavors.
### Many-to-Many Relationship
* Treats and flavors are interconnected through a many-to-many relationship.
* Each treat can be associated with multiple flavors, and vice versa.
* For example, a "sweet" flavor might encompass treats like chocolate croissants, cheesecake, and more.


## Setup/Installation Requirements ⚙️ 🖥️

* Make sure you have MySQL Server and MySQL Workbench installed on your system. The following steps assume you have the required installations. 

#### Setting up Entity Framework Core:
* Install the dotnet-ef tool globally by opening your terminal and executing: 
    
    $ dotnet tool install --global dotnet-ef --version 6.0.0

* Optionally, verify that EF Core CLI tools are correctly installed by running:
    
    $ dotnet ef

#### Install and Run the Project: 
* Copy the URL of this repository: `https://github.com/ZuriGa/Factory.Solution.git`
* Open your Terminal
* Navigate to the directory where you want to clone the project.
* Run this command in your terminal: <br /> 

      $ git clone https://github.com/ZuriGa/Factory.Solution.git

* Navigate to the projects directory name Factory <br />

* Create your `appsettings.json` file within the projects production directory to protect the sensitive data within our database connection string by adding it to our `.gitignore`

* Add your appsettings.json with the following contents, replacing the following values with your own:

      [YOUR-USER-HERE] with your username
      [YOUR-PASSWORD-HERE] with your password
      [YOUR-DB-NAME] with the name of your database


      ProjectName.Solution/ProjectName/appsettings.json
        {
          "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
      }

* With appsettings.json properly configured, run the following command in your terminal to reference the project's migrations and re-create the application's database:

      $ dotnet ef database update
      
* In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
* Optionally, you can compile the web app without running it by executing:

      $ dotnet build

* Open your web browser and navigate to https://localhost:5001 to use the web application.<br />
Note: If you're unable to access https://localhost:5001, you may need to configure a .NET developer security certificate for HTTPS.



## Known Bugs

* _No known bugs, if any found please contact the author._


## License

MIT License

Copyright (c) 2024 Zuri Gallegos
