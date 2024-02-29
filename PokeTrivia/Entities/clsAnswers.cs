using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsAnswers
    {
        #region atributes
        private int id;
        private string answer;
       
     
        #endregion

        #region constructors
        public clsAnswers()
        {
            id = 0;
            answer=string.Empty;
           
        }

        public clsAnswers(int id, string answer)
        {
            this.id = id;
            this.answer = answer;
            
        }

        public clsAnswers(clsAnswers a)
        {
            this.id = a.id;
            this.answer=a.answer;
           

        }
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

     
        #endregion

    }
}
