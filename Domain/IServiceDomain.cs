using Infraestructure.Models;

namespace Domain;

public interface IServiceDomain 
{
    public List<Service> GetAll();
}