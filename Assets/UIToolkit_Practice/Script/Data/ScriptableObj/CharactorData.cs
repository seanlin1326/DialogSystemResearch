using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UI_Toolkit_Practice
{
    [CreateAssetMenu(fileName = "CharactorData", menuName = "Data/CharactorData", order = 1)]
    public class CharactorData : ScriptableObject
    {
       public Texture2D charactorAvatarImage;
       public string charactorName;
       public int charactorStarLevel = 1;
       public CharactorStat charactorStat;
    }
}