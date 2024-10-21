namespace SD.pesel;

public class PersonId
{
    private readonly string _id;
    DateTime data = System.DateTime.Today;
    int bornYear;

    public PersonId(string Id)
    {
        _id = Id;

    }
    /// <summary>
    /// Get full year from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetYear()
    {

        int century = 20;
        string id = _id;
        if (int.Parse(id.Substring(2, 2)) <= 12)
        {
            century = 19;
        }
        bornYear = int.Parse(century + id.Substring(0, 2));
        return bornYear;
    }
    /// <summary>
    /// Get month from PESEL
    /// </summary>
    public int GetMonth()
    {
        
        string monthPart = _id.Substring(2, 2);
        int monthInt = int.Parse(monthPart);

        
        int year = GetYear();
        if (year >= 2000)
        {
            monthInt -= 20; 
        }

        return monthInt;
    }

    /// <summary>
    /// Get day from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetDay()
    {
        string id = _id;
        string result = id.Substring(startIndex: 4, length: 2);
        int resultInt = int.Parse(result);

        return resultInt;
    }

    /// <summary>
    /// Get year of birth from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetAge()
    {
        int currentYear = data.Year;
        return currentYear - bornYear;

    }
    /// <summary>
    /// Get gender from PESEL
    /// </summary>
    /// <returns>m</returns>
    /// <returns>f</returns>
    public string GetGender()
    {
        int genderDigit = int.Parse(_id.Substring(9, 1));
        return genderDigit % 2 == 0 ? "k" : "m";
    }

    /// <summary>
    /// check if PESEL is valid
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        int sum = 0;
        int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        for (int i = 0; i < 10; i++)
        {
            sum += (int)(_id[i] - '0') * weights[i];
        }

        int controlDigit = (10 - (sum % 10)) % 10;

        return controlDigit == (_id[10] - '0');
    }
    
}