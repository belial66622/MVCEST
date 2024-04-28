using Test.Boot;
using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using MVCEST.Scene.Game.LevelSelections;
using MVCEST.Scene.Game.Questions;
using MVCEST.Scene.Game.Scores;
using TMPro;
using MVCEST.Scene.Game.Timer;

namespace Test.Scene.Game
{
    public class IdleView : BaseSceneView
    {
        public LevelSelectionView LevelSelection { get { return _levelSelection; } }
        public QuestionView Question { get { return _question; } }

        public ScoreView Score { get { return _score; } }

        public TimerView Timer { get { return _timer; } }

        [SerializeField]
        private LevelSelectionView _levelSelection;
        [SerializeField]
        private QuestionView _question;
        [SerializeField]
        private ScoreView _score;
        [SerializeField]
        private TextMeshProUGUI _sceneName;
        [SerializeField]
        private Button _homeButton;
        [SerializeField]
        private Button _restartButton;
        [SerializeField]
        private TimerView _timer;

        public void Init(string sceneName, UnityAction onHome, UnityAction onRestart)
        {
            _sceneName.text = sceneName;

            _homeButton.onClick.RemoveAllListeners();
            _homeButton.onClick.AddListener(onHome);

            _restartButton.onClick.RemoveAllListeners();
            _restartButton.onClick.AddListener(onRestart);
        }
       
    }
}
