using SD.pesel;

public class PersonIdTests
{
    [Theory]
    [InlineData("44051401359", 1944)]
    [InlineData("00272375862", 2000)]
    public void GetYear_ShouldReturnCorrectYear(string pesel, int expectedYear)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var year = personId.GetYear();

        // Assert
        Assert.Equal(expectedYear, year);
    }

    [Theory]
    [InlineData("44051401359", 5)]
    public void GetMonth_ShouldReturnCorrectMonth(string pesel, int expectedMonth)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var month = personId.GetMonth();

        // Assert
        Assert.Equal(expectedMonth, month);
    }

    [Theory]
    [InlineData("44051401359", 14)]
    public void GetDay_ShouldReturnCorrectDay(string pesel, int expectedDay)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var day = personId.GetDay();

        // Assert
        Assert.Equal(expectedDay, day);
    }

    [Theory]
    [InlineData("44051401359", 90)]
    [InlineData("07291495676", 17)]
    public void GetYearOfBirth_ShouldReturnCorrectAge(string pesel, int expectedAge)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var age = personId.GetAge();

        // Assert
        Assert.Equal(expectedAge, age);
    }

    [Theory]
    [InlineData("44051401369", "m")]
    [InlineData("01260389836", "k")]
    public void GetGender_ShouldReturnCorrectGender(string pesel, string expectedGender)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var gender = personId.GetGender();

        // Assert
        Assert.Equal(expectedGender, gender);
    }

    [Theory]
    [InlineData("44051401359", true)]
    [InlineData("85050866897", true)]
    [InlineData("12345678901", false)]
    public void IsValid_ShouldReturnCorrectValidity(string pesel, bool expectedValidity)
    {
        // Arrange
        var personId = new PersonId(pesel);

        // Act
        var isValid = personId.IsValid();

        // Assert
        Assert.Equal(expectedValidity, isValid);
    }
}
