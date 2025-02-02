# Datbase Systems (Sistemi baza podataka)
**Grade: 300/300**

This repository contains a three-stage project developed for a university course on Database Systems. The project demonstrates key database concepts, including EER modeling, trigger implementation, ORM configuration, and API development.
## First Stage
In the first stage, we designed an **Enhanced Entity-Relationship (EER)** diagram, defining entities, relationships, and attributes. We applied advanced EER concepts such as **unions**, **categories**, and **complex hierarchical structures**. After completing the EER diagram, we created the corresponding SQL tables and populated them with sample data to simulate real-world scenarios and validate the design.
## Second Stage
The second stage focused on database automation and the establishment of **Object-Relational Mapping (ORM)**. We implemented auto-indexing **triggers** that automatically create indexes during operations like `INSERT`, significantly improving query performance without manual intervention. Additionally, we configured Fluent NHibernate to map database tables directly to our domain models, reducing the need for extensive SQL queries. To demonstrate the functionality of our mappings, we developed a C# WinForms application that supports CRUD operations and dynamically displays data from the database.
## Third stage
In the final stage, we transitioned from a desktop-based solution to a web-based environment by developing a **RESTful Web API**. This API replicated the functionalities previously handled by the WinForms application, enabling seamless web-based interactions.
## Tech Stack

⚙️ **Framework:** .NET 8 (C#)

🛢 **Database:** Oracle SQL

🔗 **ORM:** Fluent NHibernate

🖥️ **UI Framework:** WinForms

🌐 **API Documentation:** Swagger


## Installation

### Prerequisites:
- **.NET**: [Download .NET](https://dotnet.microsoft.com/en-us/download)
- **Oracle SQL Developer**: [Download SQL Developer](https://www.oracle.com/database/sqldeveloper/)


### Steps to run the projects:

1. Clone the repository: 
```bash
git clone https://github.com/aleksa1205/database-systems
cd database-systems
```
2. Run the WinForms Application (Second stage):
```bash
cd FashionWeek-DomaciII
dotnet restore
dotnet run
```

3. Run the Web API (Third stage):
```bash
cd FashionWeek-DomaciIII
dotnet restore
dotnet run
```
## Authors
👤  [Aleksa Perić](https://github.com/aleksa1205)

👤  [Jovan Cvetković](https://github.com/CJovan02)

