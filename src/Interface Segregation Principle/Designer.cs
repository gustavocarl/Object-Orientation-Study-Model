namespace Interface_Segregation_Principle;

public class Designer : Funcionario, IDesigner
{
    public void CriarArtes()
    {
        Console.WriteLine($"O Designer {Name} está criando uma arte");
    }

    public void EditarImagens()
    {
        Console.WriteLine($"O Designer {Name} está editando uma imagem");
    }
}