using System.Data.Common;
using Dal;
using DalFacade.DalApi;
using DalFacade.DO;

    namespace DalTest
    {
    public static class Initialization
    {

        private static IDal s_dal;

        public static void createTest()
        {
            s_dal.Tests.Create(new Test(0, ExamTopicTest.MATH, new DateTime(2027, 10, 12), 10));
            s_dal.Tests.Create(new Test(0, ExamTopicTest.ENGLISH, new DateTime(2027, 8, 23), 10));
            s_dal.Tests.Create(new Test(0, ExamTopicTest.GEOGRAPHY, new DateTime(2027, 7, 30), 10));
            s_dal.Tests.Create(new Test(0, ExamTopicTest.GRAMMAR, new DateTime(2027, 9, 5), 10));
            s_dal.Tests.Create(new Test(0, ExamTopicTest.TECHNOLOGY, new DateTime(2027, 6, 25), 10));
        }

        public static void createAnswer()
        {
            s_dal.Answers.Create(new Answer(0, 1, "A"));
            s_dal.Answers.Create(new Answer(0, 2, "B"));
            s_dal.Answers.Create(new Answer(0, 3, "C"));
            s_dal.Answers.Create(new Answer(0, 4, "D"));
            s_dal.Answers.Create(new Answer(0, 5, "E"));
            s_dal.Answers.Create(new Answer(0, 6, "F"));
            s_dal.Answers.Create(new Answer(0, 7, "G"));
            s_dal.Answers.Create(new Answer(0, 8, "H"));
            s_dal.Answers.Create(new Answer(0, 9, "I"));
            s_dal.Answers.Create(new Answer(0, 10, "J"));
            s_dal.Answers.Create(new Answer(0, 11, "K"));
            s_dal.Answers.Create(new Answer(0, 12, "L"));
            s_dal.Answers.Create(new Answer(0, 13, "M"));
            s_dal.Answers.Create(new Answer(0, 14, "N"));
            s_dal.Answers.Create(new Answer(0, 15, "O"));
            s_dal.Answers.Create(new Answer(0, 16, "P"));
            s_dal.Answers.Create(new Answer(0, 17, "Q"));
            s_dal.Answers.Create(new Answer(0, 18, "R"));
            s_dal.Answers.Create(new Answer(0, 19, "S"));
            s_dal.Answers.Create(new Answer(0, 20, "T"));
        }

        public static void createStudent()
        {

            // מבחן מזהה 1 (MATH)
            s_dal.Students.Create(new Student(301111111, "John Smith", 1, 90));
            s_dal.Students.Create(new Student(301111112, "Emma Johnson", 1, 85));
            s_dal.Students.Create(new Student(301111113, "Michael Brown", 1, 78));
            s_dal.Students.Create(new Student(301111114, "Sarah Davis", 1, 92));
            s_dal.Students.Create(new Student(301111115, "David Wilson", 1, 88));

            // מבחן מזהה 2 (ENGLISH)
            s_dal.Students.Create(new Student(302222221, "James Miller", 2, 95));
            s_dal.Students.Create(new Student(302222222, "Jessica Taylor", 2, 84));
            s_dal.Students.Create(new Student(302222223, "Daniel Anderson", 2, 91));
            s_dal.Students.Create(new Student(302222224, "Ashley Thomas", 2, 76));
            s_dal.Students.Create(new Student(302222225, "Matthew Jackson", 2, 89));

            // מבחן מזהה 3 (GEOGRAPHY)
            s_dal.Students.Create(new Student(303333331, "Joshua White", 3, 82));
            s_dal.Students.Create(new Student(303333332, "Amanda Harris", 3, 94));
            s_dal.Students.Create(new Student(303333333, "Andrew Martin", 3, 87));
            s_dal.Students.Create(new Student(303333334, "Megan Clark", 3, 90));
            s_dal.Students.Create(new Student(303333335, "Ryan Lewis", 3, 83));

            // מבחן מזהה 4 (GRAMMAR)
            s_dal.Students.Create(new Student(304444441, "Nicholas Robinson", 4, 86));
            s_dal.Students.Create(new Student(304444442, "Nicole Walker", 4, 93));
            s_dal.Students.Create(new Student(304444443, "Brandon Young", 4, 79));
            s_dal.Students.Create(new Student(304444444, "Samantha Allen", 4, 95));
            s_dal.Students.Create(new Student(304444445, "Tyler King", 4, 88));

            // מבחן מזהה 5 (TECHNOLOGY)
            s_dal.Students.Create(new Student(305555551, "Justin Wright", 5, 98));
            s_dal.Students.Create(new Student(305555552, "Rachel Scott", 5, 91));
            s_dal.Students.Create(new Student(305555553, "Christian Green", 5, 84));
            s_dal.Students.Create(new Student(305555554, "Lauren Baker", 5, 90));
            s_dal.Students.Create(new Student(305555555, "Ethan Adams", 5, 92));

        }
        public static void createQuestion()
        {
            // --- אתחול שאלות למערכת (לפחות 20 שאלות בנושאים שונים) ---
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "מהו שורש המספר 144?", 1));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "פתור את המשוואה: 3x + 6 = 15", 2));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "מהו הערך של 15 אחוז מתוך 200?", 3));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "מהו הערך של הפאי מעוגל לשני מקומות אחרי הנקודה?", 4));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "כמה זה 7 כפול 8?", 5));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "כמה זה 50 חלקי 5?", 6));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.MATH, "מהי תוצאת החזקה 9 בריבוע?", 7));

            // שאלות באנגלית 
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "What is the past tense of the verb 'run'?", 8));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "Complete the sentence: She ___ to the store yesterday.", 9));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "What is a synonym for the word 'happy'?", 10));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "What is the opposite of the word 'ancient'?", 11));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "Spell the plural form of the noun 'dictionary'.", 12));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.ENGLISH, "What is the antonym of 'difficult'?", 13));

            // שאלות בטכנולוגיה 
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "מה ראשי התיבות של המונח CPU?", 14));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "איזה מבנה נתונים פועל לפי עיקרון נכנס ראשון יוצא ראשון (FIFO)?", 15));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "מהו סיומת קבצי קוד מקור בשפת C#?", 16));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "מה ראשי התיבות של זיכרון ה-RAM?", 17));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "איזה פרוטוקול משמש בעיקר לאבטחת אתרי אינטרנט?", 18));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "מה ראשי התיבות של שפת המסדי נתונים SQL?", 19));
            s_dal.Questions.Create(new Question(0, ExamTopicQuestion.TECHNOLOGY, "איזה רכיב נחשב ל'מוח' של המחשב?", 20));
        }
    }
    }
