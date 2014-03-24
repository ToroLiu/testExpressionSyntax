using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEFExpress.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Data()
        {

        }
    }
}
