using DAL;
using Entities;
using Microsoft.AspNetCore.SignalR.Client;
using PokeTrivia.UI.Views;
using PokeTrivia.UI.VM.Utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrivia.UI.VM
{
    public class GamePlayVM:clsVMBase
    {
        #region atributos
        clsPlayer p1;
        clsPlayer p2;
        int countWins = 0;
        clsQuestions question;
        clsAnswers selectedAnswer;
        clsAnswers answer1;
        clsAnswers answer2;
        clsAnswers answer3;
        clsAnswers answer4;
        private DelegateCommand<clsAnswers> confirmsAnswer;
        int numQuestions = 10;
        List<clsQuestions> questionList;
        List<clsAnswers> answerList;

        private readonly HubConnection conn;

        #endregion

        #region constructors
        public GamePlayVM(clsPlayer player1, clsPlayer player2)
        {
            //hay que inicializar la conexión
            conn = new HubConnectionBuilder().WithUrl("http://localhost:5250/game").Build();

            conn.StartAsync();

            //recibir el nombre del otro jugador
            conn.On<clsPlayer>("ConectaCliente", (player) =>
            {
               player2= player;
            });



            getsData();
            this.p1 = player1;

            question = randomQuestion();
            randomAnswers();

            confirmsAnswer = new DelegateCommand<clsAnswers>(confirmsAnswerCanExecute);
        }
        public GamePlayVM (clsPlayer player, int countWins, int numQuestions)
        {
            getsData();
            p1 = player;
            this.countWins = countWins;
            this.numQuestions = numQuestions;
            question=randomQuestion();
            randomAnswers();
            
            confirmsAnswer = new DelegateCommand<clsAnswers>(confirmsAnswerCanExecute);
        }
        #endregion

        #region properties

        public clsPlayer P1
        {
            get { return p1; }
        }

        public clsPlayer P2
        {
            get { return p2; }
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
                NotifyPropertyChanged(nameof(selectedAnswer));
            }
        }
        public clsAnswers Answer1
        {
            get { return answer1; }
        }
        public clsAnswers Answer2
        {
            get { return answer2; }
        }

        public clsAnswers Answer3
        {
            get { return answer3; }
        }

        public clsAnswers Answer4
        {
            get { return answer4; }
        }

        public DelegateCommand<clsAnswers> ConfirmsAnswer
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
        private async void confirmsAnswerCanExecute( object param)
        {
            selectedAnswer=param as clsAnswers;
            
            if (question.Id==selectedAnswer.Id)
            {
                //TODO: paint button green
                //selectedAnswer.BtnColor = Color(KnownColor Green);
                countWins++;
               
               
                
            }
            else
            {
                //TODO: paint button red

                
            }

            numQuestions--;

            //TODO: calls function

            if (numQuestions == 0)
            {
                gameOver(countWins);

            }
            else
            {
                GamePlayVM vm = new GamePlayVM(p1, countWins, numQuestions);

                //this will take us to the next view
                await Shell.Current.Navigation.PushAsync(new GamePlay(vm));

            }

        }

        static async Task DelayAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
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

        private clsQuestions randomQuestion()
        {
            Random random = new Random();
            int randomIndex=0;

            if (numQuestions>0)
            {
                randomIndex= random.Next(questionList.Count);
            }

            return questionList[randomIndex];
 
  
        }

        private void randomAnswers()
        {
            Random random = new Random();
            List<clsAnswers>randomAnswersList= new List<clsAnswers>();
            clsAnswers rightAnswer= new clsAnswers();
            bool rightAnswerFound=false;
            int index = 0;

            //we must secure that the right answer is in there
            while (!rightAnswerFound&&index<answerList.Count)
            {
                if (answerList[index].Id==question.Id)
                {
                    randomAnswersList.Add(answerList[index]);
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
                randomAnswersList.Add(answerList[index]);
            }

            //we sort the list
            randomAnswersList.Sort((x, y) => random.Next(-1, 2));

            answer1 = randomAnswersList[0];
            answer2 = randomAnswersList[1];
            answer3 = randomAnswersList[2];
            answer4 = randomAnswersList[3];

            NotifyPropertyChanged(nameof(answer1));
            NotifyPropertyChanged(nameof(answer2));
            NotifyPropertyChanged(nameof(answer3));
            NotifyPropertyChanged(nameof(answer4));

        }

        public async void gameOver(int countWins)
        {
            if (countWins==10)
            {
                await App.Current.MainPage.DisplayAlert("Enhorabuena!!", "Has ganado", "Vale");

                Application.Current.Quit();
            
            } else
            {
                await App.Current.MainPage.DisplayAlert("Oh no", "No has llegado a los 10 puntos", "Sad");

                Application.Current.Quit();

            }
        }
        #endregion
    }
}
