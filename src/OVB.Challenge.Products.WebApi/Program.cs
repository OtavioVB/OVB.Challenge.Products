
namespace OVB.Challenge.Products.WebApi;

public partial class Program
{
    public Program(){}

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}
