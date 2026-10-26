using Dapper;

public class  PersonaRepo{
    
    private readonly ICrearConexion _conexion;


    public PersonaRepo(ICrearConexion conexion)
    {
        _conexion = conexion;
    }

    public async Task<IEnumerable<Persona>> todas()
    {
        using var db = _conexion.conexion();

        const string sql = "SELECT * FROM Personas";
        return  await db.QueryAsync<Persona>(sql);
    }


}
