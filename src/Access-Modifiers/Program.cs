using AccessModifiers;
using Acess_Modifiers;

Console.WriteLine("Modificadores de acesso: ");

Console.WriteLine("Public");

var person = new PersonPublic("Gustavo Henrique", "Carl Dos Santos", "gustavo_carl@hotmail.com", "(16) 99760-5799");

person.FirstName = "Gustavo";

Console.WriteLine(person.PrintPerson(person));

Console.WriteLine("\n");

Console.WriteLine("Internal");

var personInternal = new PersonInternal("Gustavo Henrique", "Carl Dos Santos", "gustavo_carl@hotmail.com", "(16) 99760-5799");

Console.WriteLine(personInternal.PrintName(personInternal));

Console.WriteLine("\n");

Console.WriteLine("Protected");

var personProtected = new PersonProtected("Gustavo Henrique", "Carl Dos Santos", "gustavo_carl@hotmail.com", "(16) 99760-5799");

Console.WriteLine(personProtected.PrintPerson(personProtected));

Console.WriteLine("\n");

Console.WriteLine("Private");

var personPrivate = new PersonPrivate();

personPrivate.SetFirstName("Gustavo Henrique");
personPrivate.SetLastName("Carl Dos Santos");
personPrivate.SetEmail("gustavo_carl@hotmail.com");
personPrivate.SetPhoneNumber("(16) 99760-5799");

Console.WriteLine($"Nome: {personPrivate.GetFirstName()} \n" +
    $"Sobrenome: {personPrivate.GetLastName()} \n" +
    $"Email: {personPrivate.GetEmail()} \n" +
    $"Telefone: {personPrivate.GetPhoneNumber()}");

Console.WriteLine("\n");

Console.WriteLine("Private Protected");

var personPrivateProtected = new PersonPrivateProtected();

personPrivateProtected.SetFirstName("Gustavo Henrique");
personPrivateProtected.SetLastName("Carl Dos Santos");
personPrivateProtected.SetEmail("gustavo_carl@hotmail.com");
personPrivateProtected.SetPhoneNumber("(16) 99760-5799");

Console.WriteLine($"Nome: {personPrivateProtected.GetFirstName()} \n" +
    $"Sobrenome: {personPrivateProtected.GetLastName()} \n" +
    $"Email: {personPrivateProtected.GetEmail()} \n" +
    $"Telefone: {personPrivateProtected.GetPhoneNumber()}");

Console.WriteLine("\n");

Console.WriteLine("Protected Internal");

var personProtectedInternal = new PersonProtectedInternal();

personProtectedInternal.FirstName = "Gustavo Henrique";
personProtectedInternal.LastName = "Carl Dos Santos";
personProtectedInternal.Email = "gustavo_carl@hotmail.com";
personProtectedInternal.PhoneNumber = "(16) 99760-5799";

Console.WriteLine($"Nome: {personProtectedInternal.FirstName} \n" +
    $"Sobrenome: {personProtectedInternal.LastName} \n" +
    $"Email: {personProtectedInternal.Email} \n" +
    $"Telefone: {personProtectedInternal.PhoneNumber}");