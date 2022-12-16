using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Data.Entity
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date_birthday { get; set; }
        public DateTime Date_registration { get; set; }
        public int Seria { get; set; }
        public int Nomer { get; set; }
    }
}
