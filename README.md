# Pokédex - Sistema CRUD en Windows Forms

## Descripción General

El proyecto de Pokédex es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre una lista de Pokémon, así como filtrar los Pokémon por diferentes campos y ver detalles de cada uno.

## Características Clave

- **Interfaz de Usuario Amigable:** Diseñada con Windows Forms para una experiencia de usuario intuitiva y fácil de usar.
- **Conexión a Base de Datos:** Utiliza ADO.NET para conectarse a una base de datos (puede ser SQL Server o SQLite) donde se almacenan los detalles de los Pokémon.
- **Operaciones CRUD:**
  - **Crear:** Permite agregar nuevos Pokémon al catálogo proporcionando información como nombre, tipo, habilidades, etc.
  - **Leer:** Muestra una lista de Pokémon que permite a los usuarios buscar y visualizar los Pokémon existentes. Además, los usuarios pueden hacer clic en un Pokémon para ver más detalles.
  - **Actualizar:** Permite a los usuarios editar la información de los Pokémon seleccionados y guardar los cambios en la base de datos.
  - **Eliminar:** Permite a los usuarios eliminar Pokémon del catálogo seleccionando un Pokémon y haciendo clic en un botón "Eliminar".
  - **Suspender:** Ofrece la opción de suspender temporalmente un Pokémon, desactivándolo temporalmente sin eliminarlo completamente de la lista.
- **Filtrado y Búsqueda:**
  - Permite a los usuarios filtrar los Pokémon por diferentes campos como ID, nombre, tipo, etc.
  - Implementa un filtro dinámico que permite filtrar los Pokémon en tiempo real a medida que el usuario escribe en un TextBox.
- **Validación de Datos:** Se implementa una validación de datos en los formularios para garantizar que los campos requeridos estén completos y que los datos sean correctos antes de realizar operaciones de creación o actualización.
- **Notificaciones y Mensajes de Error:** Se proporcionan mensajes de notificación y error para informar a los usuarios sobre el éxito o el fracaso de las operaciones CRUD.

## Capturas de Pantalla

A continuación se muestran algunas capturas de pantalla de la aplicación en funcionamiento:
<img width="700" alt="img24" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/80f6f6c6-729f-4017-ba43-7bb9422863a9">
<img width="691" alt="img25" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/748969ff-7d97-4b57-bfbe-ffa7e08fc5d6">
<img width="700" alt="img26" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/2f8df463-c3bd-4c05-b931-7e2b2a9d5816">
<img width="691" alt="img27" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/5a7c76ec-b2d0-4237-983a-58f8ec76d063">
<img width="684" alt="img28" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/a59e3a1b-c8c6-4301-8245-fc32bf35e3f1">
<img width="683" alt="img29" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/163a3d9f-13a9-4985-8dde-93a3b662dbfa">
<img width="683" alt="img30" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/1fe0e549-238d-4fd9-aaef-1b8b8832ba77">
<img width="676" alt="img31" src="https://github.com/Facundo-Banegaz/Pokedex/assets/130815244/c761fa25-5950-4f55-b138-aeec90084aa5">



## Instalación

Para ejecutar la aplicación en tu propio entorno de desarrollo, sigue estos pasos:

1. Clona o descarga el repositorio a tu computadora.
2. Abre la solución en Visual Studio.
3. El Scrip de la Bd esta en una carpeta Negocio/Scrip_Db/Pokemon.sql.
4. Compila y ejecuta el proyecto.


## Tecnologías Utilizadas

- C# (Lenguaje de programación)
- Windows Forms (Framework para desarrollo de aplicaciones de escritorio en Windows)
- .NET Framework (Plataforma de desarrollo de Microsoft para construir aplicaciones Windows)
- SQL Server  (Base de datos para almacenamiento de datos)


