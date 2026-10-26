using Dapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// confiracion de Dapper para evitar errores de mapeo 
DefaultTypeMap.MatchNamesWithUnderscores = true;


// esto para que tome el .json
// inyecta lo del json en Conexion
var builder = Host.CreateApplicationBuilder(args);

// INYECCION DE DEPENDENCIAS
// SINGLETON: una sola instancia de la FABRICA de conexiones durante toda la aplicacion.
builder.Services.AddSingleton<ICrearConexion, Conexion>();


// la crea cuando se necesita y la destruye cuando termina de usarla es para cada servicio o repo que necesite
// PENDIENTE PARA CREAR INTERFACE COMUN LLAMADA CRUD
builder.Services.AddTransient<PersonaRepo>();
builder.Services.AddTransient<PersonaServicio>();
builder.Services.AddTransient<Menu>();

using var app = builder.Build();


// el contenedor arma toda la cadena: Menu -> PersonaServicio -> PersonaRepo -> ICrearConexion
var menu = app.Services.GetRequiredService<Menu>();


// ejecuta el programa
menu.mostrarMenu();
