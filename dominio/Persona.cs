public class Persona
{
    public int Id { get; private set; }
    public string Nombre { get; private set; } = string.Empty;

    public string Apellido { get; private set; } = string.Empty;

    // Dapper usa este constructor para materializar las filas;
    // escribe las propiedades aunque el set sea privado.
    public Persona()
    {
    }

    public Persona(int id, string nombre, string apellido)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
    }
    public void SetNombre(string nombre)
    {
        Nombre = nombre;
    }
    public void SetApellido(string apellido)
    {
        Apellido = apellido;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}";
    }
}
