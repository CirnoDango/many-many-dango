using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Miracleset : MonoBehaviour
{
    public static Miracleset instance;
    public int miracle = 0;
    public int miracled_event = 0;
    public Text tmiracle;
    public GameObject miraclebox;
    public GameObject librarybox;
    public List<Miraclebox> librarydb;
    public Text libmiracle_number;
    public GameObject miracle1;
    public GameObject miracle2;
    public GameObject miracle3;

    public List<Miracle> miracleall = new() { mrc_00, mrc_01, mrc_02, mrc_03, mrc_04, mrc_05, mrc_06, mrc_07, mrc_08,mrc_09 };
    public List<Miracle> miracleinchest = new() { mrc_00, mrc_01, mrc_02, mrc_03, mrc_04, mrc_05, mrc_06, mrc_07, mrc_08, mrc_09 };
    public void Start()
    {
        instance = this;
        foreach(Miracle m in miracleall)
        {
            if(PlayerPrefs.GetInt("m" + m.index) == 1)
            {
                GameObject gol = Instantiate(miraclebox, librarybox.transform);
                Miraclebox dbl = gol.GetComponent<Miraclebox>();
                dbl.clickmode = "lock";
                dbl.miracle = m;
                dbl.info.text = dbl.miracle.info;
                gol.transform.localScale = new Vector3(0.4f, 0.4f);
                gol.transform.localPosition = (80 * (librarydb.Count)) * Vector3.down + 100 * Vector3.right;
                librarydb.Add(dbl);
                librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            }
        }
        libmiracle_number.text = libmiracle_number.text = "Miracle:" + PlayerPrefs.GetInt("miracle").ToString() + "/" + miracleall.Count.ToString();
    }
    public static Miracle mrc_00 = new()
    {
        index = 0,
        info = "扩大地图(A)"
    };
    public static Miracle mrc_01 = new()
    {
        index = 1,
        info = "发现2级宝箱团子, 若已发现：-6水需求(A)"
    };
    public static Miracle mrc_02 = new()
    {
        index = 2,
        info = "扩大地图(B)"
    };
    public static Miracle mrc_03 = new()
    {
        index = 3,
        info = "发现2级宝箱团子, 若已发现：-6水需求(B)"
    };
    public static Miracle mrc_04 = new()
    {
        index = 4,
        info = "喂食3个团子；幽幽子饭量-3"
    };
    public static Miracle mrc_05 = new()
    {
        index = 5,
        info = "时间倒流12小时"
    };
    public static Miracle mrc_06 = new()
    {
        index = 6,
        info = "所有空格+1水"
    };
    public static Miracle mrc_07 = new()
    {
        index = 7,
        info = "随机发现1级、2级团子各两个"
    };
    public static Miracle mrc_08 = new()
    {
        index = 8,
        info = "+8建筑"
    };
    public static Miracle mrc_09 = new()
    {
        index = 9,
        info = "宝箱团子-6水需求"
    };
    public void Miracle()
    {
        int k = Mathf.Min(3, miracleinchest.Count);
        switch (k)
        {
            case 0:
                Game.Info("You have achieved all miracles!");
                return;
            case 1:
                Miracle m1 = miracleinchest[0];
                miracle1 = Instantiate(miraclebox, Map.instance.canvas.transform);
                Miraclebox mi = miracle1.GetComponent<Miraclebox>();
                mi.clickmode = "click";
                mi.info.text = m1.info;
                mi.miracle = m1;
                break;
            case 2:
                Miracle m21 = miracleinchest[0];
                miracle1 = Instantiate(miraclebox, Map.instance.canvas.transform);
                Miraclebox mi21 = miracle1.GetComponent<Miraclebox>();
                mi21.clickmode = "click";
                mi21.info.text = m21.info;
                mi21.miracle = m21;
                Miracle m22 = miracleinchest[1];
                miracle2 = Instantiate(miraclebox, Map.instance.canvas.transform);
                miracle2.transform.position += Vector3.down * 225;
                Miraclebox mi22 = miracle2.GetComponent<Miraclebox>();
                mi22.clickmode = "click";
                mi22.info.text = m22.info;
                mi22.miracle = m22;
                break;
            case 3:
                System.Random rnd = new();
                int i1, i2, i3;
                do
                {
                    i1 = rnd.Next(miracleinchest.Count());
                    i2 = rnd.Next(miracleinchest.Count());
                    i3 = rnd.Next(miracleinchest.Count());
                } while (i1 == i2 || i1 == i3 || i2 == i3);
                Miracle m31 = miracleinchest[i1];
                miracle1 = Instantiate(miraclebox, Map.instance.canvas.transform);
                Miraclebox mi31 = miracle1.GetComponent<Miraclebox>();
                mi31.clickmode = "click";
                mi31.info.text = m31.info;
                mi31.miracle = m31;

                Miracle m32 = miracleinchest[i2];
                miracle2 = Instantiate(miraclebox, Map.instance.canvas.transform);
                miracle2.transform.position += Vector3.down * 225;
                Miraclebox mi32 = miracle2.GetComponent<Miraclebox>();
                mi32.clickmode = "click";
                mi32.info.text = m32.info;
                mi32.miracle = m32;

                Miracle m33 = miracleinchest[i3];
                miracle3 = Instantiate(miraclebox, Map.instance.canvas.transform);
                miracle3.transform.position += Vector3.down * 450;
                Miraclebox mi33 = miracle3.GetComponent<Miraclebox>();
                mi33.clickmode = "click";
                mi33.info.text = m33.info;
                mi33.miracle = m33;
                break;
        }
    }
    public void MiracleEvent(int index)
    {
        switch (index)
        {
            case 0:
                Map.instance.NextMap();
                break;
            case 1:
                if (Dangoset.instance.dangoinmap.Contains(Dangoset.instance.dango_31))
                {
                    Dangoset.instance.dango_31.water -= 6;
                    Dangoset.instance.boxs.Find(d31 => d31.refer_dango.index == 31).twater.text = Dangoset.instance.dango_31.water.ToString();
                }
                else
                {
                    Dangoset.instance.Box(Dangoset.instance.dango_31);
                }
                break;
            case 2:
                Map.instance.NextMap();
                break;
            case 3:
                if (Dangoset.instance.dangoinmap.Contains(Dangoset.instance.dango_31))
                {
                    Dangoset.instance.dango_31.water -= 6;
                    Dangoset.instance.boxs.Find(d31 => d31.refer_dango.index == 31).twater.text = Dangoset.instance.dango_31.water.ToString();
                }
                else
                {
                    Dangoset.instance.Box(Dangoset.instance.dango_31);
                }
                break;
            case 4:
                Map.instance.real_yuyuko -= 3;
                Game.Yuyuko(-6);
                Game.Food(0);
                break;
            case 5:
                Map.instance.Time(-720);
                break;
            case 6:
                foreach(Hex h in Map.instance.hexs_active)
                {
                    if (h.empty) { h.Water_pe(1); }
                }
                break;
            case 7:
                if(Dangoset.instance.dangoinchest.Count == 1)
                {
                    Dango i = Dangoset.instance.dangoinchest[0];
                    Dangoset.instance.Box(i, 1);
                }
                else if(Dangoset.instance.dangoinchest.Count >= 2)
                {
                    System.Random r = new();
                    Dango i, j;
                    do
                    {
                        i = Dangoset.instance.dangoinchest[r.Next(Dangoset.instance.dangoinchest.Count)];
                        j = Dangoset.instance.dangoinchest[r.Next(Dangoset.instance.dangoinchest.Count)];
                    } while (i == j);
                    Dangoset.instance.Box(i, 1);
                    Dangoset.instance.Box(j, 1);
                }
                if (Dangoset.instance.dangoinchest2.Count == 1)
                {
                    Dango i = Dangoset.instance.dangoinchest2[0];
                    Dangoset.instance.Box(i, 2);
                }
                else if (Dangoset.instance.dangoinchest2.Count >= 2)
                {
                    System.Random r = new();
                    Dango i, j;
                    do
                    {
                        i = Dangoset.instance.dangoinchest2[r.Next(Dangoset.instance.dangoinchest2.Count)];
                        j = Dangoset.instance.dangoinchest2[r.Next(Dangoset.instance.dangoinchest2.Count)];
                    } while (i == j);
                    
                    Dangoset.instance.Box(i, 2);
                    Dangoset.instance.Box(j, 2);
                }
                break;
            case 9:
                Dangoset.instance.dango_02.water -= 6;
                Dangoset.instance.boxs.Find(d31 => d31.refer_dango.index == 2).twater.text = Dangoset.instance.dango_02.water.ToString();
                break;
    }

        if (PlayerPrefs.GetInt("m" + index.ToString()) == 0)
        {
            GameObject gol = Instantiate(miraclebox, librarybox.transform);
            Miraclebox dbl = gol.GetComponent<Miraclebox>();
            dbl.clickmode = "lock";
            dbl.miracle = miracleall.Find(m => m.index == index);
            dbl.info.text = dbl.miracle.info;
            gol.transform.localScale = new Vector3(0.4f, 0.4f);
            gol.transform.localPosition = (80 * (librarydb.Count)) * Vector3.down + 100 * Vector3.right;
            librarydb.Add(dbl);
            librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            PlayerPrefs.SetInt("miracle", PlayerPrefs.GetInt("miracle") + 1);
        }
        PlayerPrefs.SetInt("m" + index.ToString(), 1);
        libmiracle_number.text = libmiracle_number.text = "Miracle:" + PlayerPrefs.GetInt("miracle").ToString() + "/" + miracleall.Count.ToString();
    }

    public void MiracleEvent2(int index)
    {
        switch (index)
        {
            case 8:
                Game.Build(8);
                break;

        }
    }

    public void MiracleEnd()
    {
        miracled_event++;
        miracle -= miracled_event;
        tmiracle.text = miracle.ToString() + "/" + (miracled_event + 1);
        Destroy(miracle1);
        Destroy(miracle2);
        Destroy(miracle3);
        Game.EventExecute();
        foreach(Hex h in Map.instance.hexs_active)
        {
            if(!h.empty && h.dango.index == 46)
            {
                foreach (Hex wh in h.Distance(Map.instance.hexs_active, 1))
                {
                    wh.Water_pe(1);
                }
                foreach (Hex wh in h.Distance(Map.instance.hexs_active, 2))
                {
                    wh.Water_pe(1);
                }
                foreach (Hex wh in h.Distance(Map.instance.hexs_active, 3))
                {
                    wh.Water_pe(1);
                }
            }
            if(h.sign && h.build.index == 5)
            {
                foreach (Hex wh in h.Distance(Map.instance.hexs_active, 1))
                {
                    wh.Water_pe(1);
                }
                foreach (Hex wh in h.Distance(Map.instance.hexs_active, 2))
                {
                    wh.Water_pe(1);
                }
            }
            if (h.sign && h.build.index == 10)
            {
                if(Dangoset.instance.dangoinchest2.Count > 0)
                {
                    System.Random r = new();
                    Dango i = Dangoset.instance.dangoinchest2[r.Next(Dangoset.instance.dangoinchest2.Count)];
                    Dangoset.instance.Box(i, 2);
                    List<Hex> lh = new();
                    foreach(Hex ph in h.Distance(Map.instance.hexs_active, 1))
                    {
                        if (ph.empty) { lh.Add(ph); }
                    }
                    if (lh.Count > 0)
                    {
                        Game.Food(i.food);
                        Dangoset.instance.Put(Map.instance.hexs, i, lh[r.Next(lh.Count)]);
                    }
                }
            }
        }
    }
}
