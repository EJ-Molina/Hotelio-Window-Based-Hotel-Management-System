# 🏨 Hotelio - Hotel Management System

This is one of my created project to course Information Management 2, this a Windows-based Hotel Management System built with **C# Windows Forms** and **MySQL** database. This application provides a complete solution for managing hotel operations including room bookings, guest management, housekeeping, and customer feedback, mainly created to improve and showcase my understanding to creating CRUD applications.

---

## 📋 Features

- **User Authentication** – Secure login system with role-based access control (Admin/Tenant)
- **Dashboard** – Overview of room availability, pending bookings, and quick statistics
- **Room Management** – Visual room status display with color-coded availability (Available, Occupied, Dirty)
- **Booking System** – Handle room reservations with check-in and check-out functionality
- **Guest Management** – Track guest information, contact details, and booking history
- **Housekeeping** – Schedule and manage room cleaning tasks with staff assignments
- **Feedback System** – Collect and manage guest reviews and ratings
- **Transaction History** – View completed bookings and past guest records

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|---------|
| C# (.NET Framework) | Backend & UI Logic |
| Windows Forms | Desktop UI |
| MySQL | Database |
| FontAwesome.Sharp | Icons |

---

## 📁 Project Structure

```
HotelManagement-Information-Management-2/
├── LoginForm.cs          # User authentication
├── Container.cs          # Main navigation container
├── Dashboard.cs          # Statistics overview
├── Rooms.cs              # Room management & booking
├── Guest.cs              # Guest check-in/check-out
├── Housekeeping.cs       # Cleaning task management
├── Schedules.cs          # Booking history
├── FeedbackManagerForm.cs # Guest reviews management
├── CreateAccount.cs      # User registration
└── ReviewSubmissionForm.cs # Guest feedback submission
```

---

## ⚙️ Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2+
- MySQL Server (XAMPP or standalone)
- MySQL Connector/NET

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/Hotelio.git
   ```

2. **Set up the database**
   - Start MySQL server
   - Create a database named `im_etr`
   - Import the database schema

3. **Configure the connection string**
   - Update the connection string in the source files:
   ```csharp
   string conString = "server=localhost;username=root;password=;database=im_etr";
   ```

4. **Open the solution**
   - Open `HotelManagement-Information-Management-2.sln` in Visual Studio

5. **Build and Run**
   - Press `F5` or click **Start** to run the application

---


## 👥 User Roles

| Role | Access |
|------|--------|
| **Admin** | Full access to all features including user management |
| **Tenant** | Limited access – can view rooms and submit feedback |

---

## 📝 License

This project is for educational purposes.

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

---

**Made with ❤️ using C# and Windows Forms**