public class Menu 
{
    private PersonaServicio _personaServicio;
    public Menu(PersonaServicio personaServicio)
    {
        _personaServicio = personaServicio;
    }
    public void mostrarMenu(){    

        while (true)
        {
            
            Console.WriteLine("BIBLIOTECA PERSONAL");
            Console.WriteLine("1. mostrar personas: 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    this._personaServicio.mostrarPersonas().Wait(); // Wait hace el hilo bloqueante hasta que la tarea se complete
                    break;
                case "2":
                    // Lógica para la opción 2
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
        
    }

    
}