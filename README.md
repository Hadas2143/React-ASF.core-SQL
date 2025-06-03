# Games project
🎮 Game Store Web Application
A full-stack web platform enabling users to browse, purchase, and manage digital games, while providing administrators with robust content management tools. The system supports user authentication and role-based functionality for customers and admins alike.

🧠 Project Overview
The application allows customers to explore a game catalog, view details, add items to a shopping cart, and complete purchases. Admins have access to dedicated dashboards for managing categories and game listings. Purchases are fully tracked and stored per user, with access to personal order history.

The backend is built using ASP.NET Core Web API with a layered architecture (DAL, BLL, DTO), connected to a relational SQL database. The frontend is developed in React  for state management, providing a responsive and interactive UI.

🗄️ Backend Architecture & Database
A structured SQL database supports core entities:

Categories

Games

Customers

Purchases

Purchase Details

Business logic and data access are separated into dedicated class libraries, exposing functionality through Web API controllers.

💡 Frontend with React 
The React-based frontend offers distinct interfaces for customers and admins.

🛠️ Technologies Used
Backend: ASP.NET Core Web API, SQL Server, Entity Framework
Frontend: React, Redux, Bootstrap
Tools: Visual Studio, Postman, GitHub, VS Code
