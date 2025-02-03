namespace AccessModifiers;

public class PersonPublic
{
    public PersonPublic(string firstName, string lastName, string email, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string PrintPerson(PersonPublic person)
    {
        return $"Nome: {person.FirstName} \n" +
            $"Sobrenome: {person.LastName} \n" +
            $"Email: {person.Email} \n" +
            $"Telefone: {person.PhoneNumber}";
    }
}