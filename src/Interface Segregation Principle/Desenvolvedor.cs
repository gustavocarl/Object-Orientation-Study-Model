namespace Interface_Segregation_Principle;

public class Desenvolvedor : Funcionario, IDesenvolvedor
{
    public void DesenvolverCodigo()
    {
        Console.WriteLine($"O Desenvolvedor {Name} está desenvolvendo um código");
    }

    public void RealizarCommits()
    {
        Console.WriteLine($"O Desenvolvedor {Name} está realizando commits");
    }
}