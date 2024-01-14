using OVB.Challenge.Products.NotificationContext;
using OVB.Challenge.Products.ProcessResultContext;

namespace OVB.Challenge.Products.Domain.ValueObjects;

public readonly struct SurnameValueObject
{
    public bool IsValid { get; }
    private string Surname { get; }
    private ProcessResult<Notification> ProcessResult { get; }

    private SurnameValueObject(bool isValid, string surname, ProcessResult<Notification> processResult)
    {
        IsValid = isValid;
        Surname = surname;
        ProcessResult = processResult;
    }

    public static SurnameValueObject Build(string surname)
    {
        throw new NotImplementedException();
    }
}
