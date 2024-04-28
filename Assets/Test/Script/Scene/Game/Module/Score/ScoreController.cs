using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVCEST.Scene.Game.Scores
{
    public class ScoreController : ObjectController<ScoreController,ScoreModel,IScoreModel,ScoreView>
    {

        public void AddScore(int score)
        { 
            _model.AddScore(score);
        }
    }
}