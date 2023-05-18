using Infraestructure;
using Infraestructure.Models;

namespace Domain;

public class ServiceDomain :  IServiceDomain
{
    private IServiceInfraestructure _serviceInfraestructure;

    public ServiceDomain(IServiceInfraestructure serviceInfraestructure)
    {
        _serviceInfraestructure = serviceInfraestructure;
    }
    
    public List<Service> GetAll()
    {
        return _serviceInfraestructure.GetAll();
    }
}