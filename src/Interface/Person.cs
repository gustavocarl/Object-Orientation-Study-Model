namespace Interface;

public class Person : IPerson
{
    public Person(string firstName, string lastName, string email, int age, string telephoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        TelephoneNumber = telephoneNumber;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string TelephoneNumber { get; set; }

    public bool IsAdult(int age)
    {
        if (age < 18)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string PrintPerson()
    {
        return $"Nome: {FirstName}\n" +
            $"Sobrenome: {LastName}\n" +
            $"Email: {Email}\n" +
            $"Idade: {Age}\n" +
            $"Telefone: {TelephoneNumber}";
    }
}