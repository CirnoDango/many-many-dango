using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Dangobox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Dango refer_dango;
    public GameObject box;
    public GameObject water;
    public Text twater;
    public Text time;
    public GameObject dango;
    public string clickmode;
    public void Click()
    {
        switch (clickmode)
        {
            case "put":
                if (Game.Active_dango() == refer_dango)
                {
                    Game.Deactive();
                    gameObject.transform.localPosition += new Vector3(-100, 0);
                }
                else
                {
                    foreach (Dangobox db in Dangoset.instance.boxs)
                    {
                        db.gameObject.transform.localPosition = new Vector3(0, db.gameObject.transform.localPosition.y);
                    }
                    Game.Active_dango(refer_dango);
                    gameObject.transform.localPosition += new Vector3(100, 0);
                }
                break;
            case "chest":
                Dangoset.instance.Box(refer_dango);
                Dangoset.instance.Chestclose(1,true);
                break;
            case "chest2":
                Dangoset.instance.Box(refer_dango, 2);
                Dangoset.instance.Chestclose(2,true);
                break;

        }
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Map.instance.tinfo.text = refer_dango.info;
        Dangoset.instance.libtext.text = refer_dango.info;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Map.instance.tinfo.text = "";
        Dangoset.instance.libtext.text = "";
    }
}