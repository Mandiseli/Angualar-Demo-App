# Full Stack Angular + ASP.NET Core Demo App

This is a full-stack demo application built with **Angular (standalone)** for the frontend and **ASP.NET Core Web API** for the backend. It features:

- JWT-based user authentication
- Secure login and logout
- Protected data endpoint
- DevExtreme Data Grid
- Modern responsive UI with Bootstrap 5

---

## Project Structure

FullStack-Demo-App/
│
├── client/ # Angular 17 standalone frontend
│ ├── src/
│ │ ├── app/
│ │ │ ├── login/
│ │ │ ├── dashboard/
│ │ │ ├── auth/
│ │ │ ├── app.component.ts
│ │ │ ├── app.routes.ts
│ │ │ └── ...
│ └── angular.json
│
├── server/ # ASP.NET Core 7+ backend
│ ├── Controllers/
│ ├── Models/
│ ├── Program.cs
│ ├── appsettings.json
│ └── ...
└── README.md


---

## Features

### Angular Frontend
- Standalone components
- JWT token storage in `localStorage`
- Protected dashboard route
- DevExtreme Data Grid (sortable, filterable, exportable)
- Bootstrap 5 styling

### .NET Core Backend
- AuthController for login
- DataController for protected data
- In-memory user list
- JWT settings in `appsettings.json`
- CORS enabled for all origins

---

## Setup Instructions

### Backend (ASP.NET Core)

1. Open `server/` folder in Visual Studio 2022
2. Ensure `appsettings.json` contains your JWT settings:
   ```json
   "JwtSettings": {
     "Key": "YourSuperSecureKey1234567890",
     "Issuer": "DemoAppIssuer",
     "Audience": "DemoAppAudience"
   }
Run the project:


https://localhost:7028/api/Auth/login
https://localhost:7028/api/Data
Default user credentials:
Email: admin@test.com
Password: Admin@123

🌐 Frontend (Angular)
Open client/ folder in VS Code

Install dependencies:

npm install
Run the app:

ng serve
Visit:
http://localhost:4200
Auth Workflow
User logs in via /login

Token stored in localStorage

Authenticated requests send Authorization: Bearer <token> header

Protected routes (like /dashboard) require valid token

📦 Technologies Used
Tech Stack	Tool / Library
Frontend	Angular 17 (standalone)
Styling	Bootstrap 5, SCSS
UI Components	DevExtreme Angular Grid
Backend	ASP.NET Core Web API
Auth	JWT Authentication
HTTP	HttpClient (Angular), CORS

📃 License
This project is for educational/demo purposes. Feel free to fork and modify.

Acknowledgements
Angular

ASP.NET Core

DevExtreme

Bootstrap

