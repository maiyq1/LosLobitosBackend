namespace Infraestructure.Models;

public class Mechanic 
{
    public  int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }

    public  List<Service> Services { get; set; }
}