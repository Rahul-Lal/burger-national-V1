# 🍔 Burger National POS – Version 1

Burger National POS is a desktop Point of Sale (POS) system built using WPF (Windows Presentation Foundation) and C# (.NET).

Version 1 focuses on building a fully functional ordering interface without a database. All menu items, pricing logic, and customisation flows are handled in application memory.

This project is part of my portfolio to demonstrate practical desktop application development, structured logic design, and transactional flow handling.

## 🚀 Features

- Categorised menu navigation (Burgers, Sides, Drinks, Combos, etc.)
- Order building and quantity handling
- Burger customisation (cheese, sauces, extras)
- Combo logic and add-ons
- Dynamic total calculation
- Partial cash payments
- Change calculation
- Order reset after payment completion

## 🛠 Tech Stack
- C#
- WPF (.NET)
- XAML
- Git & GitHub

## 🧱 Architecture (Version 1)

Version 1 is UI-focused and does not use a database.

All data is:
- Hardcoded or managed in-memory
- Processed through window logic and event handling
- Reset when the application closes

The goal of this version is to establish:
- Order flow logic
- Payment handling mechanics
- UI responsiveness
- Foundational system structure

## 📦 Project Structure

BurgerNationalPOS/
│
├── BurgerNationalPOS.sln
├── /Views
├── /Models
├── /Logic
└── README.md

(Folder names may evolve as the architecture is refined.)

## 🏗 Roadmap

Version 2 will introduce:
- SQL Server integration
- Relational database design
- Persistent orders
- Modifier tables
- Payment records
- Separation of UI and data access layers
- Version 1 establishes the logic foundation before introducing persistence.

## ⚙️ Setup Instructions
1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run

No database setup required for Version 1.

## 🎯 Purpose

This project demonstrates:

- Structured application logic
- State management in a transactional environment
- Payment calculation workflows
- Refactoring from prototype to portfolio-ready code
- Progressive architectural thinking (UI → data-driven system)

## 📜 License

This project is licensed under the MIT License.


Version 1 represents the foundation.
Version 2 introduces persistence and full relational modelling.
