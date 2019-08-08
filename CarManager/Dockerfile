FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY CarManager/CarManager.csproj CarManager/
RUN dotnet restore "CarManager/CarManager.csproj"
COPY . .
WORKDIR "/src/CarManager"
RUN dotnet build "CarManager.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CarManager.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CarManager.dll"]
