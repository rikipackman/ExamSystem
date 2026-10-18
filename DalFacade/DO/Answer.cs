using System;
using System.Collections.Generic;
using System.Text;

namespace DalFacade.DO
{
    public record Answer
    (
        int Id,
        int QuestionId,
        string Content
    )
    {
        public Answer() : this(0, 0, string.Empty) { }

    }
}
