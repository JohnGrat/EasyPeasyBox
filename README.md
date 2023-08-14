# EasyPeasyBox Application
This is a web application that consists of an ASP.NET Core Web API backend and an ASP.NET Core web app frontend. The primary functionality of the application is to fetch weather data from an endpoint provided by the backend.

## Technical Choices

The following technical choices were made for the development of this application:

- **Backend**: ASP.NET Core was chosen as the backend framework. It provides a robust and scalable platform for building APIs, which is essential for delivering weather data to the frontend.

- **Frontend**: The frontend is also developed using ASP.NET Core. It utilizes an HTTP client to retrieve weather data from the backend.

## Running and Testing the Application with Docker and Docker Compose

To run and test the application using Docker and Docker Compose, follow these steps:

1. **Open a terminal**: Launch your preferred terminal application.

2. **Navigate to the Application Directory**: Use the `cd` command to navigate to the directory where the application is located.

3. **Run Docker Compose**: Execute the following command to start the application in detached mode:

   docker-compose up -d
