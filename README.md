# Eau Claire's Salon

#### _by John Diggins_

### Technologies Used

- C#
- Dotnet 6
- EF Core
- MySQL

### Description

This site is a fully functioning site to allow a user to input a number of _Stylists_ for a hair salon.  Each _Stylist_ then can have a number of their own _Clients_.  _Clients_ can only have one _Stylist_,  but _Stylists_ can have a number of their own _Clients_.  The values can be stored in a local database for accessing later through MySQL / MySQL Workbench.  

### Setup/ Installation Requirements

1. Clone this repo.
2. Open your terminal and navigate to this project's production directory called "HairSalon.Solution". 
3. Finish all steps below _Setting up MySQL_.
4. Create an appsettings.json file and make sure it is in the HairSalon directory.
5. Make sure appsettings.json contains this: <br>
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=john-diggins;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
6. Go to the HairSalon directory.
7. Enter $ `dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`
8. Enter $ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`
9. Enter $ `dotnet watch run`
10. Navigate to localhost:5001 in your browser.

#### Setting up MySQL

1. Open MySQL Workbench (install if not installed here https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
2. Make sure you have a connection open at localhost:3306, click on it.
3. Click on the `Administration` tab at top left.
4. Click on `Data Import Restore`.
5. Click `Import From Self-Contained File`.
6. Enter the location of where you cloned HairSalon.Solution, in that directory select John_Diggins.sql.

### Known Bugs

None have been detected at this point, that doesn't mean their aren't any!

##### License 
MIT