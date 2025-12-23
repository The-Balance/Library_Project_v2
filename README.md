## 🛠 Database Setup (SQL Server)

Since the database is hosted locally, you need to create it on your machine after cloning the project.

### 1. Check Connection String
Ensure you have **SQL Server Express** installed. Check the `appsettings.json` file:
* **For SQL Express:** `"Server=.\\SQLEXPRESS;..."`

### 2. Apply Migrations
Open the project in Visual Studio and run the following command in the **Package Manager Console** (PMC) to create the database and tables:

```powershell
Update-Database

✅ What Works?
View Books: Navigate to /Book in your browser. You will see the list of books from the database.

Add Book: The "Add New Book" button works. You can successfully add new books to the our booklist.