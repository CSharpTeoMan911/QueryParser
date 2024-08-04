# QueryParser

**QueryParser** it is a .NET package that allows users to convert objects into HTTP query parameters to be used within an HTTP request. It is using the **Newtonsoft.json** package.

## Example usage
![QueryParser Example](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/QueryParser%20Example.png)

## Example usage result
![QueryParser Result](https://raw.githubusercontent.com/CSharpTeoMan911/QueryParser/master/assets/images/QueryParser%20Result.png)

## Usage

```cs 
// string query_parameters = await QueryParser.QueryParsing.QueryParser<TypeOfTheObjectToBeParsed>(object_to_be_parsed);

string query_parameters = await QueryParser.QueryParsing.QueryParser<AuthenticationModel>(authentication);
```
