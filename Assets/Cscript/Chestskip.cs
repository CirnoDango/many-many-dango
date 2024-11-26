using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestskip : MonoBehaviour
{
    public void Skip()
    {
        switch (Game.Clickmode())
        {
            case "chest":
                Dangoset.instance.Chestclose(1,false);
                break;
            case "chest2":
                Dangoset.instance.Chestclose(2,false);
                break;
        }
    }
}
