using System;
using System.Collections.Generic;
using System.Text;
using DalFacade.DalApi;

namespace Dal
{
    public class DalList : IDal
    {
        public IQuestion Questions => new QuestionImplementation();

        public ITest Tests => new TestImplementation();
        public IAnswer Answers => new AnswerImplementation();

        public IStudent Students => new StudentImplementation();
        public IStudentQuestion StudentQuestions => new StudentQuestionImplementation();
    }
}