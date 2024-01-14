using OVB.Challenge.Products.Domain.CustomerContext.DataTransferObject;
using OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Repositories.Base;
using OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Repositories.Extensions;

namespace OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Repositories;

public sealed class CustomerRepository : BaseRepository<Customer>, IExtensionCustomerRepository
{
    public CustomerRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
