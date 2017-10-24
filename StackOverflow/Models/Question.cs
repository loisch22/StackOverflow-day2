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
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }


        [Key]
        public int QuestionId { get; set; }
        public string Topic { get; set; }
        public string QuestionDescription { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public override bool Equals(System.Object otherQuestion)
        {
            if (!(otherQuestion is Question))
            {
                return false;
            }
            else
            {
                Question newQuestion = (Question)otherQuestion;
                return this.QuestionId.Equals(newQuestion.QuestionId);
            }
        }
        public override int GetHashCode()
        {
            return this.QuestionId.GetHashCode();
        }
    }
}