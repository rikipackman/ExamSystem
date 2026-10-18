
using DalFacade.DalApi;
using DalFacade.DO;

namespace Dal
{
    internal class AnswerImplementation : IAnswer
    {

        public int Create(Answer item)
        {
            var toAdd = item with { Id = DataSource.Config.NextAnswer };
            DataSource.Answers.Add(toAdd);
            return toAdd.Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Answer? Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Answer item)
        {
            throw new NotImplementedException();
        }



    }
}
