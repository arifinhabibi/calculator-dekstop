# VB.NET Calculator Application

This is a simple calculator application built using **VB.NET**. The app allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division.

### Features:
- Input fields to enter two numbers.
- Arithmetic operations: Add, Subtract, Multiply, Divide.
- A result field that shows the output of the operation.
- A reset button to clear inputs and results.
- Handles input validation and shows an error message if invalid inputs are provided.

---

## Getting Started

### Prerequisites

To run this application, you need:
- **Visual Studio** (with VB.NET support)
- **.NET Framework** (usually comes with Visual Studio)

### Steps to Build the Application

1. Open the project in **Visual Studio**.
2. Build the solution by clicking on **Build > Build Solution** or pressing `Ctrl + Shift + B`.
3. Once the build is complete, the `.exe` file will be located in the `bin\Release` or `bin\Debug` folder of your project directory.

### Steps to Run the Application

1. Navigate to the folder where the `.exe` file is located.
2. Double-click the `.exe` file to launch the calculator.

---

## Features

### 1. Input Fields

- **Input1**: The first number for the calculation.
- **Input2**: The second number for the calculation.

### 2. Operations

- **Add**: Adds Input1 and Input2.
- **Subtract**: Subtracts Input2 from Input1.
- **Multiply**: Multiplies Input1 and Input2.
- **Divide**: Divides Input1 by Input2 (Note: handles division by zero).

### 3. Reset Button

- Clears both input fields and the result.

### 4. Result Display

- The result of the calculation is displayed in the **Result** field.

---

## Example Usage

1. Enter **10** in Input1.
2. Enter **20** in Input2.
3. Click on the **Add** button.
4. The result should display **30** in the Result field.

---

## Error Handling

The application includes basic error handling:
- If invalid input is entered (e.g., letters or empty fields), an error message will appear.
- Division by zero is handled by displaying a relevant error message.

---

## Contributing

If you would like to contribute to this project, feel free to fork the repository, make changes, and submit a pull request.

---

## License

This project is open-source and available under the [MIT License](LICENSE).

---

## Acknowledgments

- This application was built as an example of using VB.NET for simple GUI-based calculations.
- Thanks to the Visual Studio IDE for providing an easy development environment.
