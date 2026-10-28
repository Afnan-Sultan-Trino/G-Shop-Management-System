# G-Shop Management System

A desktop-based application designed to streamline gadget shop operations by centralizing product inventory, category organization, user management, and sales recording. 

This project was developed as a requirement for the **CSC2210: Object Oriented Programming 2** course at **American International University-Bangladesh (AIUB)**.

## 🛠️ Tech Stack
- **Frontend/GUI:** C# (.NET Framework, Windows Forms)
- **Backend/Database:** Microsoft SQL Server (Database: `ProductDB`)

## ✨ Key Features
- **Authentication & Role-Based Access:** Secure login using email and password. Users only see actions permitted for their roles.
- **Product Inventory Management:** Admins can add, update, and delete products (including category, quantity, and price).
- **Category Management:** Maintain structured product categories with names and descriptions.
- **Sales Recording (Invoice-Based):** Salesmen can record transactions with invoice numbers, product details, quantity, unit price, and total amount.
- **Dashboard & Reporting:** Visual summary of total users, total products, sales overview charts, and today's sales snapshot.
- **Search & Filtering:** Quick search for products by name and view low-stock items for early restocking.
- **Data Integrity:** Strict validation rules for quantities, prices, and foreign key references between categories and products.

## 👥 User Roles
1. **Admin:** 
   - Manage master data (Categories, Products, Users).
   - Monitor shop performance via the dashboard.
   - Maintain inventory quality and track low-stock items.
2. **Salesman:** 
   - Record sales using invoice details.
   - Search for products quickly during billing.
   - Manage their own profile and change passwords.

## 🗄️ Database Overview
The system uses a **Microsoft SQL Server** database named `ProductDB`. The ER diagram and SQL scripts are included in the project files.
- **`UserInfoDB`**: Stores user details (Admin/Salesman), emails, passwords, and roles.
- **`CategoriesInfoDB`**: Stores category names and descriptions.
- **`ProductInfoDB`**: Stores product details linked to categories via Foreign Keys.
- **`SalesInfoDB`**: Stores invoice data, salesmen info, and transaction amounts.

## 👨‍💻 Team Members
- Abdur Rob Rafi (23-5549-33)
- Yasir Arafat (23-55352-3)
- Afnan Sultan Trino (23-55524-3)

## 🚀 How to Run the Project
1. Clone this repository to your local machine.
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Set up the database:
   - Open **SQL Server Management Studio (SSMS)**.
   - Run the provided SQL script to create the `ProductDB` database and tables.
4. Update the connection string in the C# project to match your local SQL Server instance.
5. Build and run the application (`F5`).
