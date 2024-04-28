using Agate.MVC.Base;
using MVCEST.Scene.Game.Questions;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVCEST.Scene.Game.Questions
{
    public class QuestionView : ObjectView<IQuestionModel>
    {
        [SerializeField]
        TextMeshProUGUI _question;

        [SerializeField]
        TMP_InputField _answerBox;

        [SerializeField]
        TextMeshProUGUI _level;

        [SerializeField]
        Button _answerButton;

        [SerializeField]
        Transform levelSelection;

        [SerializeField]
        Transform inGame;

        [SerializeField]
        Transform gameOver;


        public void Init(UnityAction<int> answer)
        {
            _answerButton.onClick.RemoveAllListeners();
            _answerButton.onClick.AddListener(() => { answer(Int32.Parse(_answerBox.text)); _answerBox.text = ""; });
        }

        protected override void InitRenderModel(IQuestionModel model)
        {

        }

        protected override void UpdateRenderModel(IQuestionModel model)
        {
            _level.SetText($"Level {model.Level}");
            _question.SetText($"{model.FirstNumber} {((model.Operation) == 0 ? "+" : "-")} {model.SecondNumber}");
        }

        public void DeactivateAll()
        { 
            levelSelection.gameObject.SetActive(false);
            inGame.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(false);
        }

        public void LevelSelectionScreen()
        {
            DeactivateAll();
            levelSelection.gameObject.SetActive(true);

        }

        public void InGameScreen()
        {
            DeactivateAll();
            inGame.gameObject.SetActive(true);

        }
        public void GameOverScreen()
        {
            DeactivateAll();
            gameOver.gameObject.SetActive(true);

        }
    }
}