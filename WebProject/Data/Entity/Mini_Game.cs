using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Data.Entity
{
    public class Mini_Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
      
        
        /*public Contora Contora { get; set; }
        public int Contora_id { get; set; }
        public Client Client { get; set; }
        public int Client_id { get; set; }*/
    }
}
