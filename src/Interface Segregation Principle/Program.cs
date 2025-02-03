using Interface_Segregation_Principle;

Gerente gerente = new()
{
    Name = "José",
};

gerente.RegistrarPonto();
gerente.GerenciarFuncionarios();
gerente.AprovarRelatorios();

Console.WriteLine("\n");

Desenvolvedor desenvolvedor = new()
{
    Name = "Gustavo",
};

desenvolvedor.RegistrarPonto();
desenvolvedor.DesenvolverCodigo();
desenvolvedor.RealizarCommits();

Console.WriteLine("\n");

Designer designer = new()
{
    Name = "Naiara",
};

designer.RegistrarPonto();
designer.CriarArtes();
designer.EditarImagens();