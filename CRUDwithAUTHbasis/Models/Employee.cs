using Microsoft.EntityFrameworkCore;

namespace CRUDwithAUTHbasis.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int salary { get; set; }
    }
}
