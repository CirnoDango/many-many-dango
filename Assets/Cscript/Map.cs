using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public static Map instance;
    public List<Hex> hexs = new();
    public List<Hex> hexs_active = new();
    public int map_stage = 0;
    public int hmx = -1;
    public int hnx = 0;
    public int hmy = -1;
    public int hny = 0;
    public int hmz = -1;
    public int hnz = 0;
    public int smx = -1;
    public int snx = 0;
    public int smy = -1;
    public int sny = 0;
    public int smz = -1;
    public int snz = 0;
    public GameObject hex;
    public GameObject canvas;
    public Camera cam;
    public int time = 0;
    public int day = 1;
    public Text ttime;
    public Dango active_dango;
    public Build active_sign;
    public string clickmode;

    public Text tdango;
    public int food;
    public int real_yuyuko = 6;
    public int yuyuko = 6;
    public GameObject youreaten;
    public GameObject youreatenbg;
    public GameObject info;
    public Text tinfo;

    public GameObject cancel;
    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
        SummonHexs(6, -6, 6, -6, 6, -6);
        ShowHexs(4, -4, 3, -3, 3, -3);
        active_dango = null;
        clickmode = "put";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SummonHex(int x, int y)
    {
        Hex h = new()
        {
            x = x,
            y = y,
            z = 0 - x - y,
            image = Instantiate(hex, canvas.transform)
        };
        h.image.SetActive(false);
        Ahex b = h.image.GetComponent<Ahex>();
        b.hex = h;
        h.ahex = b;
        h.image.transform.position = new Vector3(150 * x, 173 * y + 86.7f * x, 0);
        hexs.Add(h);
    }
    public void SummonHexs(int mx, int nx, int my, int ny, int mz, int nz)
    {
        for (int ix = nx; ix < mx + 1; ix++)
        {
            for (int iy = ny; iy < my + 1; iy++)
            {
                int iz = -ix - iy;
                if (iz >= nz && iz <= mz)
                {
                    SummonHex(ix, iy);
                }
            }
        }
        hmx = mx;
        hnx = nx;
        hmy = my;
        hny = ny;
        hmz = mz;
        hnz = nz;
        
    }
    public void NextMap()
    {
        switch (map_stage)
        {
            case 0:
                ShowHexs(4, -4, 4, -4, 4, -4);
                break;
            case 1:
                ShowHexs(5, -4, 5, -4, 4, -5);
                break;
            case 2:
                ShowHexs(5, -5, 5, -5, 5, -5);
                break;
        }
        map_stage++;
    }
    public void ShowHexs(int mx, int nx, int my, int ny, int mz, int nz)
    {
        foreach(Hex h in hexs)
        {
            if(h.x <= mx && h.x >= nx && h.y <= my && h.y >= ny && h.z <= mz && h.z >= nz)
            {
                h.image.SetActive(true);
                if (!hexs_active.Contains(h))
                {
                    hexs_active.Add(h);
                }
            }
        }
        cam.orthographicSize = Mathf.Abs(my + mz - ny - nz + 2) * 48;
        smx = mx;
        smy = my;
        smz = mz;
        snx = nx;
        sny = ny;
        snz = nz;
    }

    public void Time(int t)
    {
        if ((time + t) / 1440 >= day)// && Game.Clickmode() == "put")
        {
            Game.Events("eat");
        }
        time += t;
        ttime.text = "Day" + (time / 1440 + 1).ToString() + " " + Game.Time(time);
    }

    public void Eatstart()
    {
        day += 1;
        tdango.color = new Color(1, 1, 0.5f);
        if (food < yuyuko)
        {
            Game.Clickmode("gameover");
            youreaten.SetActive(true);
            youreatenbg.SetActive(true);
            PlayerPrefs.SetInt("day", Mathf.Max(PlayerPrefs.GetInt("day"), day - 1));
        }
        if (Game.Yuyuko() <= 0)
        {
            Game.Info("");
            Game.Clickmode("put");
            real_yuyuko += 3 * ((day - 1) / 7 + 1);
            Game.Yuyuko(real_yuyuko);
            Game.Food(0);

            //以下为新的一天效果
            Dangoset.instance.newdaying = true;
            foreach (Hex h in hexs_active)
            {
                h.newday = true;
            }
            Dangoset.instance.Newday();
        }
    }
}
