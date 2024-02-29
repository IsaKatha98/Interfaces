using DAL;
using Entities;
using PokeTrivia.UI.VM.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrivia.UI.VM
{
    public class GamePlayVM:clsVMBase
    {
        #region atributos
        string playerName;
        int countWins;
        clsQuestions question;
        clsAnswers selectedAnswer;
        string answer1;
        string answer2;
        string answer3;
        string answer4;
        DelegateCommand confirmsAnswer;
        int numQuestions = 10;
        List<clsQuestions> questionList;
        List<clsAnswers> answerList;
        #endregion

        #region constructors
        public GamePlayVM() {
            getsData();
            playerName = string.Empty;
            countWins = 0;
            question = null;

            confirmsAnswer = new DelegateCommand(confirmsAnswerCanExecute);
        }

        public GamePlayVM (clsPlayer player)
        {
            getsData();
            playerName = player.Name;
            countWins = 0;

            confirmsAnswer = new DelegateCommand(confirmsAnswerCanExecute);
            

        }
        #endregion

        #region properties
        public string PlayerName
        {
            get { return playerName;}
        }

        public int CountWins
        {
            get { return countWins;}
        }
        
        public clsQuestions Question
        {
            get { return question; }
        }

  
  
        public clsAnswers SelectedAnswer
        {
            get { return selectedAnswer;}
            set
            {
                selectedAnswer = value;
                NotifyPropertyChanged("SelectedAnswer");
            }
        }
        public string Answer1
        {
            get { return answer1; }
        }
        public string Answer2
        {
            get { return answer2; }
        }

        public string Answer3
        {
            get { return answer3; }
        }

        public string Answer4
        {
            get { return answer4; }
        }

        public DelegateCommand ConfirmsAnswer
        {
            get { return confirmsAnswer; }
        }

        public int NumQuestions
        {
            get { return numQuestions; }
        }
        
        public List<clsQuestions> QuestionList
        {
            get { return questionList; }
        }
        public List<clsAnswers> AnswerList
        {
            get { return answerList;}
        }
        #endregion

        #region commands
        private void confirmsAnswerCanExecute()
        {
            if (question.Id==selectedAnswer.Id)
            {
                //TODO: paint button green
            }
            else
            {
                //TODO: paint button red
            }

            //TODO: calls function
        }
        #endregion

        #region functions
        private void getsData()
        {
            questionList = clsListQuestions.FullListOfQuestion();
            NotifyPropertyChanged("QuestionList");
            answerList=clsListAnswers.FullListOfAnswers();
            NotifyPropertyChanged("AnswerList");
        }

        private void randomQestion()
        {
            Random random = new Random();
            int randomIndex=0;

            if (numQuestions>0)
            {
                randomIndex= random.Next(questionList.Count);
            }

            question = questionList[randomIndex];
            NotifyPropertyChanged("Question");
        }

        private void randomAnswers()
        {
            Random random = new Random();
            List<clsAnswers> randomAnswers = new List<clsAnswers>();
            clsAnswers rightAnswer= new clsAnswers();
            bool rightAnswerFound=false;
            int index = 0;

            //we must secure that the right answer is in there
            while (!rightAnswerFound&&index<answerList.Count)
            {
                if (answerList[index].Id==question.Id)
                {
                    randomAnswers.Add(answerList[index]);
                    rightAnswerFound = true;
                
                }
                else
                {
                    index++;
                }
            }

            //we need another three options.
            for (int i = 0; i <= 2; i++)
            {
                index = random.Next(answerList.Count);
                randomAnswers.Add(answerList[index]);
            }

            randomizeAnswersList(randomAnswers);

        }

        public void randomizeAnswersList(List<clsAnswers> randomAnswers)
        {
            //we sort the list
            randomAnswers.Sort();

            answer1 = randomAnswers[0].Answer;
            answer2 = randomAnswers[1].Answer;
            answer3 = randomAnswers[2].Answer;
            answer4 = randomAnswers[3].Answer;           
        }
        #endregion
    }
}
