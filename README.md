# 🎂 Cake Ordering System

A desktop-based Cake Ordering System developed using **VB.NET** and **MySQL**.
This application helps manage cake orders, billing, and admin operations for a bakery in a simple and efficient way.

---

## 📌 Features

### 👨‍💼 Admin Panel

* Secure admin login
* First-time password setup
* Add, update, and delete cakes
* Manage cake availability
* View sales reports

---

### 🛒 Ordering Module

* Dynamic cake catalog display
* Search cakes by name or category
* Add multiple cakes to cart
* View cart with total amount
* Remove items from cart
* Auto-generated order number and date

---

### 💳 Payment Module

* Cash and Online payment options
* QR code display for online payment
* Enter customer name and cake message
* Generate bill after payment

---

### 🧾 Billing & Reports

* Printable receipt generation
* Order summary display
* Sales data stored for reporting

---

## 🛠️ Technologies Used

* **Frontend:** VB.NET (Windows Forms)
* **Backend:** MySQL
* **IDE:** Visual Studio
* **Reporting Tool:** Crystal Reports (optional)

---

## 🗄️ Database Setup

1. Open MySQL
2. Create a database:

   ```
   CakeShopDB
   ```
3. Import the file:

   ```
   Database/CakeShopDB.sql
   ```

---

## ⚙️ How to Run the Project

1. Open the `.sln` file in Visual Studio
2. Update the MySQL connection string in the code:

   ```
   server=localhost;userid=your_username;password=your_password;database=CakeShopDB;
   ```
3. Run the project

---

## 📁 Project Structure

```
CakeOrderingSystem/
 ├── cake2/              # Main project files
 ├── Database/           # SQL file
 ├── cake2.sln           # Solution file
 ├── .gitignore          # Ignore unnecessary files
 └── README.md           # Project documentation
```

---

## 🔒 Note

* Database credentials are not included for security
* Use your own MySQL username and password
* Sample/dummy data is used in the database

---

## 🚀 Future Improvements

* User login system
* Online payment integration
* Order tracking
* Mobile version of the app

---
