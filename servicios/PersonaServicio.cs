

public class PersonaServicio
{
    private readonly PersonaRepo _personaRepo;

    public PersonaServicio(PersonaRepo personaRepo)
    {
        _personaRepo = personaRepo;
    }

    public async Task mostrarPersonas()
    {
        var personas = await _personaRepo.todas();

        foreach (var persona in personas)
        {
            Console.WriteLine(persona.ToString());
        }
    }
}
