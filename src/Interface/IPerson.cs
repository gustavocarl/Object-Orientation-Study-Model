namespace Interface;

public interface IPerson
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int Age { get; set; }

    public string TelephoneNumber { get; set; }

    bool IsAdult(int age);

    string PrintPerson();
}