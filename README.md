# eTickets ASP.NET Project Setup Guide

Welcome to the eTickets project repository! This guide will walk you through the steps to run this e-tickets project
The easiest way to do it is to clone and run the project using Visual Studio and IIS Express to ensure you have the correct configuration for a smooth experience.

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) is installed on your machine.
- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) is installed.

## Cloning and Running the Project

1. **Clone the Repository:**
   - Open Visual Studio.
   - Click on "Clone a repository" in the start window or navigate to "File" > "Clone Repository..."
   - Enter the repository URL: `https://github.com/YourUsername/eTickets.git`
   - Choose the directory where you want to clone the project.
   - Click "Clone."

2. **Open the Project:**
   - Once the cloning is complete, you'll be prompted to open the project. Click "Open."

3. **Set the Startup Project:**
   - Right-click on the solution in the Solution Explorer.
   - Select "Set Startup Projects..."
   - Choose "Multiple startup projects" and set the "Action" for your eTickets project to "Start."

4. **Configure IIS Express:**
   - In the Solution Explorer, right-click on your eTickets project and select "Properties."
   - Under the "Web" tab, make sure that "IIS Express" is selected as the server.
   - Ensure the correct port and start URL are specified. The default is usually `https://localhost:44325/Movie`.

5. **Run the Project:**
   - Press `F5` or click the "Start" button in the toolbar to run the project.
   - Visual Studio will automatically launch IIS Express and open your project in a web browser.

## Notes

- If you encounter any port conflicts, Visual Studio will automatically assign an available port for your project. Make sure to use the correct port displayed in the browser URL.
- The project has been configured to work seamlessly with IIS Express for local development. Be sure to use Visual Studio's integrated tools for debugging and managing your project.

## Contributing and Issues

If you encounter any issues or have suggestions for improvements, feel free to submit an issue or pull request. Please ensure that the issue is not related to incorrect project configuration, as this guide is designed to help with the correct setup.

## License

This project is licensed under the [MIT License](LICENSE).
