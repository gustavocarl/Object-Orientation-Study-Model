namespace AccessModifiers;

public class PersonProtected
{
    public PersonProtected(string firstName, string lastName, string email, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    protected string FirstName { get; set; }

    protected string LastName { get; set; }

    protected string Email { get; set; }

    protected string PhoneNumber { get; set; }

    public string PrintPerson(PersonProtected person)
    {
        return $"Nome: {FirstName} \n" +
            $"Sobrenome: {LastName} \n" +
            $"Email: {Email} \n" +
            $"Telefone: {PhoneNumber}";
    }
}