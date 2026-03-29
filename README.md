# OBE Manager - MidDb26_2025CS212

## CS104 Database Systems - Mid Project - Spring 2026

### Student Information
- **Name:** Abdullah Akbar
- **Registration:** 2025-CS-212
- **Course:** CS104 - Database Systems

### Project Description
A Windows Forms desktop application for managing 
Outcome Based Education (OBE) evaluations at 
Department of Computer Science, UET Lahore.

### Features
- Student Management (CRUD)
- CLO Management
- Rubric & Rubric Level Management
- Assessment & Component Management
- Student Evaluations with Auto Mark Calculation
- Attendance Tracking
- PDF Reports (CLO Wise, Assessment Wise, Student)
- Professional Dashboard with Live Stats
- Secure Login System

### Technology Stack
- Language: C# (.NET Framework)
- UI: Windows Forms
- Database: MySQL
- PDF: iTextSharp
- Version Control: GitLab

### Database Setup
1. Install MySQL Server
2. Import `ProjectBMySql.sql`
3. Update connection string in `Helpers/DBHelper.cs`

### Login Credentials
- Username: admin
- Password: admin123

### How to Run
1. Open `MidDb26_2025CS212.sln` in Visual Studio
2. Restore NuGet packages
3. Build and Run (F5)