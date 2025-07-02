namespace TestApp;

public class PasswordValidator
{
    public static string CheckPassword(string password)
    {
        bool isLengthValid = ValidatePasswordLength(password);
        bool isTextValid = ValidatePasswordText(password);
        bool isDigitsValid = ValidatePasswordDigits(password);

        if (!isLengthValid)
        {
            return "Password must be between 6 and 10 characters";
        }

        if (!isTextValid)
        {
            return "Password must consist only of letters and digits";
        }

        if (!isDigitsValid)
        {
            return "Password must have at least 2 digits";
        }

        return "Password is valid";
    }

    private static bool ValidatePasswordLength(string pass)
    {
        return pass.Length is >= 6 and <= 10;
    }

    private static bool ValidatePasswordText(string pass)
    {
        foreach (char c in pass)
        {
            bool checker = char.IsLetterOrDigit(c);
            if (!checker)
            {
                return false;
            }
        }

        return true;
    }

    private static bool ValidatePasswordDigits(string pass)
    {
        int digitCount = 0;
        foreach (char c in pass)
        {
            bool checker = char.IsDigit(c);
            if (checker)
            {
                digitCount++;
            }

            if (digitCount >= 2)
            {
                return true;
            }
        }

        return false;
    }
}
