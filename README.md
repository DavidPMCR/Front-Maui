# 📱 MauiAppMovil (.NET MAUI + API REST)

## 🧾 Descripción

**MauiAppMovil** es una aplicación móvil multiplataforma desarrollada con **.NET MAUI** que permite gestionar **cursos** mediante operaciones CRUD completas (crear, leer, actualizar y eliminar). Cada curso puede incluir una imagen. La app consume una API REST disponible en este repositorio:

🔗 [Backend API - Repositorio](https://github.com/DavidPMCR/Backend-P-Investigacion)

Enlace al Video Tutorial: [https://youtu.be/ag1WV5wFvKs](https://youtu.be/ag1WV5wFvKs)

---

## 📁 Estructura del Proyecto

```plaintext
MauiAppMovil/
├── Models/
│   └── Course.cs
├── Services/
│   ├── CourseService.cs
│   └── AppConstants.cs
├── ViewModels/
│   └── CourseViewModel.cs
├── Views/
│   ├── CourseFormPage.xaml
│   ├── CourseFormPage.xaml.cs
│   ├── CoursePage.xaml
│   └── CoursePage.xaml.cs
├── Resources/Embedded/
│   └── test_image.png
├── tests/
│   ├── CreateCourseTest.cs
│   ├── UpdateCourseTest.cs
│   ├── DeleteCourseTest.cs
│   ├── ReadCourseTest.cs
│   └── TestHelpers.cs
└── README.md
```

---

## ✅ Requisitos Previos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (con soporte para .NET MAUI)
- Emulador Android/iOS o dispositivo físico
- Acceso a la API REST (ver sección de configuración)

---

## 📦 Instalación de Dependencias

1. Clona el repositorio:

   ```bash
   git clone https://github.com/tu-usuario/MauiAppMovil.git
   cd MauiAppMovil
   ```

2. Restaura los paquetes NuGet:

   ```bash
   dotnet restore
   ```

3. (Opcional) Abre la solución en Visual Studio para que se restauren automáticamente.

---

## ⚙️ Configuración del Entorno

### 🔗 API REST

La app se conecta a una API REST cuya URL base está definida en `Services/AppConstants.cs`:

```csharp
public static string ApiBaseUrl = "http://localhost:5275/api";
```

> 🔧 **Importante**: Cambia la URL si ejecutas la API en otro puerto o red. En emuladores Android, es necesario usar `http://10.0.2.2:5275/api`.

- Asegúrate de que la API (Backend) esté corriendo antes de usar la app.
- El helper `TestHelpers.SetApiBaseUrlToLocalhost()` configura automáticamente la URL para pruebas.

Repositorio del backend:  
📎 [https://github.com/DavidPMCR/Backend-P-Investigacion](https://github.com/DavidPMCR/Backend-P-Investigacion)

---

## ▶️ Ejecución de la Aplicación

### 🔧 Desde Visual Studio

1. Abre la solución (`.sln`) en Visual Studio 2022.
2. Selecciona un dispositivo/emulador.
3. Pulsa **F5** o haz clic en **Iniciar**.

> Asegúrate de que la API esté activa y accesible desde el dispositivo/emulador.

---

## 🧪 Ejecución de Pruebas

Las pruebas unitarias están ubicadas en la carpeta `tests/`.

Ejecuta todos los tests con:

```bash
dotnet test
```

Esto compilará y ejecutará las pruebas mostrando los resultados en consola.

---

## 🌐 Endpoints Esperados por la App

| Método | Ruta               | Descripción                                |
|--------|--------------------|--------------------------------------------|
| GET    | `/api/course`      | Listar todos los cursos                    |
| POST   | `/api/course`      | Crear un nuevo curso (con imagen)         |
| PUT    | `/api/course/{id}` | Actualizar un curso (imagen opcional)     |
| DELETE | `/api/course/{id}` | Eliminar un curso por ID                  |

---

## 🛠️ Notas Técnicas

- La API debe ser accesible desde el emulador o dispositivo.
- Para desarrollo en Android, `http://10.0.2.2` es un alias útil para `localhost`.
- La app utiliza `multipart/form-data` para subir imágenes.
- Se validan los campos requeridos antes de enviar los formularios.
- Las imágenes se adjuntan como archivos en las peticiones POST y PUT.

---

## 📚 Recursos Útiles

- [.NET MAUI - Documentación Oficial](https://learn.microsoft.com/dotnet/maui/)
- [.NET - Pruebas y Testing](https://learn.microsoft.com/dotnet/core/testing/)
- [Guía para configurar emuladores Android](https://developer.android.com/studio/run/emulator)

---

## ❓ Soporte

Si tienes dudas sobre la configuración o el funcionamiento de la app, consulta los comentarios en el código o abre un issue en este repositorio.

---
