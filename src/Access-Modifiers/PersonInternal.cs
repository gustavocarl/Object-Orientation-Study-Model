namespace Acess_Modifiers
{
    public class PersonInternal
    {
        internal PersonInternal(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        internal string FirstName { get; set; }

        internal string LastName { get; set; }

        internal string Email { get; set; }

        internal string PhoneNumber { get; set; }

        internal string PrintName(PersonInternal person)
        {
            return $"Primeiro Nome: {person.FirstName} \n" +
                $"Sobrenome: {person.LastName} \n" +
                $"Email: {person.Email} \n" +
                $"Telefone: {person.PhoneNumber}";
        }
    }
}