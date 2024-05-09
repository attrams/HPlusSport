# HPlusSport API

This repository contains an ASP.NET Core Web API project designed to demonstrate CRUD (Create, Read, Update, Delete) operations using Entity Framework Core (EF Core) with an InMemory Database. The project is structured to provide a straightforward example of a web API that can be tested and modified without the need for a physical database.

## Features

- **ASP.NET Core Web API** - The project is built using ASP.NET Core, a high-performance, open-source framework for building modern, cloud-based, Internet-connected applications.
- **Entity Framework Core** - Uses EF Core as the ORM (Object Relational Mapper) to manage the database operations.
- **InMemory Database** - Incorporates the EF Core InMemory Database Provider, ideal for testing purposes as it avoids the overhead of actual database operations.
- **Swagger Integration** - Includes Swagger (Swashbuckle) for API documentation and testing UI, making it easier to interact with the API directly through your browser.

## Prerequisites

Before you begin, ensure you have the following installed:

- NET 8.0 SDK or later
- Docker (optional, if running the application within a Docker container)

## Getting Started

### Running the Project Locally
To run the project on your local machine, follow these steps:

1. Clone the repository to your local machine:
```bash
    git clone https://github.com/your-username/your-project-repository.git
    cd HPlusSport/HPlusSport.API
```

2. Restore the required packages:
```bash
    dotnet restore
```

3. Build the application:
```bash
    dotnet build
```

4. Run the application:
```bash
    dotnet run
```
This command will start the API server which is hosted at `http://localhost:5221`.

5. To access the Swagger UI to interact with the API, navigate to `http://localhost:5221/swagger/index.html`.


### Running with Docker

If you prefer to use Docker, follow these steps to containerize and run the project:

1. Build the Docker image:
```bash
    docker build -t hplus-sport-api .
```

2. Run the Docker container:
```bash
    docker run -p <port_number>:8080 hplus-sport-api
```
This command maps port 8080 of the container to port `<port_number>` on your host.

3. Access the application via the following URL: `http://localhost:5221/swagger/index.html`