using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace StackOverflow.Models
{
    [Table("Jobs")]
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public virtual ApplicationUser User { get; set; }

        public override bool Equals(System.Object otherJob)
        {
            if (!(otherJob is Job))
            {
                return false;
            }
            else
            {
                Job newJob = (Job)otherJob;
                return this.JobId.Equals(newJob.JobId);
            }
        }

        public override int GetHashCode()
        {
            return this.JobId.GetHashCode();
        }
    }
}
