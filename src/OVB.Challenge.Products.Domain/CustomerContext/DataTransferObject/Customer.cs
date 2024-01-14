namespace OVB.Challenge.Products.Domain.CustomerContext.DataTransferObject;

public sealed record Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    private Customer(Guid id, string name, string surname, DateTime birthDate)
    {
        Id = id;
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
    }

    public static Customer Build(Guid id, string name, string surname, DateTime birthDate)
        => new Customer(id, name, surname, birthDate);
}
