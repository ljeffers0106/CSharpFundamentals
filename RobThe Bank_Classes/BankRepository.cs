using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobTheBank_Classes
{
    public class BankRepository
    {
        // protected - can only access ?
        protected readonly List<Questions> _questionList = new List<Questions>();
        // protected - can only access ?

        protected readonly List<Responses> _responseList = new List<Responses>();

        //CRUD
        public void AddQuestionsToList(Questions content)
        {
            _questionList.Add(content);

        }
        public void AddResponseToList(Responses content)
        {
            _responseList.Add(content);

        }
        public Questions GetQuestionByNumber(int number)
        {
            foreach (Questions content in _questionList)
            {
                if (content.Question == number)
                {
                    return content;
                }

            }
            return null;
        }
        public Responses GetResponsesByNumber(string selection)
        {
            foreach (Responses content in _responseList)
            {
                if (content.Answer == selection)
                {
                    return content;
                }

            }
            return null;
        }
    }
}
