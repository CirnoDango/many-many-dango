using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Buildbox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Build Build;
    public string clickmode = "";
    public Text info;
    public void Click()
    {
        if (clickmode == "lock") { return; }
        Game.Clickmode("sign");
        Buildset.instance.signinchest.Remove(Build);
        Game.Active_sign(Build);
        Buildset.instance.BuildEvent();

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(1);
        Dangoset.instance.libtext2.text = Build.info;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Dangoset.instance.libtext2.text = "";
    }
}
