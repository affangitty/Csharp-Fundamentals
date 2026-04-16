# C# Learning Repository

## Overview
This repository contains a structured set of tasks covering core C# concepts, ranging from basic syntax to advanced topics such as asynchronous programming, generics, reflection, and building RESTful APIs using ASP.NET Core.

The goal is to develop a strong foundation in C# and understand how it is used in real-world backend and application development.

---

## Objectives

- Learn C# fundamentals and object-oriented programming
- Understand collections, LINQ, and data manipulation
- Work with file systems and handle exceptions
- Build event-driven and asynchronous applications
- Apply design patterns such as Repository Pattern
- Explore advanced topics like reflection and attributes
- Develop a production-ready REST API using ASP.NET Core

---

## Topics Covered

### 1. Basics and Control Structures
- Data types (`int`, `long`, `string`)
- Input/output using `Console`
- Conditional statements and loops
- Methods and recursion

### 2. Object-Oriented Programming (OOP)
- Classes and objects
- Properties (`get`, `set`)
- Methods
- Constructors
- Encapsulation basics

### 3. Collections and String Manipulation
- `List<T>` and dynamic collections
- Looping through collections
- String methods (`Trim`, `ToUpper`, etc.)
- Menu-driven console applications

### 4. LINQ (Language Integrated Query)
- Filtering (`Where`)
- Sorting (`OrderBy`, `OrderByDescending`)
- Lambda expressions
- Querying object collections

### 5. File I/O and Exception Handling
- Reading and writing files (`File`, `StreamReader`)
- Exception handling (`try-catch`)
- Handling file-related errors

### 6. Delegates and Events
- Delegates as method references
- Events for communication between components
- Event-driven programming
- Decoupling logic

### 7. Asynchronous Programming
- `async` and `await`
- `Task` and concurrency
- `Task.WhenAll`
- Exception handling in async workflows

### 8. Generics and Repository Pattern
- Generic types (`<T>`)
- Interfaces and abstraction
- CRUD operations
- Repository pattern for data access
- Type constraints

### 9. Reflection and Custom Attributes
- Runtime type inspection
- Custom attributes
- Dynamic method execution
- Metadata-driven programming

### 10. ASP.NET Core Web API
- RESTful API design
- Controllers and routing
- Dependency Injection
- Entity Framework Core (In-memory DB)
- Middleware and exception handling
- Swagger documentation

---

## Repository Structure

Each task is organized as:

csharp/task-x/

Each task includes:

- Source code files (`.cs`)
- `README.md` describing the task
- Clear separation of concerns (models, services, etc. where applicable)

---

## Key Concepts

### Strong Typing
C# is a strongly typed language that enforces type safety at compile time.

### Object-Oriented Design
Encapsulation, abstraction, and modular design are core principles used throughout the tasks.

### Asynchronous Programming
Modern C# applications rely heavily on async programming for scalability and performance.

### Layered Architecture
In advanced tasks, code is structured into layers:
- Controllers
- Services
- Data access

---

## Best Practices

- Use meaningful variable and method names
- Keep methods small and focused
- Handle exceptions properly
- Avoid code duplication
- Use async/await for I/O operations
- Follow separation of concerns
- Write clean and readable code

---

## Common Pitfalls

- Not validating user input
- Blocking async code with `.Result` or `.Wait()`
- Using exceptions for control flow
- Ignoring null checks
- Overusing reflection

---

## Real-World Relevance

The concepts covered in this repository are directly applicable to:

- Backend development (ASP.NET Core)
- API development
- Enterprise applications
- Microservices architecture

---

## Tools Used

- .NET SDK
- Visual Studio Code / Visual Studio
- C# (latest version)
- ASP.NET Core
- Entity Framework Core