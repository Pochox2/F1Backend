# 🏎️ Formula1Backend

*Formula1Backend* es una API REST desarrollada con *ASP.NET Core 8* que gestiona información del mundo de la Fórmula 1. Permite realizar operaciones CRUD sobre entidades como:

- Escuderías
- Pilotos
- Pistas

Cuenta con una arquitectura limpia, validaciones, mapeo automático de datos, manejo de errores y carga automática de datos iniciales mediante seeders.

---

## 🧠 Tecnologías utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQLite
- AutoMapper
- Swagger (documentación)
- Postman (testing)

---

## 📁 Estructura del proyecto

```bash
Formula1Backend/
├── Config/               # DbContext, AutoMapper config
├── Controllers/          # API controllers
├── Models/
│   ├── Entities/         # Entidades: Escuderia, Piloto, Pista
│   ├── Dto/              # DTOs para requests/responses
├── Services/             # Lógica de negocio
├── Seeders/              # Carga automática de datos iniciales
└── Program.cs            # Configuración general de la app
