# .NETPlay
My journey into .NET development—notes, code snippets, and projects as I learn C#, ASP.NET and more! 


# 📌 Getting Started with .NET  


##  What is .NET?  
**.NET** is an open-source, cross-platform framework for building modern applications. It supports:  
✅ **Web Development** (ASP.NET Core, Blazor)  
✅ **Desktop Apps** (WinForms, WPF)  
✅ **Cloud & Microservices**  
✅ **Game Development** (Unity)  
✅ **Machine Learning** (ML.NET)  

### 🔗 Official Documentation:  
- [Microsoft .NET Docs](https://learn.microsoft.com/en-us/dotnet/)  
- [C# Language Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)  
- [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)  

---
## 📌 Installation Guide  
### 🔹 **1. Install .NET SDK**  
Download and install **.NET SDK** from the official site:  
🔗 [Download .NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)  

Verify installation:
```
dotnet --version
```
If installed correctly, it will show the installed version, like:
```
8.0.100
```



## 📌 Setting Up a .NET Project
### 🔹 **1.  Create a New Console Application**

Navigate to your preferred folder and run:
```
dotnet new console -n AppName
cd AppName
dotnet run
```
✅ This creates a simple C# Console App and runs it.

---

### 🔹 **2. ASP.NET Core - Web Development**  
ASP.NET Core is a **cross-platform framework** for building web applications.  
 

#### 📌 Creating an ASP.NET Core App:
```sh
dotnet new webapp -n MyWebApp
cd MyWebApp
dotnet run
```

#### 📌 Example Minimal API:
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, ASP.NET Core!");
app.Run();
```

---

## 📌 Learning Resources  
📌 [Microsoft .NET Docs](https://learn.microsoft.com/en-us/dotnet/)  
📌 [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)  

## 🚀 Contributing  
This repository is for **learning purposes**, but feel free to fork, explore, and experiment!  

💡 **Have suggestions or improvements? Feel free to contribute!**  


**Happy Coding!** 🎉  