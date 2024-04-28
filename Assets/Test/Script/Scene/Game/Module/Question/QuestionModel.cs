using Agate.MVC.Base;
using MVCEST.Script.Tools;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

namespace MVCEST.Scene.Game.Questions
{
    public interface IQuestionModel : IBaseModel
    {
        int FirstNumber { get; }
        int SecondNumber { get; }
        int AllNumber { get; }
        int Level { get; }
        int Operation { get; }
    }

    public class QuestionModel : BaseModel , IQuestionModel
    {
        public int FirstNumber { get; private set; } = 0;

        public int SecondNumber { get; private set; } = 0;

        public int AllNumber { get; private set; } = 0;

        public int Level { get; private set; } = 0;

        public int Operation { get; private set; } = 0;

        private int questionAnswer = 0; 

        private QuestionPick questionpick;

        private Question question;

        public int GetLevel()
        { 
            return Level;
        }

        public void SetLevel(int level)
        {
            Level = level ;
            questionpick = new QuestionPick(level);
            RenewQuestion();
            SetDataAsDirty();
        }

        public void SetNumber(int first, int second, int operation)
        { 
            FirstNumber= first ;
            SecondNumber = second ;
            Operation = operation;
            switch (operation)
            {
                case 1:
                    AllNumber = first - second;
                    break;
                default:
                    AllNumber = first + second;
                    break;
            }
            SetDataAsDirty();
        }

        public bool answer(int answer)
        {
            if (answer == AllNumber)
            { 
                return true ;
            }

            else return false ;
        }

        public int AddQuestion()
        {
            questionAnswer++;
            SetDataAsDirty();
            return questionAnswer;
        }


        public void RenewQuestion()
        {
            question = questionpick.GetQuestion();
            SetNumber(question.firstNumber,question.secondNumber,question.operation);
            SetDataAsDirty();
        }
    }
}