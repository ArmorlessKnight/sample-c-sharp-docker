FROM microsoft/dotnet:2.1.301-sdk-alpine3.7 AS build
RUN mkdir -p /app

# Copy csproj and restore as distinct layers
COPY src/*.csproj /app
WORKDIR /app
RUN dotnet restore

# Copy everything else and build app
COPY ./src /app
RUN dotnet publish -c Release -o out

# Finalize application
FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine3.7 AS runtime
RUN mkdir -p /app
WORKDIR /app
COPY --from=build /app/out /app
ENTRYPOINT ["dotnet", "SimpleAPI.dll"]