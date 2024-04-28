using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using Test.Scene.Game;
using Unity.VisualScripting;
using UnityEngine;

namespace MVCEST.Scene.Game.Questions
{
    public class QuestionController : ObjectController<QuestionController, QuestionModel , IQuestionModel , QuestionView>
    {
        public override void SetView(QuestionView view)
        {
            base.SetView(view);
            view.Init(Check);
        }



        private void Check(int answer)
        {
            if (answer == _model.AllNumber)
            {
                Publish(new QuestionAnswerMessage(1 * _model.GetLevel()));
            }
            else
            {
                Publish(new QuestionAnswerMessage(-1));
            }
            UpdateQuestion();
        }

        private void UpdateQuestion()
        {
            _model.RenewQuestion();
        }

        public void SetLevel(int level)
        { 
            _model.SetLevel(level);
            _view.InGameScreen();
        }

        public void GameEnd()
        {
            _view.GameOverScreen();
        }

    }
}