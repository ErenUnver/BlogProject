using System.ComponentModel.DataAnnotations;

namespace BlogAPI.DataAccsessLayer
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
