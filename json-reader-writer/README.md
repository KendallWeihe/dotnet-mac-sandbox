

```
dotnet new console -n json-reader-writer
dotnet add json-reader-writer.csproj package Newtonsoft.Json
dotnet run test.json
```

- [x] created sample json file
- [x] read file via command line arg
- [x] `using System.IO`
- [x] read as `JObject` 
	- [x] `using Newtonsoft.Json.Linq`
- [x] created class definition 
- [x] deserialized into class instance
- [x] serialize back as string, & write to output file
