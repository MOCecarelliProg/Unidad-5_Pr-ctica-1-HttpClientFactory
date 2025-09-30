# Unidad-5_Pr-ctica-1-HttpClientFactory
Repositorio de la práctica 1 de la unidad 5 sobre HttpClientFactory.

# El objetivo principal de la actividad es hacer uso de HttpClientFactory para intentar comunicarse con una api pública de chistes y obtener un chiste aleatorio.

# Este es el repositorio oficial de la api de chistes: https://github.com/15Dkatz/official_joke_api
Puedes consultar los endpoints que ofrece y testear alguno para conocer el formate de los objetos que retorna

# La plantilla inicial de la actividad ya contiene todos los archivos necesarios en cada capa. Sólo debes completar el código para coordinar el funcionamiento. Clona este repositorio e intenta resolver la consigna guiándote del apunte de la unidad.

# Una vez que hayas conseguido consumir el endpoint de la api de chistes que retorna un chiste aleatorio puedes continuar creando más endpoints en tu controlador para consumir otros endpoints que la api cliente de chistes ofrece. (Deberás orquestar todo entre JokesController, JokeService y su interfaz).

# (NOTA: para poder inyectar y utilizar la interfaz IHttpClientFactory en la capa de infraestructura deberás instalar el paquete nuget Microsoft.Extensions.Http en alguna versión compatible con .NET 8;

# Archivos a completar:
    - ExampleClientAPI.Application.Models.JokeDTO.cs
    - ExampleClientAPI.Application.Interfaces.IJokeService.cs
    - ExampleClientAPI.Infrastructure.Services.JokeService.cs
    - ExampleClientAPI.Presentation.Controllers.JokesController.cs
    - ExampleClientAPI.Presentation.Program.cs
