

namespace DO
{
   public record Student
    (
        int Id,
        String Name,
        int ExamID,
        int Grade
   )
    {
       public Student() : this(0, string.Empty, 0, 0) { }
    }
}
