using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
   public record Question
    (
    int Id ,
    ExamTopicQuestion Topic,
      string QuestionContent,    
    int CorrectAnswerId
    )
    {
        public Question() : this(0, default, string.Empty, 0) { }
    }
}
