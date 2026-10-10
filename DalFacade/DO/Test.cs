

namespace DO
{
    public record Test
     (
        int Id,
        ExamTopicTest ExamTopic,
        DateTime Date,
      int NumQuestion
     )
    {
        public Test() : this(0, default, default, 0) { }
    }
}
