using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congratulation.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string Deprtment { get; set; }
        public int GenderId { get; set; }
        public int LocationId { get; set; }
        public string? ShortPath { get; set; }
        public string? ImagePath { get; set; }

    }
}
