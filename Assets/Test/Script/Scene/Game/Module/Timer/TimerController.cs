using Agate.MVC.Base;
using MVCEST.Scene.Game.Questions;
using System.Collections;
using System.Collections.Generic;
using Test.Scene.Game;
using UnityEngine;

namespace MVCEST.Scene.Game.Timer
{
    public class TimerController : ObjectController<TimerController,TimerModel,ITimerModel,TimerView>
    {
        public override void SetView(TimerView view)
        {
            base.SetView(view);
            view.Init(TickTimer);
        }

        public void StartTimer()
        {
            _model.StartTimer(60);
            _view.StartTimer();
        }

        public void StopTimer()
        {
            _view.StopTimer();
            Publish(new LevelEndMessage());
        }


        public void TickTimer() 
        {
            _model.UpdateTimer();
            if (_model.Remaining <= 0)
            {
                StopTimer();

            }
        }
    }
}