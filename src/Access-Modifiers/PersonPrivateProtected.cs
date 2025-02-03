namespace AccessModifiers;

public class PersonPrivateProtected
{
    protected string _firstName;

    protected string _lastName;

    protected string _email;

    protected string _phoneNumber;

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