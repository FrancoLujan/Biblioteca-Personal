using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.Sqlite;
public class Conexion:ICrearConexion
{
    
    private readonly string _connectionString;

    public Conexion(IConfiguration connectionString)
    {     // LA CADENA QUE RECIBE ES LA QUE ESTA EN EL APPSETTINGS.JSON
        _connectionString = connectionString.GetConnectionString("MiBaseDeDatos") ??
        throw new ArgumentNullException("NO ENCONTRO LA CADENA");
    }
   



    // devolvemos la intancia de la conexion a la base de datos
    public IDbConnection conexion()
    {
        return new SqliteConnection(_connectionString);
    }
}