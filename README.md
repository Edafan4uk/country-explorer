# Country explorer
Country explorer using "Rest Countries" api

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Node.js installed on your machine. You can download it from [nodejs.org](https://nodejs.org/).
- .NET SDK installed on your machine. You can download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
- Visual Studio Code or any other preferred code editor.
- (Optional) Visual Studio IDE for easier development experience.

## Setup Instructions

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/Edafan4uk/country-explorer.git
    ```

2. Checkout the master branch:

    ```bash
    git checkout master
    ```

3. Navigate to the `client` directory:

    ```bash
    cd country-explorer/client
    ```

4. Install frontend dependencies:

    ```bash
    npm install
    ```

5. Navigate back to the root directory:

    ```bash
    cd ..
    ```

6. Navigate to the `server` directory:

    ```bash
    cd server
    ```

7. Restore backend dependencies:

    ```bash
    dotnet restore
    ```

8. Trust the HTTPS development certificate:

    ```bash
    dotnet dev-certs https --trust
    ```

## Running the Application

Now that you've set up the project, you can run both the frontend and backend parts simultaneously.

1. Start the ASP.NET Core server with HTTPS launch profile:

    ```bash
    dotnet run --launch-profile https
    ```

   This will start the backend server at `https://localhost:7265/`.

2. In a separate terminal, start the React development server:

    ```bash
    cd client
    npm start
    ```

   This will start the frontend server at `http://localhost:3000`.

3. Open your web browser and navigate to `http://localhost:3000` to see the application running.

## Exploring the API with Swagger

You can explore the API endpoints using Swagger UI. Open your web browser and navigate to:

[Swagger UI](https://localhost:7265/swagger/index.html)

## Additional Notes

- You can customize the configuration settings in the `appsettings.json` file located in the `server` directory to suit your needs.
- Make sure to update the API endpoint in the React app if you change the backend server's URL or port.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, feel free to open an issue or create a pull request.
