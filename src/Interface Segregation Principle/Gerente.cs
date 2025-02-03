namespace Interface_Segregation_Principle;

public sealed class Gerente : Funcionario, IGerente
{
    public void AprovarRelatorios()
    {
        Console.WriteLine($"O Gerente {Name} está aprovando relatórios");
    }

    public void GerenciarFuncionarios()
    {
        Console.WriteLine($"O Gerente {Name} está gerenciando funcionários");
    }
}