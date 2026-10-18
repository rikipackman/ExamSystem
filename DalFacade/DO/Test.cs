using System;
using System.Collections.Generic;
using System.Text;

namespace DalFacade.DO
{
    public record Test
    (
        int Id,
        ExamTopicTest ExamTopic,
        DateTime Date,
        int NumOfQuestions
    )
    {
        public Test() : this(0, default, default, 0) { }
    }

}