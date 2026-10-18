using System;
using System.Collections.Generic;
using System.Text;

namespace DalFacade.DO
{
    public record Question
    (
        int Id,
        ExamTopicQuestion Topic,
        string QuestionContent,
        int CorrectAnswerId
    )
    {
    public Question() : this(0, default, string.Empty, 0) { }


    }
}
