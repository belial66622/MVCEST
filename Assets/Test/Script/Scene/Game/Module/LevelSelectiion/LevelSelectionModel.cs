using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace MVCEST.Scene.Game.LevelSelections
{

    public interface ILevelSelectionModel : IBaseModel
    {
        public int LevelSelected {get;}
    }

    public class LevelSelectionModel : BaseModel , ILevelSelectionModel
    {
        public int LevelSelected {get;private set; }

    }


}