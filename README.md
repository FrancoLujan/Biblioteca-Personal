## 📁 Estructura del Proyecto

Explicación simple de la organización de carpetas y archivos del sistema:

```text
📦 Proyecto
 ┣ 📂 Dominio        # Clases puras (entidades del diagrama de clases)
 ┣ 📂 BD             # Configuración de la conexión a la base de datos
 ┣ 📂 Repositorios   # Consultas SQL (todos los métodos son asíncronos)
 ┣ 📂 Servicios      # Lógica de negocio y comprobaciones (usa Repositorios)
 ┣ 📂 Pantalla       # Clases de interfaz, incluido el Menú (usa Servicios)
 ┗ 📜 Program.cs     # Configuración de Inyección de Dependencias (DI)
```

### Detalle de Capas

* **Dominio:** Contiene las clases puras del negocio, correspondientes al diagrama de clases.
* **BD:** Configuración de la conexión a la base de datos.
* **Repositorios:** Clases encargadas de las consultas SQL. *(⚠️ **Ojo:** Todos los métodos son **asíncronos**)*.
* **Servicios:** Utiliza las clases de `Repositorios` para darle lógica y realizar las comprobaciones/validaciones de la aplicación.
* **Pantalla:** Agrupa todas las clases que conforman las vistas/pantallas del sistema, **incluido el Menú**, el cual se encarga de consumir los servicios.

---

## 🔄 Flujo e Inyección de Dependencias

El flujo de comunicación entre las capas sigue esta dirección:

```text
[ Menú ] ➔ [ Servicios ] ➔ [ Repositorios ] ➔ [ Dominio ]
```

> [!IMPORTANT]
> **Inyección de Dependencias en `Program.cs`:**  
> En el archivo `Program.cs` se define el contenedor de inyección de dependencias tanto para **Servicios** como para **Repositorios**.  
> Todo lo necesario se inyecta **en cascada** de forma automática, lo que evita tener que instanciar o encadenar constructores manualmente.