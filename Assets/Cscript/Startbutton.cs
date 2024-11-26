using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton : MonoBehaviour
{
    public GameObject tutorial;
    // Start is called before the first frame update
    public void Click()
    {
        tutorial.SetActive(false);
    }
}
