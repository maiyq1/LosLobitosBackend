using Infraestructure.Context;
using Infraestructure.Models;

namespace Infraestructure;

public class ServiceExaminarInfraestructure : IServiceInfraestructure
{
    private GeniusDBContext _geniusDbContext;

    public ServiceExaminarInfraestructure(GeniusDBContext geniusDbContext)
    {
        _geniusDbContext = geniusDbContext;
    }
    
    public List<Service> GetAll()
    {
        return _geniusDbContext.Service.ToList();
    }
}