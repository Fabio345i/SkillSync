# SkillSync — Fullstack Training & Skill Management Platform

SkillSync is a full-stack enterprise-style application for managing employees, trainings, and AI-powered skill evaluations.  
It includes a .NET 10 backend, an Angular 18 dashboard, a Blazor WebAssembly admin module, PostgreSQL, S3/Ceph file storage, and a TorchSharp AI model.

---

## Features

### Employees
- CRUD (create, update, delete, view)
- Upload CVs/reports (PDF)
- Automatic skill scoring (TorchSharp)
- View skill history

### Trainings
- Create trainings
- Assign to employees
- Track completion
- Dashboard analytics

### Dashboards
- Angular dashboard (main UI)
- Blazor WebAssembly admin module

### Storage
- File uploads stored in S3 or Ceph (Rados Gateway)

### AI
- TorchSharp neural model
- PDF text extraction
- Skill scoring 0–100

---

## Tech Stack

### Backend
- .NET 10 (ASP.NET Core Web API)
- C#
- Entity Framework Core
- PostgreSQL
- TorchSharp
- Amazon S3 / Ceph RadosGW

### Frontend
- Angular 18 (main dashboard)
- Blazor WebAssembly (admin module)
- TypeScript, HTML, SCSS

### DevOps & Tools
- Docker / Docker Compose
- Git & GitHub Actions
- VS Code / Visual Studio

---
