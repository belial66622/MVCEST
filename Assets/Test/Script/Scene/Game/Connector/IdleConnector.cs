using Agate.MVC.Base;
using MVCEST.Scene.Game.Questions;
using MVCEST.Scene.Game.Scores;
using MVCEST.Scene.Game.Timer;

namespace Test.Scene.Game
{
    public class IdleConnector : BaseConnector
    {
        private ScoreController _score;
        private QuestionController _question;
        private TimerController _timer;

        protected override void Connect()
        {
            Subscribe<LevelSelectMessage>(SelectLevel);
            Subscribe<QuestionAnswerMessage>(QuestionAnswer);
            Subscribe<LevelEndMessage>(GameEnd);
        }

        protected override void Disconnect()
        {
            Unsubscribe<LevelSelectMessage>(SelectLevel);
            Unsubscribe<QuestionAnswerMessage>(QuestionAnswer);
            Unsubscribe<LevelEndMessage>(GameEnd);
        }

        private void SelectLevel(LevelSelectMessage message)
        {
            _question.SetLevel(message.Value);
            _timer.StartTimer();
        }

        private void QuestionAnswer(QuestionAnswerMessage message)
        {
            _score.AddScore(message.Value);
        }

        private void GameEnd(LevelEndMessage message)
        {
            _question.GameEnd();
        }
    }
}
