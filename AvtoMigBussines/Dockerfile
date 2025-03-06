# Базовый образ для финального контейнера
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Образ для сборки
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Копируем только .csproj (убрал лишний путь)
COPY AvtoMigBussines.csproj ./
RUN dotnet restore "AvtoMigBussines.csproj"

# Копируем весь код проекта и выполняем build
COPY . . 
RUN dotnet build "AvtoMigBussines.csproj" -c Release -o /app/build

# Выполняем publish
FROM build AS publish
RUN dotnet publish "AvtoMigBussines.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Финальный образ
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AvtoMigBussines.dll"]
