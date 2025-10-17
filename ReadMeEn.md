# University Management System — Final Project (.NET 8 WinForms)

A desktop application for managing **students, teachers, courses, and exams**, built with **Windows Forms** on **.NET 8**.  
All data is stored in simple **JSON files** (see the `Progetto/Universita` folder).

## ✨ Main Features

- **Students** — Create, update, delete, and view records  
- **Teachers** — Create, update, delete, and view records  
- **Courses** — Register and assign courses, edit details, and browse archives  
- **Exams** — Manage exam sessions and related data  
- **Archive** — View historical data  
- **Storage** — Persistent local data stored in JSON files

_Main forms detected:_ `Main Menu`, `Registration`, `Course Registration`, `Edit Students`, `Edit Teachers`, `Edit Course`, `Course Details`, `Exam Management`, `Archive`.

## 🧱 Tech Stack

- **.NET 8 SDK**
- **Windows Forms**
- **C# 12**
- **System.Text.Json** for file serialization

## 🖥️ Requirements

- **Windows 10 or 11**
- **Visual Studio 2022** (17.8+ recommended) with the **.NET Desktop Development** workload  
  _or_ **.NET SDK 8** to build from the CLI
- Read/write permission for the `Universita/` folder

## 🚀 Quick Start

### Option A — Visual Studio
1. Clone or download this repository.  
2. Open the solution file:  
   `Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale.sln`
3. Set **ProgettoFinale** as the startup project (if not already set).
4. Press **F5** to run the app.

### Option B — .NET CLI
```bash
# Navigate to the WinForms project folder
cd "Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale"

# Restore dependencies and build
dotnet restore
dotnet build -c Release

# Run
dotnet run
```

> Make sure the folder `Universita/` is at the same level as `Progetto Finale/` so the app can locate the JSON data files.

## 📂 Repository Structure

```
Progetto/
  Progetto Finale/
    ProgettoFinale/
      ProgettoFinale.sln
      ProgettoFinale/
        ProgettoFinale.csproj
        Program.cs
        Main Menu.cs
        Exam Management.cs
        Registration.cs
        Course Registration.cs
        Edit Students.cs
        Edit Teachers.cs
        Edit Course.cs
        Course Details.cs
        Archive.cs
        *.Designer.cs
        *.resx
  Universita/
    Students.json
    Teachers.json
    Courses.json
    Exams.json
```

## 📁 Data (JSON Files)

The JSON data files are located in `Progetto/Universita/`:
- `Students.json`
- `Teachers.json`
- `Courses.json`
- `Exams.json`

You can manually edit them (UTF‑8), but always back them up before making changes.

## 🔧 Configuration Notes

- Target framework: `net8.0-windows`
- `UseWindowsForms=true` in `ProgettoFinale.csproj`
- If you move folders, make sure relative paths in the code still match.
- If Visual Studio shows designer errors, close and reopen the solution and verify .NET 8 SDK is installed.

## 🧪 Production Build

```bash
cd "Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale"
dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true -o ./publish
```

The executable will be inside the `publish/` folder.  
Distribute it together with the `Universita/` JSON data folder.

## 🗺️ Future Improvements
- Input validation (email, phone, duplicates)
- Search and filters for student/teacher/course lists
- Automatic JSON backup and restore
- Export reports (CSV/PDF)
- Error logging
- Optional migration to SQLite or another lightweight DB

## 🐞 Known Issues
- The app won’t start if the `Universita/` folder is missing or inaccessible.
- Renaming `.Designer.cs` or `.resx` files may break the form layout.

## 🤝 Contributing
1. Fork the repo  
2. Create a new branch: `git checkout -b feature/your-feature`  
3. Commit changes: `git commit -m "Add feature XYZ"`  
4. Push the branch: `git push origin feature/your-feature`  
5. Open a Pull Request

## 📜 License
Add a `LICENSE` file (MIT recommended) if you plan to make this project open source.

---

If you’d like, I can also:
- Add **screenshots** of the UI
- Include **a release-ready build**
- Provide a **short summary section** for GitHub’s project description

🎓 Built with C# and WinForms — simple, educational, and fully functional!
