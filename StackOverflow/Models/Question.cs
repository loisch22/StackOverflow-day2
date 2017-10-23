using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace StackOverflow.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get;}
        public string Topic { get; set; }
        public string QuestionDescription { get; set; }
        public virtual int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}