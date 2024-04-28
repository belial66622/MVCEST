using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using TMPro;
using Test.Scene.Game;

namespace MVCEST.Scene.Game.Timer
{
    public class TimerView : ObjectView<ITimerModel>
    {
        [SerializeField]
        private TextMeshProUGUI _remainingDuration;

        private Action _onUpdate;

        private Coroutine _timer;

        public void Init(Action onUpdate)
        {
            _onUpdate = onUpdate;
        }

        protected override void InitRenderModel(ITimerModel model)
        {
        }

        protected override void UpdateRenderModel(ITimerModel model)
        {
            _remainingDuration.SetText($"Time : {model.Remaining}");
        }

        public void StartTimer()
        {
            if (_timer != null) return;
           _timer = StartCoroutine(Tick());
        }

        public void StopTimer()
        {
            StopAllCoroutines();
            _timer = null;
        }

        private IEnumerator Tick() 
        {
            while (true)
            { 
                yield return new WaitForSeconds(1);
                _onUpdate?.Invoke();
            }
        }
    }
}
