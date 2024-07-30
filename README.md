# ASP.NET Core MVC Singleton/Transient


The web application written in .NET7 MVC presents methods of operating on data stored in classes, which are injected into controllers using Dependency Injection. Data from the classes is then sent to the views. 

## Application structure

The web application receives requests from the browser and prepares data for views. Uses classes defined in Models. These classes are initialized in one of three modes:

- Transient: creates a new instance of the service, every time you request it.
- Scoped: creates a new instance for every scope. (Each request is a Scope). Within the scope, it reuses the existing service.
- Singleton: Creates a new Service only once during the application lifetime, and uses it everywhere

In this ASP.NET7 application, two class modes are defined in the Program.cs file in the lines:
```
builder.Services.AddSingleton<IStuffServiceSingle, StuffServiceSingle>();
builder.Services.AddTransient<IStuffService, StuffService>();
```
After these definitions, the internal mechanisms of ASP.NET add interfaces to their containers and then implicitly pass them to the constructor for injection.

In the ThingsController.cs interface these classes are injected in the constructor:
```
public ThingsController(IStuffService stuffService, IStuffServiceSingle stuffServiceSingle)
```
The controller then uses these interfaces to pass data to the views. 

## Singleton 

In this application, StuffServiceSingle is of the Singleton type and supports the actions: Single_0 (only reads fields), Single_1, Single_2 (sets fields). The example shows two browsers: Chrome via Single_1 sets the data. Firefox via Single_0 reads data from the instance set by Chrome and sees the class state set by Chrome because a class created in Singleton mode has only one instance in the web application. 

![](/Jpg/Singleton_2.png)

## Transient 

In this application, StuffService is of type Transient and supports the actions: Stuff0 (only reads fields), Stuff1, Stuff 2 (sets fields). In Transient mode, each request initializes its own class, so browsers only see their class instances.

![](/Jpg/Transient_2.png)

## Details

- Environment: VS2022
- Target: .NET7
- Output type: Web Application
- ASP.NET Core MVC
