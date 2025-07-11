# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos de solución y proyecto para restaurar dependencias
COPY *.sln ./
COPY Formula1Backend/*.csproj ./Formula1Backend/

# Restaurar paquetes
RUN dotnet restore

# Copiar todo el código fuente
COPY . .

# Publicar la app en modo Release
WORKDIR /app/Formula1Backend
RUN dotnet publish -c Release -o out --no-restore

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar los archivos publicados desde la etapa de build
COPY --from=build /app/Formula1Backend/out .

# Exponer el puerto donde corre la app (ajustalo si usas otro)
EXPOSE 5000

# Comando para ejecutar la app
ENTRYPOINT ["dotnet", "Formula1Backend.dll"]