# Supplier Portal Server (API)

A lean .NET 9 **Minimal API** that manages suppliers for the Supplier Portal mini-project in the  
*EnverSoft Software Developer Assessment*.

---

## ✨ Endpoints

| Route | Verb | Query / Route params | Purpose |
|-------|------|----------------------|---------|
| `/suppliers` | **POST** | — | Add a supplier.<br>Returns **409** if `CompanyName` already exists. |
| `/suppliers` | **GET** | `companyName` (required) | Get a supplier’s phone number by company name. |
| `/suppliers/multiple` | **GET** | `ids` — comma-separated list (e.g. `1,4,7`) | Get an array of suppliers by IDs. |
| `/suppliers/{id}` | **GET** | `{id:int}` | Get a single supplier by ID. |
| `/suppliers/dropdown` | **GET** | `page` (default 1), `pageSize` (default 10) | Paginated list for dropdowns. |

> **Data model** Only **one table**, `Suppliers`, is used.

---

## 🛠️ Prerequisites

* .NET 9 SDK  
* SQL Server (Developer / Express) running locally  
* Optional – EF Core CLI  
  ```bash
  dotnet tool update -g dotnet-ef


### Server

- **Repository:** [Supplier Portal Server](https://github.com/Nkosinathi-dev1/supplier-portal-server)  
- **Framework:** .NET 9 Web API (Minimal API)  
- **Database:** MS SQL Server

---

### 🛠️ Setup Instructions (Server)

1. **Navigate** to the `supplier-portal-server` project folder.  
2. Choose **one** of the two options below:

| Option | Creates DB | Creates table | Seeds data | Command |
|--------|------------|---------------|------------|---------|
| **A – EF Core** | ✅ | ✅ (via migrations) | ❌ | `dotnet ef database update` |
| **B – SQL scripts** | ✅ | ✅ | ✅ | See **Option B** panel |

<details>
<summary>Option B — run SQL scripts manually</summary>

#### 📄 Script files

| Purpose | File |
|---------|------|
| Create DB & table | [`create_supplier_db.sql`](supplier-portal-server/scripts/create_supplier_db.sql) |
| Seed sample rows  | [`seed_suppliers.sql`](supplier-portal-server/scripts/seed_suppliers.sql) |
| One-shot (create + seed) | [`create_supplier_db_and_seed_suppliers.sql`](supplier-portal-server/scripts/create_supplier_db_and_seed_suppliers.sql) |
