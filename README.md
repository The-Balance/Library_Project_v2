# Library Database Setup

This repository contains the structure and data of the **library** database. Your colleagues can create the same database on their local SQL Server by following the steps below.

## Requirements
- SQL Server (Express or full version)
- SQL Server Management Studio (SSMS)

## Setup Steps

1. Download or copy the `script.sql` file from this repository.
2. Open SSMS and connect to your server.
3. Open a **New Query** window.
4. Paste the entire code from `script.sql` into the query window **or** open it via `File → Open → script.sql`.
5. Click **Execute**.
6. After execution, the `library` database along with all tables, relationships, stored procedures, and data will be created.

## Important Notes

- If the database already exists, you may need to delete the old one first.
- **Local Copy Only:** Once the script is executed, the database is created **only on your local machine**. It is **not automatically connected to the original database** on someone else’s computer.  
- Every person will have their own independent copy of the database.
- **Why local?** Using Azure or other cloud solutions can incur costs. Therefore, it is more practical for everyone to run the database **locally** on their own machine.
