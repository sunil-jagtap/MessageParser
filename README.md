# MessageParser
# Angular & .NET Bin File Upload Application

This project is a full-stack application consisting of an Angular 20+ Single Page Application (SPA) frontend and a .NET backend API. The Angular app allows users to upload `.bin` files, which are sent to the backend for parsing. The parsed messages are then displayed in a user-friendly table.

---

## Table of Contents

- [Project Overview](#project-overview)  
- [Technologies Used](#technologies-used)  
- [Frontend: Angular Application](#frontend-angular-application)  
- [Backend: .NET API](#backend-net-api)  
- [Getting Started](#getting-started)  
- [Running the Application](#running-the-application)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Project Overview

This application demonstrates:

- Uploading `.bin` files from an Angular SPA.
- Sending files to a .NET backend API.
- Parsing file contents on the backend.
- Displaying parsed messages with sequence numbers in a styled table.
- Modern Angular 20+ standalone component architecture.
- CORS configuration enabling seamless frontend-backend communication.

---

## Technologies Used

### Frontend: Angular

- Angular CLI 20+
- Standalone Components & Services
- HttpClientModule for API communication
- Responsive and styled UI with flexible layouts

### Backend: .NET API

- .NET 7+
- RESTful API endpoints
- CORS enabled for Angular frontend (`http://localhost:4200`)

---

## Frontend: Angular Application

- The root component (`app.ts`) imports `HttpClientModule` and the file upload component.
- File upload component handles file selection, type validation, and API submission.
- Responses from the backend are displayed in a stylish table showing sequence numbers and messages.
- Provides real-time upload status and error feedback.

---

## Backend: .NET API

- Exposes an endpoint at `/BinParser/upload` accepting file uploads.
- Parses `.bin` file messages into structured sequence-numbered objects.
- Sends results back as JSON.
- Configured to allow CORS from Angular dev server for local development.

---

## Getting Started

### Prerequisites

- Node.js 20+ and npm 10+
- Angular CLI 20+
- .NET 7 SDK or newer

### Setup Instructions

1. **Clone the repository**
- git clone <repository-url>
- cd angular-bin-upload-app


2. **Install Angular frontend dependencies**
- npm install


3. **Configure your .NET backend**

- Navigate to your backend project folder.
- Ensure CORS enabled for `http://localhost:4200` (see Backend section).

---

## Running the Application

### Run Backend API
-dotnet run --project path-to-backend-project


- Backend will listen on `http://localhost:5077` (default).

### Run Angular Frontend
- ng serve


- Open browser at [`http://localhost:4200`](http://localhost:4200)
- Use the UI to upload `.bin` files and see parsed messages displayed.

---

## Contributing

Contributions, bug reports, and feature requests are welcome!  
Please fork the repo and create a pull request or open an issue.

---

## Contact

For questions or support, contact [Sunil Jagtap] at [[sunil-jagtap](https://www.linkedin.com/in/sunil-jagtap/)].


