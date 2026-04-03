# OBE Manager
## CS104 - Database Systems | Mid Term Project | Spring 2026

### Student Details
| Field | Details |
|-------|---------|
| Name | M. Abdullah Akbar |
| Registration | 2025-CS-212 |
| Course | CS104 - Database Systems |
| Repository | MidDb26_2025CS212 |

---

### Project Description
A Windows Forms desktop application built in C# for 
managing Outcome Based Education (OBE) evaluations 
at Department of Computer Science, UET Lahore.

The system allows teachers to manage students, CLOs, 
rubrics, assessments and automatically calculate 
student marks using rubric levels.

---

### Features Implemented
#### Required Features
- Student Management (Add, Edit, Delete, Search)
- CLO Management
- Rubric Management  
- Rubric Level Management
- Assessment and Component Management
- Student Evaluations with Auto Mark Calculation
- CLO Wise PDF Report
- Assessment Wise PDF Report

#### Bonus Features
- Secure Login System
- Dashboard with Live Statistics
- Attendance Management
- Student Individual PDF Report
- UET Logo Integration
- Home Navigation Button

---

### Mark Calculation Formula
ObtainedMarks = (ObtainedRubricLevel / MaxRubricLevel)
× ComponentMarks

### Technology Stack
| Technology | Purpose |
|-----------|---------|
| C# .NET Framework | Programming Language |
| Windows Forms | Desktop UI |
| MySQL 8.0 | Database |
| MySql.Data | ADO.NET Connector |
| iTextSharp | PDF Generation |
| GitLab | Version Control |

---

### Database Setup
1. Install MySQL Server
2. Open MySQL Workbench
3. Run `ProjectBMySql.sql` script
4. Update connection string in `Helpers/DBHelper.cs`

### How to Run
1. Open `MidDb26_2025CS212.sln` in Visual Studio
2. Right click project → Manage NuGet Packages
3. Restore packages (MySql.Data, iTextSharp)
4. Press F5 to run

### Login Credentials
- **Username:** admin
- **Password:** admin123

---

### Project Structure

MidDb26_2025CS212/
├── DAL/          ← Database Access Layer
├── Forms/        ← All Windows Forms
├── Helpers/      ← DBHelper connection
├── Models/       ← C# model classes
└── Reports/      ← PDF report generation

---

### GitLab Repository
`gitlab.com/Abudora-0/MidDb26_2025CS212`

*CS104 Database Systems — Spring 2026 — UET Lahore*