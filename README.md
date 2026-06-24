# Role-Based Authentication & Authorization API

An enterprise-ready **ASP.NET Core Web API** showcasing a complete implementation of **JWT (JSON Web Token) Authentication** combined with robust **Role-Based Access Control (RBAC)**. Built using **.NET 10**, **ASP.NET Core Identity**, and **Entity Framework Core (EF Core) with SQL Server**.

## 📖 Project Overview

This repository provides a clean, decoupled authentication and authorization microservice template. It handles everything from user registration and secure password hashing to role generation, role mapping, JWT token issuance, and resource authorization.

### Key Architecture Components
- **ASP.NET Core Identity**: Manages user stores, credentials, claims, security stamps, and password hashing automatically.
- **Entity Framework Core**: Interacts with the backend SQL Server database using migration-driven schema definitions.
- **JWT Bearer Authentication**: Secures APIs statelessy by verifying cryptographically signed tokens containing user identities and roles.
- **Policy-based RBAC**: Restricts execution of sensitive controllers to authorized roles (e.g., `Admin`, `User`) using middleware validation.
 
## ⚙️ Core Functionalities

### 1. User Account & Identity Management
- **Registration**: Accepts a username, email, and password. ASP.NET Core Identity validates password strength (min 6 characters, configured dynamically) and hashes the passwords before saving them to the database.
- **Secure Authentication**: Validates user credentials. Upon success, retrieves the user's assigned roles and generates a cryptographically signed JSON Web Token (JWT).

### 2. Dynamic Role-Based Access Control (RBAC)
- **Role Creation**: Allows administrators to register custom application roles (e.g., `Admin`, `User`) dynamically.
- **Role Assignment**: Maps users to roles. A user can have multiple roles, which are packed into the token claims list as `ClaimTypes.Role`.

### 3. Policy-Based Route Protection
The API defines distinct security barriers using policies configured in `Program.cs`:
- **`AdminPolicy`**: Demands that the bearer token possesses the `Admin` role.
- **`UserPolicy`**: Demands that the bearer token possesses the `User` role.

 
## 📁 Database Schema Details

When EF Core applies the initial migrations, the following system tables are created in SQL Server:
- `AspNetUsers`: Stores core credentials, emails, and password hashes.
- `AspNetRoles`: Houses application roles.
- `AspNetUserRoles`: Join table linking users to their respective roles (Many-to-Many).
- `AspNetRoleClaims`, `AspNetUserClaims`, `AspNetUserLogins`, `AspNetUserTokens`: Support tables for advanced claim and login management.
