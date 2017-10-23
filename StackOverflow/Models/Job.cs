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
        public int JobId { get; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public virtual int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
