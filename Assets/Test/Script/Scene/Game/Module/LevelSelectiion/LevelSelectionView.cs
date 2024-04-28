using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVCEST.Scene.Game.LevelSelections
{
    public class LevelSelectionView : ObjectView<ILevelSelectionModel>
    {
        [SerializeField]
        private Button levelOneButton;

        [SerializeField]
        private Button levelTwoButton;

        [SerializeField]
        private Button levelThreeButton;

        [SerializeField]
        Transform levelSelection;

        protected override void InitRenderModel(ILevelSelectionModel model)
        {

        }

        protected override void UpdateRenderModel(ILevelSelectionModel model)
        {

        }

        public void Init(UnityAction levelOne, UnityAction levelTwo, UnityAction levelThree)
        { 
            levelOneButton.onClick.RemoveAllListeners();
            levelOneButton.onClick.AddListener(levelOne);
            levelTwoButton.onClick.RemoveAllListeners();
            levelTwoButton.onClick.AddListener(levelTwo);
            levelThreeButton.onClick.RemoveAllListeners();
            levelThreeButton.onClick.AddListener(levelThree);
        }

        public void Deactivate()
        {
            levelSelection.gameObject.SetActive(false);
        }

    }
}