/*CodeFirst yaklaşımını test etme amaçlı kodlar. Projenin son halinde bir işlevleri yok.*/

namespace WebSitesi.Models.Entities
{
    public class House
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Resident Owner { get; set; }
    }
}
