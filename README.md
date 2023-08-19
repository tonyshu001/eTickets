# eTickets ASP.NET Project Setup Guide

Welcome to the eTickets project repository! This guide will walk you through the steps to run this e-tickets project.

## Project Overview

eTickets is a feature-rich ASP.NET MVC application designed to streamline the process of managing and booking tickets for movies. With its user-friendly interface and powerful backend, eTickets offers a seamless experience for administrators and users alike.

## Features

- **Event Listings:** Browse a variety of content, including movies, actors, cinemas, and more.
- **Ticket Booking:** Easily select and book tickets for your favorite movie.
- **User Authentication:** Create an account or log in to access personalized features.
- **Admin Panel:** Administrators can manage events, ticket availability, and more.
- **Secure Payments:** Integrated PayPal integration ensures secure and convenient payments.
- **Role-Based Access:** Role-based authorization controls access to different parts of the application.
- **Dynamic UI Components:** Use ViewComponents for dynamic rendering of content.
- **Azure Deployment:** Seamlessly deploy the application and database to Azure.

## How to run it
The easiest way to do it is to clone and run the project using Visual Studio and IIS Express to ensure you have the correct configuration for a smooth experience (with a nice GUI as well).

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) is installed on your machine.
- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) is installed.

## Cloning and Running the Project

1. **Clone the Repository:**
   - Open Visual Studio.
   - Click on "Clone a repository" in the start window or navigate to "File" > "Clone Repository..."
   - Enter the repository URL: `https://github.com/tonyshu001/eTickets.git`
   - Choose the directory where you want to clone the project.
   - Click "Clone."

2. **Open the Project:**
   - Once the cloning is complete, you'll be prompted to open the project. Click "Open."

3. **Run the Project:**
   - IIS Express Configuration:
      When you run your project using IIS Express, it will use a configuration file called applicationhost.config. This file stores the settings for each project and its bindings. The URLs and ports used by IIS Express can sometimes be different from the URLs specified in your project's properties.
   - Make sure you have selected the IIS Express when you are ready to run the project. To do so, left-click on the down-side arrow (highlighted in the red box) and then select IIS Express instead of eTickets.
   ![image](https://github.com/tonyshu001/eTickets/assets/87597364/14a6419b-6205-404e-a628-1f9f9d1bcfd6)
   - The default URL and port number is `https://localhost:44325/Movie`, you can change it based on your preferrence.
   - Press `F5` or click the "Start" button in the toolbar to run the project.
   - Visual Studio will automatically launch IIS Express and open the project in a web browser.

## Notes

- If you encounter any port conflicts, Visual Studio will automatically assign an available port for your project. Make sure to use the correct port displayed in the browser URL.
- The project has been configured to work seamlessly with IIS Express for local development. Be sure to use Visual Studio's integrated tools for debugging and managing your project.

## Contributing and Issues

If you encounter any issues or have suggestions for improvements, feel free to submit an issue or pull request. Please ensure that the issue is not related to incorrect project configuration, as this guide is designed to help with the correct setup.

## License

This project is licensed under the [MIT License](LICENSE).
