using Infraestructure.Context;
using Infraestructure.Models;

namespace Infraestructure;

public class ServicePintarInfraestructure : IServiceInfraestructure
{
    private GeniusDBContext _geniusDbContext;

    public ServicePintarInfraestructure(GeniusDBContext geniusDbContext)
    {
        _geniusDbContext = geniusDbContext;
    }
    
    public List<Service> GetAll()
    {
      return _geniusDbContext.Service.ToList();
    }
}