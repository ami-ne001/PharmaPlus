# PharmaPlus 💊

PharmaPlus is a robust, professional Pharmacy Management System designed to streamline daily operations in a pharmacy. Built using **C# Windows Forms** and **.NET 8.0**, it provides a comprehensive suite of tools for inventory tracking, client management, and order processing.

## 🚀 Features

### 🔐 Security & Access
*   **User Authentication**: Secure login system for pharmacists and staff members.
*   **Role Management**: Distinct interfaces for different user roles (e.g., Pharmacist Menu).

### 📦 Inventory & Stock Management
*   **Medication Database**: Complete management of medications, including categories and details.
*   **Lot/Batch Tracking**: Manage specific batches with separate expiry dates and quantities.
*   **Stock Alerts**: Real-time notifications for low stock levels.
*   **Expiry Alerts**: Automated tracking of medications nearing their expiration date.

### 👥 Client & Supplier Management
*   **Patient Profiles**: Store and manage client information for better service.
*   **Supplier Directory**: Maintain records of medication suppliers and their product catalogs.
*   **Supplier-Medication Mapping**: Track which suppliers provide specific medications.

### 🛒 Sales & Orders
*   **Order Processing**: Efficiently create and manage new customer orders.
*   **Order History**: Detailed logs of all previous transactions and orders.
*   **Sub-totals & Breakdown**: Detailed views for each order's items.

### 📊 System Utilities
*   **Activity History**: Comprehensive logging of system events for auditing.
*   **SQL Server Integration**: Reliable data persistence using Microsoft SQL Server.

## 🛠️ Tech Stack

*   **Framework**: .NET 8.0 (Windows Forms)
*   **Language**: C#
*   **Database**: Microsoft SQL Server
*   **Driver**: `Microsoft.Data.SqlClient`

## 🏁 Getting Started

### Prerequisites
*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
*   [SQL Server](https://www.microsoft.com/sql-server/)
*   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (with .NET desktop development workload)

### Database Setup
1.  Create a SQL Server database named `PharmaPlus` (or `PharmaPlusNew`).
2.  Update the connection string in the `appsettings.json` file located in the root directory to match your local SQL Server instance:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "data source=YOUR_SERVER_NAME; initial catalog=PharmaPlus; integrated security=true; trustServerCertificate=true;"
      }
    }
    ```

### Installation
1.  Clone the repository:
    ```bash
    git clone https://github.com/ami-ne001/PharmaPlus.git
    ```
2.  Navigate to the project directory containing the `.sln` file:
    ```bash
    cd PharmaPlus
    ```
3.  Restore dependencies:
    ```bash
    dotnet restore
    ```
4.  Navigate into the main application project folder and run it:
    ```bash
    cd PharmaPlus
    dotnet run
    ```

## 📂 Project Structure

*   `Models/`: Core business entities and models (e.g., `Medicament.cs`, `Client.cs`, `Commande.cs`).
*   `Forms/`: UI components and view logic for different application modules.
*   `Data/`: Centralized database connection management (`Connection.cs`).
*   `Program.cs`: Application entry point.
