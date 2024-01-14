namespace OVB.Challenge.Products.WebApi.Controllers.Payloads;

public readonly struct HttpPostImportCustomerPayloadInput
{
    public HttpPostImportCustomerPayloadInput(string name, string surname, DateTime birthDate)
    {
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
    }

    public string Name { get; init; }
    public string Surname { get; init; }
    public DateTime BirthDate { get; init; }
}
