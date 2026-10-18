using System;
using System.Collections.Generic;
using System.Text;

namespace DalFacade.DO
{
    public record Student
    (
        int Id,
        string Name,
        int TestId,
        int Score
    )
    {
        public Student() : this(0, string.Empty, 0, 0) { }
    }
}


