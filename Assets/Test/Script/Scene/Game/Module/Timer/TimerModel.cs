using Agate.MVC.Base;
using UnityEngine;

namespace MVCEST.Scene.Game.Timer
{
    public interface ITimerModel : IBaseModel
    {
        public int Remaining { get; }
    }

    public class TimerModel : BaseModel, ITimerModel
    {
        public int Duration { get; private set; }
        public int Remaining { get; private set; }
        public float Progress { get; private set; }
        public bool IsStarted { get; private set; }
        public bool IsCompleted { get; private set; }

        public TimerModel() { }

        public void StartTimer(int currentTime)
        {
            Duration= currentTime;
            Remaining = Duration;
            SetDataAsDirty();
        }

        public void UpdateTimer()
        {
            Remaining--;
            SetDataAsDirty();
        }
    }
}
