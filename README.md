# Auct

This repository contains the source code for the **Auct** ASP.NET Core MVC web application using SQLite.

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download) (or later) on your machine.
- **SQLite** (no separate install needed; the provider is bundled with EF Core) citeturn1search2.
- EF Core CLI tools (for migrations):
  ```bash
  dotnet tool install --global dotnet-ef
  ```
  Verify installation with:
  ```bash
  dotnet ef --version
  ```
  citeturn1search8

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-org>/auct.git
   cd auct
   ```

2. **Configure the database connection**
   - Open `appsettings.json` and ensure you have the following section:
     ```jsonc
     "ConnectionStrings": {
       "DefaultConnection": "Data Source=MyDatabase.db"
     }
     ```

3. **Set up the database**
   - Create the initial migration:
     ```bash
     dotnet ef migrations add InitialCreate
     ```
     This scaffolds a migration to create the `Tasks` table in SQLite citeturn1search6.
   - Apply the migration to create (or update) the SQLite file:
     ```bash
     dotnet ef database update
     ```
     After running this, a `MyDatabase.db` file will appear in the project root.

4. **Run the application**
   ```bash
   dotnet run
   ```
   The app will be available at `https://localhost:5001` by default.

## Project Structure

- **Controllers/** – MVC controllers (e.g., `HomeController`).
- **Models/** – Data models (e.g., `TaskItem`).
- **Data/** – EF Core `DbContext` (`MyAppDbContext`).
- **Views/** – Razor views for UI templates.
- **wwwroot/** – Static assets (CSS, JS, images).

## Contributing

1. Fork the repository.
2. Create a feature branch: `git checkout -b feature/YourFeature`.
3. Commit your changes: `git commit -m "Add some feature"`.
4. Push to your branch: `git push origin feature/YourFeature`.
5. Open a Pull Request.

## License

This project is licensed under the MIT License.

---

*This README follows best practices for repository documentation, covering users, developers, and contributors.* citeturn0search9

