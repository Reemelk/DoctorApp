using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Models
{
    class Report : BaseModel
    {
        public Report()
        {
            Medicines = new List<Medicine>();
        }

        [Required]
        [StringLength(150)]
        public string Disease { get; set; }

        [Required]
        [StringLength(255)]
        public string Treatment { get; set; }

        // Patient association
        public int PatientRefId { get; set; }

        [ForeignKey("PatientRefId")]
        public virtual Patient Patient { get; set; }

        public int ReportId { get; internal set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
