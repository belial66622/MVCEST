using Test.Boot;
using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using MVCEST.Scene.Game.LevelSelections;
using MVCEST.Scene.Game.Questions;
using MVCEST.Scene.Game.Scores;
using MVCEST.Scene.Game.Timer;

namespace Test.Scene.Game
{
    public class IdleLauncher : SceneLauncher<IdleLauncher, IdleView>
    {
        public override string SceneName { get { return "Game"; } }

        private LevelSelectionController _levelSelection;
        private QuestionController _question;
        private ScoreController _score;
        private TimerController _timer;

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new LevelSelectionController(),
                new QuestionController(),
                new ScoreController(),
                new TimerController()
            };
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new IdleConnector()
            };
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.Init(SceneName, BackToHome, Restart);
            _levelSelection.SetView(_view.LevelSelection);
            _question.SetView(_view.Question);
            _score.SetView(_view.Score);
            _timer.SetView(_view.Timer);

            yield return null;
        }

        private void BackToHome()
        {
            SceneLoader.Instance.LoadScene("Menu");
        }

        private void Restart()
        {
            SceneLoader.Instance.RestartScene();
        }
    }
}
