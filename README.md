# Calculator In .NET  

## Description  
This project is a calculator developed in .NET with Windows Forms, designed to perform basic mathematical operations such as addition, subtraction, multiplication, and division, along with advanced functions like percentage, square root, and exponentiation. The application follows a layered architecture, integrating a database connection to log and audit each operation performed.

## Project Structure

- **📂 Calculator**
  - **📂 CapaPresentacion** (UI - Interfaz de Usuario)
    - `Form1.cs`
    - `RoundedTextBox.cs`
    - `Program.cs`
    - `LoginV2.cs`
  - **📂 CapaNegocio** (Lógica de Negocio)
    - `Calculadora.cs` (Maneja las operaciones matemáticas)
    - `AuditoriaManager.cs` (Gestiona la auditoría de transacciones)
    - `RoleEntity.cs`
  - **📂 CapaDatos** (Acceso a Datos)
    - `DatabaseHelper.cs` (Manejo de conexión con la base de datos)
    - `AuditoriaRepository.cs` (Registra las operaciones en la BD)
    - `ConfiguracionDB.cs` (Gestión de conexión y configuraciones)
  - **📂 Database** (Base de Datos)
    - `database_setup.sql` (Script para crear tablas)
    - `connection_config.json` (Opcional: Configuración de conexión)
  - `README.md`

## Features  
- Intuitive graphical interface based on WinForms  
- Basic and advanced mathematical operations  
- Flow control implementation to prevent errors like division by zero  
- Organized architecture with separate classes for operations and UI  
## Technologies Used  
- **Language:** C#  
- **Framework:** .NET  
- **GUI:** Windows Forms

## Project Structure
The project is organized into multiple layers following the layered architecture pattern:
- Presentation Layer (CapaPresentación) [**Type:** Windows Forms Application, WPF]
- Entity Layer (CapaEntidad) [**Type:** Class Library (.NET Framework)]
- Business Layer (CapaNegocio) [**Type:** Class Library (.NET Framework)]
- Data Layer (CapaDatos) [**Type:** Class Library (.NET Framework)]
## Structure
  ![image](https://github.com/user-attachments/assets/55436d66-c5ca-4b38-a412-f69aee2fe1f3)
  
```sh
   CapaDatos → Acceso a la base de datos (Aquí van las consultas SQL)
   CapaNegocio → Procesa la lógica de negocio (Llama a la CapaDatos)
   CapaEntidad → Clases que representan los datos (Modelos de las tablas)
   CapaPresentación → Interfaz de usuario (Llama a la CapaNegocio)
```

## Installation and Usage  
1. Clone the repository:  
   ```sh
   git clone https://github.com/JhonnFy/Calculator.git
   ```  
2. Open the project in **Visual Studio 2022**  

3. Set up the database
The application includes a database connection to log and audit calculations.
Import the provided SQL script (database_setup.sql) to create the necessary tables.
Update the connection string in DatabaseHelper.cs to match your SQL Server configuration.

4. Run the application
Build and execute the project from Visual Studio.
Perform calculations and verify that operations are logged in the database.

## Gallery
![image](https://github.com/user-attachments/assets/57d86495-6499-45f6-a9b3-5ad8a90b5755)
![image](https://github.com/user-attachments/assets/b9fe2199-5d5e-403a-acce-48dc20c25d69)
![image](https://github.com/user-attachments/assets/04a83b34-02d2-40a4-8a1c-c161a820e122)
![image](https://github.com/user-attachments/assets/08c7e37a-a423-4a69-8cc1-dbadfb3137f1)
![image](https://github.com/user-attachments/assets/02001d72-ffca-4b69-a649-f4e6194f12f5)
![image](https://github.com/user-attachments/assets/776152e9-afba-4856-975f-2591550a9db9)
![image](https://github.com/user-attachments/assets/5cfe4daa-3c46-4cfc-9ce0-ef69f8cd27de)

## Contributions  
Contributions are welcome. If you want to improve any functionality, open an issue or submit a pull request.  

## License
This project is licensed under the MIT License.
