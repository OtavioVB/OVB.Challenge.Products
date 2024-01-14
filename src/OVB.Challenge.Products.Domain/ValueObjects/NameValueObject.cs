using OVB.Challenge.Products.NotificationContext;
using OVB.Challenge.Products.ProcessResultContext;

namespace OVB.Challenge.Products.Domain.ValueObjects;

public readonly struct NameValueObject
{
    public bool IsValid { get; }
    private string Name { get; }
    private ProcessResult<Notification> ProcessResult { get; }

    private NameValueObject(bool isValid, string name, ProcessResult<Notification> processResult)
    {
        IsValid = isValid;
        Name = name;
        ProcessResult = processResult;
    }

    public static NameValueObject Build(string name)
    {
        throw new NotImplementedException();
    }
}
