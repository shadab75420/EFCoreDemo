# EF Core Code First Demo – Student Management System

## Project Overview

This project demonstrates the implementation of Entity Framework Core using the Code First Approach in ASP.NET Core MVC.

The application connects with SQL Server using Entity Framework Core and automatically creates the database and tables using migrations.

The project helps understand:

- Entity Framework Core
- Code First Approach
- SQL Server Connectivity
- DbContext Configuration
- Migrations
- CRUD-ready Architecture
- ASP.NET Core MVC Integration

---

# Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#
- .NET 10
- Visual Studio 2022

---

# Features

- SQL Server Database Connectivity
- Code First Development
- Automatic Database Creation
- Entity Tracking
- Migration Support
- MVC Architecture
- DbContext Configuration
- Student Entity Management

---

# Project Structure
'''
EFCoreDemo
│
├── Controllers
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   └── Student.cs
│
├── Migrations
│
├── Views
│
├── wwwroot
│
├── appsettings.json
│
├── Program.cs
│
└── EFCoreDemo.csproj
'''
---

# Entity Framework Core Workflow

Model Class
↓
DbContext
↓
Migration
↓
Database Creation
↓
CRUD Operations

---

# NuGet Packages Used

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Relational

---

# Database Configuration

Connection String:

Server=.\\SQLEXPRESS;
Database=CollegeDB;
Trusted_Connection=True;
TrustServerCertificate=True;
Encrypt=False

---

# Model Used

## Student Entity

Properties:

- Id
- Name
- Age

---

# Steps Performed

1. Created ASP.NET Core MVC Project
2. Installed EF Core Packages
3. Created Student Model
4. Created AppDbContext
5. Configured SQL Server Connection
6. Registered DbContext in Program.cs
7. Created Migration
8. Updated Database
9. Generated SQL Server Database Automatically

---

# EF Core Commands Used

## Create Migration

dotnet ef migrations add InitialCreate

## Update Database

dotnet ef database update

## Run Project

dotnet run

---

# Database Output

Database Name:

CollegeDB

Table Name:

Students

---

# Advantages of Code First Approach

- Faster Development
- Easy Database Management
- Automatic Table Creation
- Easy Schema Updates
- Developer Friendly
- Migration Support

---

# Learning Outcomes

After completing this project, the following concepts were understood:

- Entity Framework Core Basics
- ORM Concept
- Code First Development
- SQL Server Integration
- Migration Handling
- ASP.NET Core MVC Structure
- Database Connectivity
- EF Core Tooling

---

# Conclusion

This project successfully demonstrates how to integrate Entity Framework Core with ASP.NET Core MVC using the Code First approach. The application automatically creates and manages the SQL Server database through migrations, making development faster and easier.
