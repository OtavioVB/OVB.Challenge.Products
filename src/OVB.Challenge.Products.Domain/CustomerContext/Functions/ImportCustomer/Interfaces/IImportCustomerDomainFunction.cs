using OVB.Challenge.Products.Domain.CustomerContext.Functions.ImportCustomer.Inputs;
using OVB.Challenge.Products.Domain.CustomerContext.Functions.ImportCustomer.Outputs;
using OVB.Challenge.Products.NotificationContext;
using OVB.Challenge.Products.ProcessResultContext;

namespace OVB.Challenge.Products.Domain.CustomerContext.Functions.ImportCustomer.Interfaces;

public interface IImportCustomerDomainFunction
{
    public Task<ProcessResult<Notification, ImportCustomerDomainFunctionOutput>> ImportCustomerDomainFunctionAsync(
        ImportCustomerDomainFunctionInput input,
        CancellationToken cancellationToken);
}
