# React-Redux : Profile Manager Application

This application demonstrate the use of Redux in React application. This application consumes REST services from .NET Core Web API application. 

### Run Backend REST service
To run the application you need to run the `ProfileApi` application. For that open the project in Visual Studio and press `F5` or click `Debug > Run without Debugging`. You can also run the application using dotnet core CLI command. To run using command run the following commands:
```
cd ProfileApp\ProfileApi
dotnet restore
dotnet build
dotnet run
```

### Run React client application
To run the React SPA application, you need to run the following commands.
```
cd profile-spa
npm install
npm start
```

