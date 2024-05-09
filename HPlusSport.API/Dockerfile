# Use the .NET SDK to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HPlusSport.API.csproj", "./"]
RUN dotnet restore "HPlusSport.API.csproj"

COPY . .
RUN dotnet build "HPlusSport.API.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "HPlusSport.API.csproj" -c Release -o /app/publish

# Use the .NET runtime to run the project
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "HPlusSport.API.dll"]
