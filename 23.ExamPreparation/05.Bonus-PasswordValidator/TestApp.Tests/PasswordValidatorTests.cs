using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        // Arrange
        string password = "Angel123";
        string expected = "Password is valid";

        // Act
        string result = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("An")]
    [TestCase("An123")]
    [TestCase("Angel123456")]
    [TestCase("Anjkdsfhsdifsdy123")]
    public void Test_CheckPassword_PasswordTooShortOrTooLong_ReturnsErrorMessage(string password)
    {
        // Arrange
        //string password = "An123";
        string expected = "Password must be between 6 and 10 characters";

        // Act
        string result = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Ana#23")]
    [TestCase("Ana$567")]
    [TestCase("Ana*23")]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage(string password)
    {
        // Arrange
        //string password = "Ana#23";
        string expected = "Password must consist only of letters and digits";

        // Act
        string result = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        // Arrange
        string password = "Angel3";
        string expected = "Password must have at least 2 digits";

        // Act
        string result = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        // Arrange
        string password = "Angel12345"; // exact 10 characters
        string expected = "Password is valid";

        // Act
        string result = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
