namespace Interface_Segregation_Principle;

public abstract class Funcionario : IFuncionario
{
    public string Name;

    public void RegistrarPonto()
    {
        Console.WriteLine($"O funcionário {Name} está registrando o ponto");
    }
}