# QueryParser

**QueryParser** it is a .NET package that allows users to convert objects into HTTP query parameters to be used within an HTTP request. It is using the **Newtonsoft.json** package.

## Example usage
![QueryParser Example](https://github.com/user-attachments/assets/b822acc9-edf4-4637-9db3-9e48e8d30766)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FCSharpTeoMan911%2FQueryParser.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2FCSharpTeoMan911%2FQueryParser?ref=badge_shield)

## Example usage result
![QueryParser Result](https://github.com/user-attachments/assets/4dbe81fd-f1e1-4333-85d6-ca501801c5dc)

## Usage

```cs 
// string query_parameters = await QueryParser.QueryParsing.QueryParser<TypeOfTheObjectToBeParsed>(object_to_be_parsed);

string query_parameters = await QueryParser.QueryParsing.QueryParser<AuthenticationModel>(authentication);
```


## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FCSharpTeoMan911%2FQueryParser.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2FCSharpTeoMan911%2FQueryParser?ref=badge_large)