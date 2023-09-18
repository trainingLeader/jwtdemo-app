

namespace Domain.Entities;

public class Categoria:BaseEntity
{    
    public string Nombre { get; set; }
    public ICollection<Producto> Productos { get; set; }
}
