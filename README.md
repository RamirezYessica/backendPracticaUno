API REST sencilla para la gestión de tareas (crear, listar y completar).

Descripción
Este backend está desarrollado con **ASP.NET Core 8 Web API** y expone endpoints REST para manejar tareas.

Características:
- Crear tareas
- Listar tareas
- Marcar tareas como completadas
- Persistencia en memoria (sin base de datos)

---

## Cómo ejecutar el backend

### Requisitos
- .NET SDK 8

### Pasos

1. Ubicarse en la carpeta del backend:
```bash
cd backend
2. Ejecutar la API:
dotnet run
3. La API estará disponible en:
https://localhost:5001

Endpoints disponibles
GET /api/tasks
POST /api/tasks
PUT /api/tasks/{id}/complete



