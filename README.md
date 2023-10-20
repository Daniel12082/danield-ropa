# API de Notificaciones en C#/.NET

Este README proporciona información sobre la creación de una API de notificaciones en C# utilizando el framework .NET. La API se desarrolla utilizando varios proyectos y dependencias para lograr un sistema completo de notificaciones. A continuación, se detallan las entidades clave involucradas en el proyecto y los pasos para su configuración.

Con este backend se busca llevar el control, registro y seguimiento de la producción de prendas de seguridad industrial de la empresa safe clothing

## Entidades

- **Cargo** 
- **Cliente** 
- **Color**
- **Departamento**
- **DetalleOrden**
- **Empleado**
- **Empresa**
- **Estado**
- **Forma De Pago**
- **Genero**
- **Insumo**
- **InsumoPrenda**
- **InsumoProveedor**
- **Inventario**
- **InventarioTalla**
- **Municipio**
- **Orden**
- **Pais**
- **Prenda**
- **Proveedor**
- **Talla**
- **TipoEstado**
- **TipoPersonas**
- **TipoProteccion**
- **Venta**


## Estructura del Proyecto

El proyecto se organiza en tres componentes principales:

1. **Core**: Biblioteca de clases que contiene las definiciones de las entidades y la lógica central de la aplicación. Aquí se define la estructura de datos y la lógica de negocios.
2. **Infrastructure**: Biblioteca de clases que gestiona aspectos de infraestructura, como el acceso a la base de datos, servicios de terceros, registro de auditoría, etc.
3. **ApiNotifications**: Aplicación web API que proporciona endpoints para interactuar con la API de notificaciones. Aquí se configuran las rutas, controladores y autenticación.

## Pasos de Creación del Proyecto

### Creación de Solución

```bash
dotnet new sln

```

### Creación de Proyecto Core

```bash
dotnet new classlib -o Core

```

### Creación de Proyecto Infrastructure

```bash
dotnet new classlib -o Infrastructure

```

### Creación de Proyecto Web API

```bash
dotnet new webapi -o API

```

### Agregar Proyectos a la Solución

```bash
dotnet sln add API
dotnet sln add Core
dotnet sln add Infrastructure

```

### Agregar Referencias entre Proyectos

Asegúrese de que los proyectos tengan las referencias necesarias para que funcionen correctamente. Las referencias se establecen desde el proyecto que contiene la referencia.

```bash
dotnet add reference ..\Infrastructure
dotnet add reference ..\Core

```

## Instalación de Paquetes

### Proyecto WebAPI

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.10
dotnet add package Microsoft.Extensions.DependencyInjection --version 7.0.0
dotnet add package System.IdentityModel.Tokens.Jwt --version 6.32.3
dotnet add package Serilog.AspNetCore --version 7.0.0
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

```

### Proyecto Infrastructure

```bash
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package CsvHelper --version 30.0.1

```
### Comando Migracion 

1. dotnet ef migrations add (Nombre De la Migracion) --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations

2. dotnet ef database update --project ./Infrastructure/ --startup-project ./API/

### Poner a correr el proyecto

```bash
dotnet run --project .\API\

```

### URL de los EndPoints
```bash
http://localhost:5086/(NombreDelEndPoint)

Ejemplo:

http://localhost:5086/Cargo

```

### Parametros Del Enpoint


### Caergo
{ "Descripcion" : "String", "SueldoBase" : Int }

### Cliente

Necesita Tener Creado : 
1. Tipo Persona
2. Municipio

{ "IdCliente" : Int, "Nombre" : String, "IdTipoPersonaFK" : Int, "IdMunicipioFk" : Int}

### Color

{ "Descripcion" : "String" }

### Departamento 

{ "Nombre" : "String"}

### DetalleOrden

Necesita Tener Creado :
1. Orden
2. Prenda
3. Color
4. Estado

{ "IdOrdenFk" : int , "IdPrendaFk" : int ,"CantidadProducir": Int,  "IdColorFk" : int,"CantidadProducida": Int, }

### Detalle Venta

Necesita Tener Creado :
1. Venta
2. Producto
3. Talla

{ "IdVentaFk": int ,"IdProductoFk": int ,"IdTallaFk": int ,"Cantidad": int ,"ValorUnit": int}

### Empleado

Necesita Tener Creado : 
1. Cargo
2. Municipio

{ "IdEmpleado" : int, "Nombre" : "String", "IdCargoFk" : int, "FechaIngreso": aaaa-mm-dd , "IdMunicipioFk" : int}

### Empresa

Necesita Tener Creado : 
1. Municipio

{"Nit" : Int, "RazonSocial" : "String" , "Representante, "FechaCreacion" : aaaa-mm-dd , "IdMunicipioFk"}

### Estado

Necesita Tener Creado:
1. TipoEstado

{ "Descripcion" : "String", "IdTipoEstadoFk" : Int}

### Forma De Pago

{ "Nombre" : "String"}

### Genero

{ "Descripcion" : "String"}

### Insumo

{ "Nombre" : "String", "ValorUnit" : int , "StockMin" : int, , "StockMin" : int }

### Inventario
{
    "CodInv" : Int,
    "ValorVtaCop" : "int",
    "ValorVtaUsd" : "int",
    "IdPrendaFk" : int
}

### Municipio
{
    "Nombre" : "string",
    "IdDepartamentoFk" : "int"
}

### Orden
{
    "Fecha" : 0000/00/00,
    "IdEmpleadoFk" : "int",
    "IdClienteFk" : "int",
    "IdEstadoFk" : int
}

### Pais
{
    "Nombre" : "string"
}

### Prenda
{
    "IdPrenda" : Int,
    "Nombre" : "string",
    "ValorUnitCop" : int,
    "ValorUnitUsd" : int,
    "IdEstadoFk" : int,
    "IdTipoProteccionFk" : int,
    "IdGeneroFk" : int
}

Proveedor
{
    "NitProveedor" : Int,
    "Nombre" : "string",
    "IdTipoPersonaFk" : int,
    "IdMunicipioFk" : int
}

### Talla
{
    "Descripcion" : "string"
}

### TipoEstado
{
    "Descripcion" : "string"
}

### TipoPersona
{
    "Nombre" : "string"
}

### TipoProteccion
{
    "Descripcion" : "string"
}

### Venta
{
    "FechaCreacion" : 0000/00/00,
    "IdEmpleadoFk" : int,
    "IdClienteFk" : int,
    "IdFormaPagoFk" : int
}

### Contribuidores:
Creacion Del BackEnd
* Daniel Felipe Diaz Sanchez

Normalización de la base de datos:
* Jholver Pardo