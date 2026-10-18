using DalFacade.DO;
using DalFacade.DalApi;

namespace Dal
{
    internal class TestImplementation : ITest
    {

        public int Create(Test item)
        {
            int newId = DataSource.Config.NextTestId;
            Test copy = item with { Id = newId }; // יצירת העתק עם המזהה הרץ החדש
            DataSource.Tests.Add(copy);
            return newId;
        }


        public Test? Read(int id)
        {
            return DataSource.Tests.FirstOrDefault(t => t?.Id == id);
        }

        public List<Test> ReadAll()
        {
            return DataSource.Tests.Where(t => t != null).Select(t => t!).ToList();
        }

        public void Update(Test item)
        {
            var existing = Read(item.Id);
            if (existing == null)
                throw new Exception($"מבחן עם מזהה {item.Id} לא קיים.");

            DataSource.Tests.Remove(existing);
            DataSource.Tests.Add(item);
        }

        public void Delete(int id)
        {
            var existing = Read(id);
            if (existing == null)
                throw new Exception($"מבחן עם מזהה {id} לא קיים.");

            DataSource.Tests.Remove(existing);
        }
    }
}