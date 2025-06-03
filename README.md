# Placeholder


Okay, here's a `README.md` file content designed as a small tutorial for you. This will guide you through adapting the provided C# Windows Forms template to any new entity for your exam.

---

### `README.md`

# Generic CRUD Application Template

This project provides a versatile C# Windows Forms application template designed for managing (Create, Read, Update, Delete - CRUD) any type of entity. It uses a SQL Server database for data storage.

This template is especially useful for quickly setting up an application to manage `Cars`, `Cats`, `Persons`, or any other custom entity by simply modifying a few key parts of the code.

## Prerequisites

Before you begin, ensure you have the following installed:

* **Visual Studio** (2019 or newer, with `.NET Desktop Development` workload)
* **SQL Server Express** (or any SQL Server edition)
* **SQL Server Management Studio (SSMS)** (or Azure Data Studio) - for running SQL scripts.

## How to Adapt This Template: A Step-by-Step Tutorial

The core idea is to use Visual Studio's powerful "Replace in Files" feature to quickly change all occurrences of the generic placeholders to your desired entity names and properties.

---

### **Step 1: Understand the Placeholders**

I've used the following generic placeholders in the code. You will replace these with your specific entity's details:

* `{EntityName}`: The singular name of your new entity (e.g., `Car`, `Cat`, `Person`).
* `{EntityNamePlural}`: The plural name of your new entity (e.g., `Cars`, `Cats`, `Persons`).
* `{Property1Name}`: The name of your first data property (e.g., `Model`, `Name`).
* `{Property1Type}`: The C# data type for `{Property1Name}` (e.g., `string`, `int`, `float`).
* `{Property2Name}`: The name of your second data property (e.g., `Weight`, `Age`).
* `{Property2Type}`: The C# data type for `{Property2Name}`.
* `{Property3Name}`: The name of your third data property (e.g., `Speed`, `Color`).
* `{Property3Type}`: The C# data type for `{Property3Name}`.
* `YourProjectName`: Your actual Visual Studio project's root namespace (e.g., `LashaShraieri.Final`).

---

### **Step 2: Perform Global Find and Replace in Visual Studio**

This is the most crucial step.

1.  **Open Your Solution:** Open the entire project solution in Visual Studio.
2.  **Open "Replace in Files":** Go to **Edit** > **Find and Replace** > **Replace in Files** (or press **Ctrl + Shift + H**).
3.  **Configure Replacement:**
    * **Find what:** Enter the placeholder (e.g., `{EntityName}`).
    * **Replace with:** Enter your desired new text (e.g., `Car`).
    * **Look in:** Select **"Entire Solution"**. This ensures changes are applied everywhere.
    * **Find Options:**
        * ✅ **Match case:** This is important. `{EntityName}` is different from `{entityName}`. You'll do separate replacements for each.
        * ✅ **Match whole word:** This prevents accidental partial replacements (e.g., changing `My{EntityName}Id` to `MyCarId` when you meant `MyCarId`).
4.  **Execute Replacements (in Order):**
    * **Start with the longest/most unique placeholders first.**
    * **Perform replacements for each of the following (and their `ToLower()` variants if they exist in the code) and click "Replace All" for each pair:**

    | **Find what** | **Replace with (Example: "Car" entity)** | Notes                                                             |
    | :--------------------------- | :--------------------------------------------- | :---------------------------------------------------------------- |
    | `{EntityNamePlural}`         | `Cars` (e.g., for `CarsListBox`)               | Always do plural first, then singular.                            |
    | `{EntityNamePlural.ToLower()}` | `cars` (e.g., for `carsLbl`, `List<Car> cars`) | If template used `.ToLower()` for variable names.                 |
    | `{EntityName}`               | `Car` (e.g., for `AddCarButton`, `class Car`)  |                                                                   |
    | `{EntityName.ToLower()}`     | `car` (e.g., for `new Car(car)`)               | If template used `.ToLower()` for variable names.                 |
    | `{Property1Name}`            | `Model` (or `Name`, `Title`)                   | Replace for all `Property1Name` instances.                        |
    | `{Property1Type}`            | `string` (or `NVARCHAR(255)` for SQL)          | Replace for all `Property1Type` instances (C# type, SQL type).    |
    | `{Property2Name}`            | `Weight` (or `Age`, `Size`)                    | Replace for all `Property2Name` instances.                        |
    | `{Property2Type}`            | `float` (or `INT`, `DECIMAL(18,2)` for SQL)    | Replace for all `Property2Type` instances (C# type, SQL type).    |
    | `{Property3Name}`            | `Speed` (or `Color`, `Status`)                 | Replace for all `Property3Name` instances.                        |
    | `{Property3Type}`            | `int` (or `string`, `NVARCHAR(50)` for SQL)    | Replace for all `Property3Type` instances (C# type, SQL type).    |
    | `YourProjectName`            | `LashaShraieri` (or your actual project name)  | Your root namespace. This typically affects `using` directives.   |

    * **For each replacement:** Click **"Find All"** first to review the changes. Then click **"Replace All"** once you're confident.

---

### **Step 3: Modify the SQL Script (`{EntityNamePlural}Database.sql`)**

The template includes a SQL script. After performing the replacements in Step 2, this file will also have your new entity names.

1.  **Open the SQL Script:** Locate and open the `{EntityNamePlural}Database.sql` file in your project.
2.  **Review and Adjust Data Types:** Double-check that the SQL data types (`NVARCHAR(255)`, `FLOAT`, `INT`, etc.) for your `{PropertyXName}` columns are appropriate for the data you intend to store.
3.  **Run in SSMS:**
    * Open **SQL Server Management Studio (SSMS)**.
    * Connect to your SQL Server instance (e.g., `SHRAI\SQLEXPRESS`).
    * Open the modified `{EntityNamePlural}Database.sql` file in SSMS.
    * **Execute** the script. This will create your new database and table.

---

### **Step 4: Build and Run Your Application**

1.  **Build Solution:** In Visual Studio, go to **Build** > **Rebuild Solution**.
    * **Crucial:** Check the "Output" window (usually at the bottom) for any errors. If there are errors, they will prevent the application from running. Fix them before proceeding. Common errors are often typos or incorrect type conversions.
2.  **Start Debugging:** Click the green "Start" button (or press **F5**).

Your application should now launch, allowing you to add, edit, and delete your new entities (e.g., Cars, Cats, Persons) using the adapted interface and database.

---

### **Common Troubleshooting Tips:**

* **"Invalid Column Name" (SQL Error):** This almost always means there's a mismatch between the column names in your C# `SqlHelper.cs` queries and the actual column names in your SQL table. Double-check your SQL script and `SqlHelper.cs`.
* **"Cannot Convert Type..." (C# Error):** You might have used the wrong `Convert.To...` method in `SqlHelper.cs` when reading from the database, or in your `[EntityName]Dialog.cs` when parsing text from the text boxes. Ensure `float.TryParse` for floats, `int.TryParse` for integers, etc.
* **"Debug Profile Does Not Exist":** This is a Visual Studio configuration issue. Try `Build > Clean Solution`, then `Build > Rebuild Solution`. If it persists, close Visual Studio, delete the hidden `.vs` folder in your project's root directory, and reopen.
* **"Object Reference Not Set to an Instance of an Object":** Often means a UI control (like a TextBox) isn't initialized, or you're trying to access a property on a `null` object. Check your `InitializeComponent()` and ensure objects are properly instantiated and assigned.

By following these steps, you'll be well-prepared to quickly adjust this template for your exam!
