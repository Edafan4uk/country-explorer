# Country explorer
Country explorer using "Rest Countries" api

The project utilizes the [Rest Countries API](https://restcountries.com/) to fetch country data.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Node.js installed on your machine. You can download it from [nodejs.org](https://nodejs.org/).
- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine.
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

3. Navigate to the `countries-ui` directory (Client app):

    ```bash
    cd country-explorer/countries-ui
    ```

4. Install frontend dependencies:

    ```bash
    npm install
    ```

5. Navigate back to the root directory:

    ```bash
    cd ..
    ```

6. Navigate to the `countries-api` directory (ASP.NET Core app):

    ```bash
    cd countries-api
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
    cd countries-ui
    npm start
    ```

   This will start the frontend server at `http://localhost:3000`.

3. Open your web browser and navigate to `http://localhost:3000` to see the application running.

## Exploring the API with Swagger

You can explore the API endpoints using Swagger UI. Open your web browser and navigate to:

[Swagger UI](https://localhost:7265/swagger/index.html)

## Additional Notes

- You can customize the configuration settings in the `appsettings.json` file located in the `countries-api` directory to suit your needs.
- Make sure to update the API endpoint in the React app if you change the backend server's URL or port.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, feel free to open an issue or create a pull request.
