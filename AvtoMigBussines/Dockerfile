# ������� ����� ��� ���������� ����������
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# ����� ��� ������
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# �������� ������ .csproj (����� ������ ����)
COPY AvtoMigBussines.csproj ./
RUN dotnet restore "AvtoMigBussines.csproj"

# �������� ���� ��� ������� � ��������� build
COPY . . 
RUN dotnet build "AvtoMigBussines.csproj" -c Release -o /app/build

# ��������� publish
FROM build AS publish
RUN dotnet publish "AvtoMigBussines.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ��������� �����
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AvtoMigBussines.dll"]
