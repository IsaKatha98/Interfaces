using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsQuestions
    {
        #region atributes
        private int id;
        private string question;
        private string img;
        #endregion

        #region constructors
        public clsQuestions()
        {
            id = 0;
            question = string.Empty;
            img = string.Empty;
        }

        public clsQuestions(int id, string question, string img)
        {
            this.id = id;
            this.question = question;
            this.img = img;
        }
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        public string Question{
            get { return question; }
            set { question = value; }

        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }
        #endregion

    }
}
