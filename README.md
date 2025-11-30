RecipeSuggestion - Recipe Recommendation Application

A C# Windows Forms application where users can add, edit, delete, and search recipes.

Features

✨ Recipe Management: Add, edit, and delete recipes

🔍 Search & Filtering: Easily search through all recipes

📋 Ingredient Management: Manage ingredients associated with each recipe

📊 Recipe Details: View detailed information for every recipe

Project Structure

RecipeSuggestion/
├── DataAcsess/
│ └── DataBase.cs – Handles all database operations
├── Models/
│ ├── Tarif.cs – Recipe model
│ ├── Malzeme.cs – Ingredient model
│ └── Tarif_Malzeme.cs – Recipe-Ingredient relation model
├── Forms/
│ ├── Form1.cs – Main form
│ ├── TarifEkle.cs – Add recipe form
│ ├── TarifGuncelle.cs – Update recipe form
│ ├── TarifSil.cs – Delete recipe form
│ ├── AramaFiltreleme.cs – Search & filter form
│ └── Detay.cs – Recipe detail form
└── README.md

Technology Stack

Platform: .NET 8.0 (Windows)

UI: Windows Forms

Language: C#

Database: SQL Server / SQL Compact

Installation
Requirements

.NET 8.0 SDK or newer

Visual Studio 2022 (or VS Code)

Steps

Clone the repository:
git clone https://github.com/ecemy3/RecipeSuggestion.git

cd RecipeSuggestion

Restore dependencies:
dotnet restore

Run the application:
dotnet run

Usage
Main Screen

Displays all recipes

Select any recipe to view its details

Adding a Recipe

Click “Add New Recipe”

Enter recipe information

Add ingredients

Click “Save”

Searching Recipes

Open the “Search/Filter” section

Search by recipe name or ingredient name

Updating a Recipe

Select a recipe from the list

Click “Edit”

Update the information

Click “Save”

Deleting a Recipe

Select a recipe

Click “Delete”

Confirm the deletion

File Overview

Form1.cs – Main application form
TarifEkle.cs – Add recipe form
TarifGuncelle.cs – Update recipe form
TarifSil.cs – Delete recipe form
AramaFiltreleme.cs – Search and filter form
Detay.cs – Recipe detail display form
DataBase.cs – Handles all database operations

License

This project is open-source and intended for personal use.
