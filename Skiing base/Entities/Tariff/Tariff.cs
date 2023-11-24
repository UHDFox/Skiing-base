using System.ComponentModel.DataAnnotations;

namespace Skiing_base.Entities.Tariff
{
    public sealed class Tariff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
