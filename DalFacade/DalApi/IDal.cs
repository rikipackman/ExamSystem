

namespace DalFacade.DalApi
{
    public interface IDal
    {
        IQuestion Questions { get;}
        ITest Tests { get;}
        IAnswer Answers { get;}
        IStudent Students { get;}
        IStudentQuestion StudentQuestions { get;}
    }
}
