using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVCEST.Scene.Game.Scores
{
    public interface IScoreModel : IBaseModel
    {
        int Score { get; }
    }
    public class ScoreModel : BaseModel , IScoreModel
    {
        public int Score { get; private set; } = 0;

        // Start is called before the first frame update

        public void AddScore(int score)
        {
            if (Score + score <= 0)
            {
                Score = 0;
                SetDataAsDirty();
                return;
            }
                
            Score += score;
            SetDataAsDirty();
        }
    }
}