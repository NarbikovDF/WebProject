using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Data.Entity
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_event { get; set; }


        /*public Vid_sporta Vid_sporta { get; set; }
        public int Vid_sporta_id { get; set; } */
    }
}
