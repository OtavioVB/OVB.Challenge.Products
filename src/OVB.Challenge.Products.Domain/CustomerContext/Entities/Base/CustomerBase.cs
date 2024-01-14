using OVB.Challenge.Products.Domain.CustomerContext.ENUMs;

namespace OVB.Challenge.Products.Domain.CustomerContext.Entities.Base;

public abstract class CustomerBase
{
    protected readonly TypeCustomer _typeCustomer;

    protected CustomerBase(TypeCustomer typeCustomer)
    {
        _typeCustomer = typeCustomer;
    }

    public static CustomerBase BuildCustomerAccordingToHisType(TypeCustomer typeCustomer)
    {
        switch (typeCustomer)
        {
            case TypeCustomer.Standard:
                throw new NotImplementedException();
            default:
                throw new NotImplementedException();
        }
    }
}
