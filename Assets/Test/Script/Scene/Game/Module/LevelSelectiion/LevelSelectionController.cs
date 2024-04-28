using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using Agate.MVC.Core;
using MVCEST.Scene.Game.Questions;
using Test.Scene.Game;
using UnityEngine;

namespace MVCEST.Scene.Game.LevelSelections
{
    public class LevelSelectionController : ObjectController<LevelSelectionController, LevelSelectionModel, ILevelSelectionModel, LevelSelectionView>
    {
        public override void SetView(LevelSelectionView view)
        {
            base.SetView(view);
            view.Init(LevelOne,LevelTwo,LevelThree);
        }

        private void LevelOne()
        {
            Publish(new LevelSelectMessage(1));
            _view.Deactivate();
        }
        private void LevelTwo()
        {
            Publish(new LevelSelectMessage(2));
            _view.Deactivate();
        }
        private void LevelThree()
        {
            Publish(new LevelSelectMessage(3));
            _view.Deactivate();
        }
    }
}
