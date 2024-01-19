# Tropic-Sun

This is the initial project directory for the tropic-sun project. Tropic Sun Yacht Rentals (A.K.A., Tropic Sun) is a yacht rental company with a fleet
of 40 yachts in 4 locations. It provides discrete, exclusive services to high-end customers. It rents fully-
staffed yachts to customers seeking private holidays in throughout the Gulf of Mexico and the
Caribbean. We use this as the usecase for our ISC-567 Project.

## Technologies & Tools

1. ASP.net MVC Framework for creating the Serverside rendering web application
2. AZURE SQL Database for Storing data
3. .Net 7.0 Framework
4. Microsoft Entity Framework Core 7.0.15
5. Microsoft SQL Data Client 5.2.0
6. Visual Studio 2022
7. Mac M1 with Sonoma 14.0.2

## Directory Structure

- Tropic-Sun-Initial-Test-Project
    - Dependacies -> Dependancy packages
    - Controllers -> Controllers
    - Data  -> All Data Objects Layer for DTODS: closer to the data base
    - DTO  -> All the Data transfer objects 
    - Models  -> All the Models
    - Services -> All the service classes which connect Controllers and Services
    - Properties -> App property files
    - Views  -> Views
        - Auth
        - Home
        - Shared
        - _ViewImports.cshtml
        - _ViewStart.cshtml
    - wwwroot
    - Program.cs
 
## Important Configurations

1. Add `appsettings.json` file to the root folder and edit as below as

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "AZURE_SQL_CONNECTIONSTRING": "Server=tcp:isc-567-database.database.windows.net,1433;Initial Catalog=tropic-sun;Persist Security Info=False;
        User ID=<user_id>;Password=<password>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  }
}

```


  
