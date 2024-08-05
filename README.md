# QueryParser

**QueryParser** it is a **.NET** package that allows users to convert objects into **HTTP** query parameters to be used within an **HTTP** request. This package is designed to be used with **ASP.Net** controllers and enable **C#** classes to be sent to **API controllers** as **query parameters**. By passing objects using the **Query section** of an **HTTP payload**, the quantity of information to be sent using the other **HTTP sections** is minimised, thus allowing the app to transmit data with more flexibility. This package is using the **Newtonsoft.json** package.
```cs
// [FromQuery] => The controller extracts the required payload from the url query parameters
// [FromBody] => The controller extracts the required payload from the HTTP payload Body section
// [FromHeader] => The controller extracts the required payload from the HTTP payload Header section

public async Task<string?> Get([FromQuery] AuthenticationModel? value)
{
  // Controller content
}
``` 

## Example usage
### Client
![QueryParser Example](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/QueryParser%20Example.png)
### Controller
![GetAPI Example](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/Get%20API.png)


## Example usage result
### Generated URL
![QueryParser Result](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/QueryParser%20Result.png)
### Controller received payload
![Controller Result](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/Controller%20Result.png)


## Usage

```cs 
// string query_parameters = await QueryParser.QueryParsing.QueryParser<TypeOfTheObjectToBeParsed>(object_to_be_parsed);

string query_parameters = await QueryParser.QueryParsing.QueryParser<AuthenticationModel>(authentication);
```

## Download

### .NET CLI 
``` ps
dotnet add package QueryParser --version 1.0.4
```

### Package Manager Console
``` ps
NuGet\Install-Package QueryParser -Version 1.0.4
```

## Links
NuGet: https://www.nuget.org/packages/QueryParser
\
GitHub: https://github.com/CSharpTeoMan911/QueryParser
