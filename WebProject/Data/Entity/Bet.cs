using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Data.Entity
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }
        public int Summ { get; set; }
        public DateTime Date_bet { get; set; }
        public double Coef { get; set; }
        public string StatusBet { get; set; }

    }
}
