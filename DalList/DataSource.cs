using DalFacade.DO;
using DalFacade.DalApi;

namespace Dal
{
    internal static class DataSource
    {
        internal static List<Question?> Questions = new List<Question>();
        internal static List<Answer?> Answers = new List<Answer>();
        internal static List<Student?> Students = new List<Student>();
        internal static List<Test?> Tests = new List<Test>();
        internal static List<StudentQuestion?> StudentQuestions = new List<StudentQuestion>();





        internal static class Config
        {
            //student
            internal const int StudentId = 10;
            private static int _studentId = StudentId;
            internal static int NextStudent => _studentId++;


            //question
            internal const int QuestionId = 1;
            private static int _questionId = QuestionId;
            internal static int NextQuestion => _questionId++;




            //test
            internal const int TestId = 100;
            private static int _testId = TestId;
            internal static int NextTest => _testId++;




            //answer
            internal const int AnswerId = 1;
            private static int _answerId = AnswerId;
            internal static int NextAnswer => _answerId++;



            //student question
            internal const int StudentQuestionId = 99;
            private static int _studentQuestionId = StudentQuestionId;
            internal static int NextStudentQuestion => _studentQuestionId++;

            public static int NextTestId { get; internal set; }
        }
    }
}

