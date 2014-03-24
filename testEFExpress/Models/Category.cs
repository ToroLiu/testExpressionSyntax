using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEFExpress.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Index(IsUnique=true), MaxLength(120)]
        public string Name { get; set; }

        public virtual ICollection<Data> ContactSet { get; set; }

        public Category()
        {
            ContactSet = new HashSet<Data>();
        }
    }
}
