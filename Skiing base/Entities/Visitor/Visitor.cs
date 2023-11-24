using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities{
    public sealed class Visitor
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        [Phone] 
        public int phone { get; set; }
        public DateTime birthdate { get; set; }


    }
}