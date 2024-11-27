using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Hex
{
    public int x;
    public int y;
    public int z;
    public int water;
    public bool empty = true;
    public bool newday = false;
    public int dango18 = 0;
    public int dango34 = 0;
    public string dango59 = "";
    public bool dango69 = false;
    public GameObject td34;
    public GameObject image;
    public GameObject godan;
    public Dango dango;
    public bool sign = false;
    public Build build;
    public Ahex ahex;
    public Vector3 dango30;
    public List<Hex> Hexs(List<Hex> hexs, int mx, int nx, int my, int ny, int mz, int nz)
    {
        List<Hex> listhex = new();
        foreach (Hex h in hexs)
        {
            if ((h.x - x) >= nx && (h.y - y) >= ny && (h.z - z) >= nz && (h.x - x) <= mx && (h.y - y) <= my && (h.z - z) <= mz)
            {
                listhex.Add(h);
            }
        }
        return listhex;
    }
    public List<Hex> Distance(List<Hex> hexs, int d)
    {
        List<Hex> listhex = new();
        foreach (Hex h in hexs)
        {
            int dis = Mathf.Max(Mathf.Abs(h.x - x), Mathf.Abs(h.y - y), Mathf.Abs(h.z - z));
            if (dis == d)
            {
                listhex.Add(h);
            }
        }
        return listhex;
    }
    public void Water(int d)
    {
        water += d;
        ahex.twater.text = water.ToString();
        if (water == 0 || (!empty && (dango18 == 0 || dango18 == 3)))
        {
            ahex.twater.text = "";
        }
    }
    public void Water_pe(int d)
    {
        if (!Map.instance.hexs_active.Contains(this)) { return; }
        if (d < 0)
        {
            if (!empty && dango.index == 43)
            {
                return;
            }
        }
        if(!empty && dango.index == 60)
        {
            List<Hex> ph = new();
            foreach(Hex h in Distance(Map.instance.hexs_active, 1))
            {
                if (h.empty) { ph.Add(h); }
            }
            if(ph.Count > 0)
            {
                System.Random r = new();
                ph[r.Next(ph.Count)].Water_pe(d);
            }
        }
        Water(d);
        if (ahex.twater_pe.text == "") { ahex.twater_pe.text = "0"; }
        ahex.twater_pe.text = (int.Parse(ahex.twater_pe.text) + d).ToString();
        if (ahex.twater_pe.text == "0") { ahex.twater_pe.text = ""; }
    }
}

public class Dango
{
    public string name;
    public int index;
    public int water;
    public int food;
    public int time;
    public string info;
    public string note;
    public bool dango15 = false;
    public bool dango28 = false;
    public bool dango35 = false;
}

public class Miracle
{
    public int index;
    public string info;
}
public class Build
{
    public int index;
    public string info;
}

public class Game
{
    public Dango active_dango;
    public static void Deactive()
    {
        Map.instance.active_dango = null;
    }
    public static Dango Active_dango(params Dango[] dango)
    {
        if(dango.Length == 1)
        {
            Map.instance.active_dango = dango[0];
        }
        return Map.instance.active_dango;
    }
    public static Build Active_sign(params Build[] sign)
    {
        if (sign.Length == 1)
        {
            Map.instance.active_sign = sign[0];
        }
        return Map.instance.active_sign;
    }
    public static string Time(int t)
    {
        int hour = (t % 1440) / 60;
        string shour = hour.ToString();
        if (hour < 10)
        {
            shour = "0" + shour;
        }
        int min = t % 60;
        string smin = min.ToString();
        if (min < 10)
        {
            smin = "0" + smin;
        }
        return (shour + ":" + smin);
    }
    public static string Clickmode(params string[] mode)
    {
        if(mode.Length == 1)
        {
            Map.instance.clickmode = mode[0];
            switch (Map.instance.clickmode)
            {
                case "put":
                    Cancel(0);
                    Info("");
                    break;
                case "eat":
                    Cancel(0);
                    Info("Eatting time!");
                    Map.instance.Eatstart();
                    break;
                case "lock":
                    Cancel(0);
                    Info("Choose one!");
                    break;
                case "chest":
                    Cancel(0);
                    Info("Choose one!");
                    break;
                case "chest2":
                    Cancel(0);
                    Info("Choose one!");
                    break;
                case "miracle":
                    Cancel(0);
                    Info("Choose one!");
                    Miracleset.instance.Miracle();
                    break;
                case "Build":
                    Cancel(0);
                    Info("Choose one!");
                    Buildset.instance.Build();
                    break;
                case "sign":
                    Cancel();
                    Info("Put sign!");
                    break;
                case "dango02":
                    Dangoset.instance.Chestopen();
                    break;
                case "dango05":
                    Cancel();
                    Info("choose a hex to +2 water");
                    break;
                case "dango09":
                    Cancel();
                    Info("eat a dango, get 00:15 for each");
                    break;
                case "dango14":
                    Cancel();
                    Info("choose a hex to +7 water");
                    break;
                case "dango19":
                    Cancel();
                    Info("choose a hex to move");
                    break;
                case "dango24":
                    Cancel();
                    Info("feed yuyuko a dango");
                    break;
                case "dango28":
                    Cancel();
                    Info("choose a dango in map, reduce craft time by 1/6");
                    break;
                case "dango30":
                    Cancel();
                    Info("choose direction of laser by click a nearby hex");
                    break;
                case "dango31":
                    Dangoset.instance.Chestopen2();
                    break;
                case "dango35":
                    Cancel();
                    Info("choose a dango in map, reduce water demand by 1");
                    break;
                case "dango36":
                    Cancel();
                    Info("send a dango, +2 water there");
                    break;
                case "dango42":
                    Cancel();
                    Info("choose a chest to open");
                    break;
                case "dango44":
                    Cancel();
                    Info("choose a dango to fly");
                    break;
                case "dango55":
                    Cancel();
                    Info("choose a dango to crush into 3 water");
                    break;
                case "dango64":
                    Cancel();
                    Info("choose a >" + Dangoset.instance.dango_64.water + " hex to move");
                    break;
                case "dango70":
                    Cancel();
                    Info("choose a hex to +4 water");
                    break;
            }
            //if (Dangoset.instance.newdaying && mode[0] == "put"){ Dangoset.instance.Newday();}
        }
        return Map.instance.clickmode;
    }
    public static int Yuyuko(params int[] y)
    {
        if (y.Length == 1)
        {
            Map.instance.yuyuko += y[0];
            Map.instance.tdango.text = Map.instance.food + "/" + Map.instance.yuyuko;
        }
        return Map.instance.yuyuko;
    }
    public static int Food(params int[] y)
    {
        if (y.Length == 1)
        {
            Map.instance.food += y[0];
            Map.instance.tdango.text = Map.instance.food + "/" + Map.instance.yuyuko;
        }
        if (Map.instance.clickmode != "eat")
        {
            if (Map.instance.food >= Map.instance.yuyuko)
            {
                Map.instance.tdango.color = new Color(0.5f, 1, 0.5f);
            }
            else
            {
                Map.instance.tdango.color = new Color(1, 1, 1);
            }
        }
        return Map.instance.food;
    }
    public static string Info(params string[] i)
    {
        if (i.Length == 1)
        {
            Dangoset.instance.info.text = i[0];
        }
        return Dangoset.instance.info.text;
    }

    public static List<string> Events(params string[] e)
    {
        if(e.Length == 1)
        {
            Dangoset.instance.Events.Add(e[0]);
            if (Clickmode() == "put")
            {
                EventExecute();
            }
        }
        return Dangoset.instance.Events;
    }
    public static void EventExecute()
    {
        if (Clickmode() == "eat") { return; }
        if (Events().Count == 0)
        {
            Info("");
            Clickmode("put");
        }
        else
        {
            Clickmode(Events()[0]);
            Events().Remove(Events()[0]);
        }
    }
    public static void Miracle(int m)
    {
        Miracleset.instance.miracle += m;
        Miracleset.instance.tmiracle.text = Miracleset.instance.miracle.ToString() +"/" + Miracleset.instance.miracle_demand;
        if (Miracleset.instance.miracle >= Miracleset.instance.miracle_demand)
        {
            foreach (string e in Dangoset.instance.Events)
            {
                if (e == "miracle") { return; }
            }
            Events("miracle");
        }
    }
    public static void Build(int m)
    {
        Buildset.instance.build += m;
        Buildset.instance.tbuild.text = Buildset.instance.build.ToString() + "/" + 8;
        if (Buildset.instance.build >= 8)
        {
            Events("Build");
            Miracle(1);
        }
    }
    public static void Cancel(params int[] v)
    {
        if(v.Length == 1 && v[0] == 0)
        {
            Map.instance.cancel.SetActive(false);
            return;
        }
        Map.instance.cancel.SetActive(true);
    }
}