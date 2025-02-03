namespace AccessModifiers;

public class PersonPrivate
{
    private string _firstName;

    private string _lastName;

    private string _email;

    private string _phoneNumber;

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string SetFirstName(string firstName)
    {
        return _firstName = firstName;
    }

    public string SetLastName(string lastName)
    {
        return _lastName = lastName;
    }

    public string SetEmail(string email)
    {
        return _email = email;
    }

    public string SetPhoneNumber(string phoneNumber)
    {
        return _phoneNumber = phoneNumber;
    }
}