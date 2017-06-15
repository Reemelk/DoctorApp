using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Models
{
    class Patient : BaseModel
    {
        public Patient()
        {
            Reports = new List<Report>();
        }

        [StringLength(3)]
        public string Civility { get; set; }

        [Required]
        [StringLength(100)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(100)]
        public string Firstname { get; set; }

        public DateTime DOB { get; set; }

        public string Fullname => Lastname + " " + Firstname;

        public virtual ICollection<Report> Reports { get; set; }
    }
}
