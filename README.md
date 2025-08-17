CSharpCarProgram 🚘

A simple C# and XAML GUI application that displays cars available on a lot.
Built as part of my NM TAFE coursework, this project demonstrates the fundamentals of object-oriented programming in C# combined with a WPF (Windows Presentation Foundation) interface.

Features ✨

GUI built with XAML

Displays a list of cars on a lot

Car class to represent individual vehicles

CarListings to manage and display multiple cars

Clear separation of UI (MainWindow.xaml) and business logic (MainWindow.xaml.cs)

Tech Stack 🛠️

C#

XAML (WPF)

.NET Framework / .NET Desktop Runtime

Getting Started ⚙️
Prerequisites

Visual Studio with the .NET Desktop Development workload

.NET Framework (4.7.2 or higher recommended)

Running the App

Clone the repository:

git clone https://github.com/geezmulticoloredbob/CSharpCarProgram.git
cd CSharpCarProgram/CWAssess2Car


Open the solution file CWAssess2Car.sln in Visual Studio

Build and run the project (F5)

Project Structure 📂
CWAssess2Car/
│
├── Car.cs                # Defines the Car class
├── CarListings.cs        # Handles collections of cars
├── MainWindow.xaml       # GUI layout in XAML
├── MainWindow.xaml.cs    # Code-behind for UI logic
├── App.config            # Application configuration
├── CWAssess2Car.csproj   # Project file
└── CWAssess2Car.sln      # Solution file

Future Enhancements 🚀

Add ability to add/remove cars via the GUI

Store car data in a JSON file or database

Implement search and filtering for cars

Add images for each car in the listings

License 📜

This project is licensed under the MIT License.

Created with the assistance of North Metropolitian TAFE, Perth WA
