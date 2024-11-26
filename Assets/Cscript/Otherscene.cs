using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otherscene : MonoBehaviour
{
    public GameObject library;
    public GameObject tutorial;
    public GameObject birthday;
    public void Library()
    {
        library.SetActive(true);
    }
    public void Tutorial()
    {
        tutorial.SetActive(true);
    }
    public void Birthday()
    {
        birthday.SetActive(true);
    }
    public void BirthdayF()
    {
        birthday.SetActive(false);
    }
    public void Cancel()
    {
        if (Game.Clickmode() == "dango55")
        {
            Dangoset.instance.hexactive.RemoveAt(0);
        }
        Map.instance.cancel.SetActive(false);
        Game.EventExecute();
    }
}
