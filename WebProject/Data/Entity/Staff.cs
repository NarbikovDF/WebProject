using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Data.Entity
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Staff_name { get; set; }
        public string Staff_surname { get; set; }
        public string Phone_number { get; set; }


     /* public Contora Contora { get; set; }
        public int Contora_id { get; set; }
        public ICollection<Bet> Bets { get; set; } */
    }
}
