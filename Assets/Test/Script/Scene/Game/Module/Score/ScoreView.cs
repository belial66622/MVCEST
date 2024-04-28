using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MVCEST.Scene.Game.Scores
{
    public class ScoreView : ObjectView<IScoreModel>
    {
        [SerializeField]
        TextMeshProUGUI scoreText;
        protected override void InitRenderModel(IScoreModel model)
        {
            scoreText.SetText($"Score : {model.Score}");
        }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            scoreText.SetText($"Score : {model.Score}");
        }


    }
}