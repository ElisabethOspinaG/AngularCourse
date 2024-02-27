 FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
 WORKDIR /app
 EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /app
COPY . .
RUN dotnet publish -c RELEASE -o /publish

 FROM base
 WORKDIR /app
 COPY --from=publish  /app/publish .
 ENTRYPOINT ["dotnet","WebApiDatabaseConnection.dll"]