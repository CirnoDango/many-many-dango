using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Miraclebox : MonoBehaviour
{
    public Miracle miracle;
    public string clickmode;
    public Text info;
    public void Click()
    {
        if(clickmode == "lock") { return; }
        Miracleset.instance.miracleinchest.Remove(miracle);
        Miracleset.instance.MiracleEvent(miracle.index);
        Miracleset.instance.MiracleEnd();
        Miracleset.instance.MiracleEvent2(miracle.index);
    }
}
