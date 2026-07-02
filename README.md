# 🚗 DVLD - Driving & Vehicle License Department System

> A desktop application that simulates the workflow of a Driving & Vehicle License Department (DVLD).  
> Built using **C#**, **Windows Forms**, **ADO.NET**, and **SQL Server** following a **3-Layer Architecture** to ensure maintainability, scalability, and separation of concerns.

---

## 📌 Overview

DVLD is a management system designed to automate the processes involved in issuing and managing driving licenses.

The application allows employees to manage citizens, driving license applications, tests, issued licenses, international licenses, and related administrative operations through an intuitive Windows Forms interface.

This project was developed primarily as an educational project to practice enterprise application development using Microsoft's .NET ecosystem.

---

# ✨ Features

### 👤 People Management
- Add new people
- Update person information
- Delete records
- Search by ID or National Number
- View person details

### 📄 Local Driving License Applications
- Create new applications
- Edit applications
- Cancel applications
- Schedule required tests
- Track application status

### 📝 Test Management
- Vision Test
- Written Test
- Street Test
- Schedule appointments
- Record test results

### 🪪 License Management
- Issue first-time licenses
- Renew expired licenses
- Replace lost licenses
- Replace damaged licenses
- Release detained licenses
- Detain licenses

### 🌍 International Licenses
- Issue international driving licenses
- View issued international licenses

### 🔍 Search & Filtering
- Search licenses
- Search people
- Search applications
- Filter records

---

# 🏛 Architecture

The project follows the classic **3-Layer Architecture**.

```
Presentation Layer
        │
        ▼
Business Layer
        │
        ▼
Data Access Layer
        │
        ▼
SQL Server Database
```

### Presentation Layer
Responsible for:

- User Interface
- User interaction
- Input validation
- Displaying data

### Business Layer

Responsible for:

- Business rules
- Validation
- Business logic
- Communication between UI and Data Access

### Data Access Layer

Responsible for:

- SQL queries
- CRUD operations
- Database connectivity
- Data retrieval

This architecture keeps the project modular, maintainable, and easy to extend. :contentReference[oaicite:1]{index=1}

---

# 🛠 Technologies

- C#
- .NET Framework
- Windows Forms
- SQL Server
- ADO.NET
- Layered Architecture
- Object-Oriented Programming (OOP)

---

# 📂 Project Structure

```
DVLD/
│
├── DVLD_Presentation
│   ├── Forms
│   ├── Controls
│   ├── Resources
│   └── Utilities
│
├── DVLD_BusinessLayer
│   ├── Business Classes
│   └── Validation
│
├── DVLD_DataAccess
│   ├── Data Access Classes
│   ├── Database Utilities
│   └── SQL Operations
│
└── Database
```

---

# 🎯 Learning Objectives

This project demonstrates practical experience with:

- Layered Architecture
- Object-Oriented Programming
- SOLID-oriented design practices
- ADO.NET
- SQL Server
- CRUD Operations
- Windows Forms
- Exception Handling
- Data Validation
- Enterprise Application Development

---
# 🙏 Acknowledgments

The **Presentation Layer (UI)** was originally designed and developed by **Wesam Aslan**.

GitHub Profile:
- https://github.com/ZinWesamAslan

This repository focuses on implementing the application's architecture, business logic, and data access while utilizing the original UI as the presentation layer.
