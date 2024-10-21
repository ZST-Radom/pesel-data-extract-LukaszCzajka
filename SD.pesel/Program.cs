// See https://aka.ms/new-console-template for more information

using SD.pesel;

Console.WriteLine("Wprowadź numer PESEL:");

string id = Console.ReadLine();

PersonId personId = new PersonId(id);

bool isValid = personId.IsValid();

if (isValid)
{
    int day = personId.GetDay();
    int month = personId.GetMonth();
    int year = personId.GetYear();
    string gender = personId.GetGender();
    int age = personId.GetAge();

    Console.WriteLine($"PESEL jest poprawny. Data urodzenia: {day}.{month}.{year} płeć: {gender}, masz: {age} lat.");
}
else
{
    Console.WriteLine("PESEL jest niepoprawny");
}

