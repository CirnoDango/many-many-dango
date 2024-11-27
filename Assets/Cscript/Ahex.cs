using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Ahex : MonoBehaviour
{
    public Hex hex;
    public Text twater;
    public Text twater_pe;
    public Image button;

    // Start is called before the first frame update
    void Start()
    {
        button.alphaHitTestMinimumThreshold = 0.3f;
    }
    public void Click()
    {
        switch (Game.Clickmode())
        {
            case "put":
                if (Game.Active_dango () != null)
                {
                    if (Game.Active_dango().index == 26 && Map.instance.time % 1440 > 360) { return; }
                    if (!hex.empty && hex.dango.index == 19)
                    {
                        Dangoset.instance.dango19 = hex;
                        Game.Events("dango19");
                    }
                    if (!hex.empty && hex.dango.index == 64)
                    {
                        Dangoset.instance.dango64 = hex;
                        Game.Events("dango64");
                    }
                    if (!hex.empty && hex.dango.index == 54)
                    {
                        List<Hex> eh = new();
                        System.Random r = new();
                        foreach(Hex h in Map.instance.hexs_active)
                        {
                            if (h.empty) { eh.Add(h); }
                        }
                        Hex dh = eh[r.Next(eh.Count)];
                        Dangoset.instance.Put(Map.instance.hexs, Dangoset.instance.dango_54, dh);
                        Dangoset.instance.Eat(Map.instance.hexs, hex);
                        Map.instance.Time(30);
                        return;
                    }
                    if (((hex.empty && (hex.water >= Game.Active_dango().water || Game.Active_dango().index == 16)) || (hex.dango18 < 3 && hex.dango18 >= 1 && Game.Active_dango().index == 18 && hex.water >= Game.Active_dango().water)) || Dangoset.instance.waterhack)
                    {
                        Game.Food(Game.Active_dango().food);
                        foreach(Hex h in hex.Distance(Map.instance.hexs_active,1))
                        {
                            if (!h.empty && h.dango.index == 49)
                            {
                                hex.Water_pe(-1);
                            }
                            if (!h.empty && h.dango.index == 50)
                            {
                                hex.Water_pe(1);
                            }
                        }
                        Dangoset.instance.Put(Map.instance.hexs, Game.Active_dango(), hex);
                        foreach(Hex h in hex.Distance(Map.instance.hexs_active, 1))
                        {
                            if(h.sign && h.build.index == 6)
                            {
                                List<Hex> lh = new();
                                foreach (Hex ph in h.Distance(Map.instance.hexs_active, 1))
                                {
                                    if (ph.empty) { lh.Add(ph); }
                                }
                                if(lh.Count > 0)
                                {
                                    System.Random r = new();
                                    Dango d = Dangoset.instance.dangoinmap[r.Next(Dangoset.instance.dangoinmap.Count)];
                                    Game.Food(d.food);
                                    Dangoset.instance.Put(Map.instance.hexs, d, lh[r.Next(lh.Count)]);
                                }
                            }
                        }

                        if (Dangoset.instance.sign2 && hex.Distance(Map.instance.hexs_active,1).Contains(Map.instance.hexs_active.Find(h => h.sign && h.build.index == 2)))
                        {
                            
                        }
                        else
                        {
                            if(!Dangoset.instance.dango15 || Game.Active_dango().index == 15)
                            {
                                if (!hex.empty)
                                {
                                    Map.instance.Time(Game.Active_dango().time);
                                }
                                else
                                {
                                    Map.instance.Time(Dangoset.instance.dango_59.time);
                                }
                                
                            }
                            else
                            {
                                Dangoset.instance.dango15 = false;
                            }
                        }

                        Dangoset.instance.sign2 = false;

                        if(Game.Active_dango().index == 16)
                        {
                            if(hex.water < Dangoset.instance.dango_16.water)
                            {
                                Map.instance.Time(30 * (Dangoset.instance.dango_16.water - hex.water));
                            }
                        }
                        if (Game.Active_dango().index == 62)
                        {
                            if (hex.x != Map.instance.smx && hex.x != Map.instance.snx &&
                                hex.y != Map.instance.smy && hex.y != Map.instance.sny &&
                                hex.z != Map.instance.smz && hex.z != Map.instance.snz)
                            {
                                Map.instance.Time(120);
                            }
                        }
                        if (Game.Active_dango().index == 11)
                        {
                            if (Map.instance.time % 1440 == 0) { Map.instance.Time(1440); }
                            Map.instance.Time(1440 - Map.instance.time % 1440);
                        }
                    }
                    
                }
                break;
            case "eat":
                if (!hex.empty)
                {
                    if (hex.dango.food <= 0) { return; }
                    Game.Yuyuko(-hex.dango.food);
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs, hex);
                    if (Game.Food() < Game.Yuyuko()) { Map.instance.Gameover(100 * (Map.instance.day - 1) + 100 * Game.Food() / Game.Yuyuko()); }
                    foreach(Hex h in hex.Distance(Map.instance.hexs, 1))
                    {
                        if(h.sign && h.build.index == 7)
                        {
                            hex.Water_pe(1);
                        }
                    }
                    foreach (Hex h in hex.Distance(Map.instance.hexs, 2))
                    {
                        if (h.sign && h.build.index == 7)
                        {
                            hex.Water_pe(1);
                        }
                    }
                    if (Game.Yuyuko() <= 0)
                    {
                        Game.Clickmode("put");
                        Game.EventExecute();
                        Map.instance.real_yuyuko += 3 * ((Map.instance.day - 1) / 7 + 1);
                        Game.Yuyuko(Map.instance.real_yuyuko);
                        Game.Food(0);
                        List<Hex> lh = new();

                        //以下为新的一天效果
                        Dangoset.instance.newdaying = true;
                        foreach(Hex h in Map.instance.hexs_active)
                        {
                            h.newday = true;
                        }
                        Dangoset.instance.Newday();
                    }
                }
                break;
            case "sign":
                if (hex.empty)
                {
                    Buildset.instance.Put(Game.Active_sign(), hex);
                    Game.EventExecute();
                }
                break;
            case "dango05":
                hex.Water_pe(2);
                Game.EventExecute();
                break;
            case "dango09":
                if (!hex.empty)
                {
                    if (hex.dango.food == 0) { return; }
                    int d69 = 0;
                    if(hex.dango.index == 69 && hex.dango69) { d69 = 3; }
                    Map.instance.Time(-(hex.dango.food + d69) * 15);
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs, hex);
                    
                    Game.EventExecute();
                }
                break;
            case "dango14":
                hex.Water_pe(7);
                Game.EventExecute();
                break;
            case "dango19":
                if (hex.Distance(Map.instance.hexs, 0).Contains(Dangoset.instance.dango19))
                {
                    Game.EventExecute();
                    break;
                }
                if (hex.Distance(Map.instance.hexs, 1).Contains(Dangoset.instance.dango19) && hex.empty)
                {
                    Game.EventExecute();
                    Dangoset.instance.Put(Map.instance.hexs, Dangoset.instance.dango_19, hex);
                    Dangoset.instance.Eat(Map.instance.hexs, Dangoset.instance.dango19);
                    Map.instance.Time(30);
                }
                break;
            case "dango24":
                if (!hex.empty)
                {
                    if (hex.dango.food == 0) { return; }
                    Game.Yuyuko(-hex.dango.food);
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs, hex);
                    Game.EventExecute();
                }
                break;
            case "dango28":
                if (!hex.empty)
                {
                    if (hex.dango.dango28) { return; }
                    hex.dango.time -= hex.dango.time / 6;
                    hex.dango.dango28 = true;
                    Dangoset.instance.boxs.Find(db => db.refer_dango.index == hex.dango.index).time.text = Game.Time(hex.dango.time);
                    Game.EventExecute();
                }
                break;
            case "dango30":
                Dangoset.instance.dango30 = Dangoset.instance.hexactive[0];
                
                if (hex.Distance(Map.instance.hexs, 1).Contains(Dangoset.instance.dango30))
                {
                    Dangoset.instance.hexactive.RemoveAt(0);
                    Game.EventExecute();
                    Dangoset.instance.dango30.dango30 = new Vector3(hex.x - Dangoset.instance.dango30.x, hex.y - Dangoset.instance.dango30.y, hex.z - Dangoset.instance.dango30.z);
                    int a = 0;
                    switch (Dangoset.instance.dango30.dango30.x + 10 * Dangoset.instance.dango30.dango30.y)
                    {
                        case 10:
                            a = 0;
                            break;
                        case 9:
                            a = 60;
                            break;
                        case -1:
                            a = 120;
                            break;
                        case -10:
                            a = 180;
                            break;
                        case -9:
                            a = 240;
                            break;
                        case 1:
                            a = 300;
                            break;  
                    }
                    Dangoset.instance.dango30.godan.transform.Rotate(0, 0, a);
                    Dangoset.instance.dango30.dango30.Normalize();
                    foreach (Hex h in Map.instance.hexs)
                    {
                        Vector3 v3 = new(h.x - Dangoset.instance.dango30.x, h.y - Dangoset.instance.dango30.y, h.z - Dangoset.instance.dango30.z);
                        v3 = v3.normalized;
                        Debug.Log(v3);
                        Debug.Log(Dangoset.instance.dango30.dango30);
                        if(v3 == Dangoset.instance.dango30.dango30)
                        {
                            h.Water(2);
                        }
                    }
                    
                    break;
                }
                break;
            case "dango35":
                if (!hex.empty)
                {
                    if (hex.dango.dango35) { return; }
                    hex.dango.water -= 1;
                    hex.dango.dango35 = true;
                    Dangobox rdb = Dangoset.instance.boxs.Find(db => db.refer_dango.index == hex.dango.index);
                    rdb.twater.text = rdb.refer_dango.water.ToString();
                    Game.EventExecute();
                }
                break;
            case "dango36":
                if (!hex.empty)
                {
                    hex.Water_pe(2);
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs, hex);
                    Game.EventExecute();
                }
                break;
            case "dango42":
                if (!hex.empty && (hex.dango.index == 2 || hex.dango.index == 31))
                {
                    switch (hex.dango.index)
                    {
                        case 2:
                            Dangoset.instance.Chestopen();
                            break;
                        case 31:
                            Dangoset.instance.Chestopen2();
                            break;
                    }
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs, hex);
                }
                break;
            case "dango44":
                if (!hex.empty)
                {
                    System.Random rnd = new();
                    List<Hex> ahexs = new();
                    foreach(Hex h in Map.instance.hexs_active)
                    {
                        if (h.empty) { ahexs.Add(h); }
                    }
                    Hex dh = ahexs[rnd.Next(ahexs.Count)];
                    Dango d = hex.dango;
                    dh.dango18 = hex.dango18;
                    dh.dango30 = hex.dango30;
                    dh.dango34 = hex.dango34;
                    hex.dango18 = 0;
                    hex.dango34 = 0;
                    Dangoset.instance.Eat_silent(Map.instance.hexs, hex);
                    Dangoset.instance.Put_silent(Map.instance.hexs, d, dh);
                    Game.EventExecute();
                }
                break;
            case "dango55":
                Dangoset.instance.dango30 = Dangoset.instance.hexactive[0];
                if(hex.Distance(Map.instance.hexs_active,1).Contains(Dangoset.instance.dango30) && !hex.empty && !hex.sign)
                {
                    Game.EventExecute();
                    Dangoset.instance.hexactive.RemoveAt(0);
                    Game.Food(-hex.dango.food);
                    Dangoset.instance.Eat(Map.instance.hexs_active, hex);
                    Dangoset.instance.dango30.Water_pe(3);
                }
                break;
            case "dango64":
                if (hex.Distance(Map.instance.hexs, 0).Contains(Dangoset.instance.dango64))
                {
                    Game.EventExecute();
                    break;
                }
                if (hex.Distance(Map.instance.hexs, 1).Contains(Dangoset.instance.dango64) && hex.empty && hex.water >= Dangoset.instance.dango_64.water)
                {
                    Game.EventExecute();
                    Dangoset.instance.Put(Map.instance.hexs, Dangoset.instance.dango_64, hex);
                    Dangoset.instance.Eat(Map.instance.hexs, Dangoset.instance.dango64);
                }
                break;
            case "dango70":
                hex.Water_pe(4);
                Game.EventExecute();
                break;

        } 
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
