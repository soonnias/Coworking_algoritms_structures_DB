# Coworking Space Management & Algorithm Benchmarking 🚀

## 📌 About the Project
This is an academic project developed for the "Databases" and "Algorithms & Data Structures" courses. The primary objective was to build a Coworking Space Management System while practically applying, integrating, and analyzing various data structures and algorithms.

Instead of relying solely on standard SQL queries, this application fetches data from the database and processes it in-memory. For each database table, different data structures and algorithms are applied to perform CRUD (Create, Read, Update, Delete) operations. The app then benchmarks and compares the execution times to determine the most efficient approach for specific datasets.

## 🛠 Tech Stack
* **Language:** C#
* **Framework:** .NET / Windows Forms
* **Database:** MySQL
* **Libraries:** [Bogus](https://github.com/bchavez/Bogus) (for generating realistic mock data for performance testing)

## ✨ Key Features
* **Database Management:** Handles core coworking entities such as Companies, Employees, Desks, and Contracts.
* **Algorithmic Benchmarking:** Measures and compares the execution time of different searching, insertion, and deletion algorithms across various data structures.
* **Graph Algorithms:** Implements Dijkstra's algorithm for finding the shortest path (e.g., navigating between coworking zones or desks).
* **Cryptography:** Includes custom implementation of RSA encryption logic.
* **Data Generation:** Uses the `Bogus` library to quickly populate the database with thousands of fake records, creating a realistic environment for algorithmic stress-testing.

## ⚙️ How to Run
1. Clone the repository:
   ```bash
   git clone [https://github.com/soonnias/Coworking_algoritms_structures_db.git](https://github.com/soonnias/Coworking_algoritms_structures_db.git)
