using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CardGame.Config;

namespace CardGame
{
    [CreateAssetMenu(menuName = "CardData")]
    public class CardScriptableOBJ : ScriptableObject
    {
       public String Name;
       public int Cost;

       public String Description;

       public Image Image;

       public List<PrimaryElements> elements;
    }
}
