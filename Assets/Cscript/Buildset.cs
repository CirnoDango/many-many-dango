using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buildset : MonoBehaviour
{
    public static Buildset instance;
    public int build = 0;
    public int built = 0;
    public Text tbuild;
    public GameObject Buildbox;
    public GameObject Build1;
    public GameObject Build2;
    public GameObject Build3;

    public GameObject librarybox;
    public List<Buildbox> librarydb;
    public Text libBuild_number;

    public GameObject Image_00;
    public GameObject Image_01;
    public GameObject Image_02;
    public GameObject Image_03;
    public GameObject Image_04;
    public GameObject Image_05;
    public GameObject Image_06;
    public GameObject Image_07;
    public GameObject Image_08;
    public GameObject Image_09;
    public GameObject Image_10;
    public GameObject Image_11;
    public GameObject Image_12;
    public GameObject Image_13;
    public GameObject Image_14;
    public GameObject Image_15;
    public GameObject Image_16;
    public GameObject Image_17;
    public List<Build> signall = new()
    {
        sign_00, sign_01, sign_02, sign_03, sign_04, sign_05, sign_06, sign_07, sign_08, sign_09, sign_10, sign_11,
        sign_12, sign_13, sign_14, sign_15, sign_16, sign_17,
    };
    public List<Build> signinchest = new()
    {
        sign_00, sign_01, sign_02, sign_03, sign_04, sign_05, sign_06, sign_07, sign_08, sign_09, sign_10, sign_11,
        sign_12, sign_13, sign_14, sign_15, sign_16, sign_17,
    };
    public void Start()
    {
        instance = this;
        foreach(Build sign in signall)
        {
            if(PlayerPrefs.GetInt("s" + sign.index) == 1)
            {
                GameObject gol = Instantiate(Buildbox, librarybox.transform);
                Buildbox dbl = gol.GetComponent<Buildbox>();
                dbl.clickmode = "lock";
                dbl.Build = signall.Find(m => m.index == sign.index);
                GameObject ims = Instantiate(ImageSign(sign.index), gol.transform);
                ims.transform.localScale = new Vector3(1.5f, 1.5f);
                gol.transform.localScale = new Vector3(0.4f, 0.4f);
                gol.transform.localPosition = (80 * (librarydb.Count)) * Vector3.down + 100 * Vector3.right;
                librarydb.Add(dbl);
                librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            }
            libBuild_number.text = libBuild_number.text = "Sign:" + PlayerPrefs.GetInt("Build").ToString() + "/" + signall.Count.ToString();
        }
    }
    public static Build sign_00 = new()
    {
        index = 0,
        info = "神社\n放置时：发现符札团子\n新的一天：1格内+2水"
    };
    public static Build sign_01 = new()
    {
        index = 1,
        info = "魔法森林\n放置时：发现蘑菇团子\n新的一天：每个相邻格随机生成一个水需求小于3的团子"
    };
    public static Build sign_02 = new()
    {
        index = 2,
        info = "魔馆\n放置时：发现血液团子\n持续：若在1格内放置每天第一个团子，不花费时间"
    };
    public static Build sign_03 = new()
    {
        index = 3,
        info = "雾之湖\n放置时：发现水团子、冰团子、雪团子并减1/3耗时\n持续：1格内+3水"
    };
    public static Build sign_04 = new()
    {
        index = 4,
        info = "白玉阶梯\n放置时：发现半灵团子，1格内+1水\n新的一天：若相邻6格都存在团子：幽幽子饭量-1"
    };
    public static Build sign_05 = new()
    {
        index = 5,
        info = "西行妖\n放置时：发现樱花团子，+1奇迹\n发生奇迹时：2格内+1水"
    };
    public static Build sign_06 = new()
    {
        index = 6,
        info = "竹林\n放置时：发现胡萝卜团子\n持续：每在1格内放置1个团子，在1格内放置1个随机团子"
    };
    public static Build sign_07 = new()
    {
        index = 7,
        info = "三途川\n放置时：发现铜钱团子和黑白团子\n持续：2格内团子被吃时，该格+1水"
    };
    public static Build sign_08 = new()
    {
        index = 8,
        info = "植物园\n放置时：发现双豌豆团子、向日葵团子、红豆团子并使水需求减为2\n持续：1格内+2水"
    };
    public static Build sign_09 = new()
    {
        index = 9,
        info = "妖怪之山\n放置时：发现红叶团子\n新的一天：2格内存在团子的格+1水"
    };
    public static Build sign_10 = new()
    {
        index = 10,
        info = "风之湖\n放置时：发现信仰团子，+1奇迹\n发生奇迹时：随机获得一个2级团子，并将其免费放置在随机相邻格"
    };
    public static Build sign_11 = new()
    {
        index = 11,
        info = "地灵殿\n放置时：发现读心团子和自闭团子\n新的一天：2格内永久水<0的格子+1水"
    };
    public static Build sign_12 = new()
    {
        index = 12,
        info = "咖啡店\n放置时：发现红酒团子\n新的一天：2格内的每个团子使时间回退00:05"
    };
    public static Build sign_13 = new()
    {
        index = 13,
        info = "寺院\n放置时：发现僵尸团子\n新的一天：2格内空格+1水"
    };
    public static Build sign_14 = new()
    {
        index = 14,
        info = "核能中心\n放置时：发现核能团子\n放置时：所有格子+2水\n新的一天：4格内-1水"
    };
    public static Build sign_15 = new()
    {
        index = 15,
        info = "有顶天\n放置时：发现桃子（暂缺）\n持续：3-5格内+1水，1-2格内+2水"
    };
    public static Build sign_16 = new()
    {
        index = 16,
        info = "地狱\n放置时：发现怨灵团子\n新的一天：若相邻6格都存在团子：+2建筑"
    };
    public static Build sign_17 = new()
    {
        index = 17,
        info = "黄鹤楼\n放置时：发现彩虹团子\n持续：2格内+1水\n新的一天：随机获得一个1级团子"
    };

    public void Put(Build sign, Hex hex)
    {
        hex.godan = Instantiate(ImageSign(sign.index), hex.image.transform);
        hex.ahex.twater.text = "";
        hex.empty = false;
        hex.sign = true;
        hex.build = sign;
        hex.dango = Dangoset.instance.dango_XX;
        hex.image.GetComponent<Button>().interactable = false;
        switch (sign.index)
        {
            case 0:
                Dangoset.instance.Box(Dangoset.instance.dango_05);
                break;
            case 1:
                Dangoset.instance.Box(Dangoset.instance.dango_06);
                break;
            case 2:
                Dangoset.instance.Box(Dangoset.instance.dango_16);
                break;
            case 3:
                Dangoset.instance.Box(Dangoset.instance.dango_12);
                Dangoset.instance.Box(Dangoset.instance.dango_17);
                Dangoset.instance.dango_01.time -= Dangoset.instance.dango_01.time / 3;
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_01.index).time.text = Game.Time(Dangoset.instance.dango_01.time);
                Dangoset.instance.dango_12.time -= Dangoset.instance.dango_12.time / 3;
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_12.index).time.text = Game.Time(Dangoset.instance.dango_12.time);
                Dangoset.instance.dango_17.time -= Dangoset.instance.dango_17.time / 3;
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_17.index).time.text = Game.Time(Dangoset.instance.dango_17.time);
                foreach (Hex h in hex.Distance(Map.instance.hexs, 1))
                {
                    h.Water(3);
                }
                break;
            case 4:
                Dangoset.instance.Box(Dangoset.instance.dango_22);
                foreach (Hex h in hex.Distance(Map.instance.hexs, 1))
                {
                    h.Water(1);
                }
                break;
            case 5:
                Dangoset.instance.Box(Dangoset.instance.dango_23, 2);
                Game.Miracle(1);
                break;
            case 6:
                Dangoset.instance.Box(Dangoset.instance.dango_29);
                break;
            case 7:
                Dangoset.instance.Box(Dangoset.instance.dango_35, 2);
                Dangoset.instance.Box(Dangoset.instance.dango_36);
                break;
            case 8:
                Dangoset.instance.Box(Dangoset.instance.dango_03);
                Dangoset.instance.Box(Dangoset.instance.dango_04);
                Dangoset.instance.Box(Dangoset.instance.dango_38);
                Dangoset.instance.dango_03.water = 2;
                Dangoset.instance.dango_04.water = 2;
                Dangoset.instance.dango_38.water = 2;
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_03.index).twater.text = Dangoset.instance.dango_03.water.ToString();
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_04.index).twater.text = Dangoset.instance.dango_04.water.ToString();
                Dangoset.instance.boxs.Find(db => db.refer_dango.index == Dangoset.instance.dango_38.index).twater.text = Dangoset.instance.dango_38.water.ToString();
                foreach (Hex h in hex.Distance(Map.instance.hexs, 1))
                {
                    h.Water(2);
                }
                break;
            case 9:
                Dangoset.instance.Box(Dangoset.instance.dango_39);
                break;
            case 10:
                Dangoset.instance.Box(Dangoset.instance.dango_08);
                Game.Miracle(1);
                break;
            case 11:
                Dangoset.instance.Box(Dangoset.instance.dango_49);
                Dangoset.instance.Box(Dangoset.instance.dango_50);
                break;
            case 12:
                Dangoset.instance.Box(Dangoset.instance.dango_09);
                break;
            case 13:
                Dangoset.instance.Box(Dangoset.instance.dango_61);
                break;
            case 14:
                Dangoset.instance.Box(Dangoset.instance.dango_51);
                foreach(Hex h in Map.instance.hexs_active)
                {
                    h.Water_pe(2);
                }
                break;
            case 15:
                //Dangoset.instance.Box(Dangoset.instance.dango_05);
                foreach (Hex h in hex.Distance(Map.instance.hexs, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(Map.instance.hexs, 2))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(Map.instance.hexs, 3))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(Map.instance.hexs, 4))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(Map.instance.hexs, 5))
                {
                    h.Water(1);
                }
                break;
            case 16:
                Dangoset.instance.Box(Dangoset.instance.dango_52, 2);
                break;
            case 17:
                Dangoset.instance.Box(Dangoset.instance.dango_13);
                foreach (Hex h in hex.Distance(Map.instance.hexs, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(Map.instance.hexs, 2))
                {
                    h.Water(1);
                }
                break;
        }
        if (PlayerPrefs.GetInt("s" + sign.index.ToString()) == 0)
        {
            GameObject gol = Instantiate(Buildbox, librarybox.transform);
            Buildbox dbl = gol.GetComponent<Buildbox>();
            dbl.clickmode = "lock";
            dbl.Build = signall.Find(m => m.index == sign.index);
            GameObject ims = Instantiate(ImageSign(sign.index), gol.transform);
            gol.transform.localScale = new Vector3(0.4f, 0.4f);
            gol.transform.localPosition = (80 * (librarydb.Count)) * Vector3.down + 100*Vector3.right;
            librarydb.Add(dbl);
            librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            PlayerPrefs.SetInt("Build", PlayerPrefs.GetInt("Build") + 1);
        }
        PlayerPrefs.SetInt("s" + sign.index.ToString(), 1);
        libBuild_number.text = libBuild_number.text = "Build:" + PlayerPrefs.GetInt("Build").ToString() + "/" + signall.Count.ToString();
    }

    public GameObject ImageSign(int index)
    {
        return index switch
        {
            0 => Image_00,
            1 => Image_01,
            2 => Image_02,
            3 => Image_03,
            4 => Image_04,
            5 => Image_05,
            6 => Image_06,
            7 => Image_07,
            8 => Image_08,
            9 => Image_09,
            10 => Image_10,
            11 => Image_11,
            12 => Image_12,
            13 => Image_13,
            14 => Image_14,
            15 => Image_15,
            16 => Image_16,
            17 => Image_17,
            _ => null
        };
    }
    public void Build()
    {
        int k = Mathf.Min(3, signinchest.Count);
        switch (k)
        {
            case 0:
                Game.Info("You have built all signs!");
                return;
            case 1:
                Build m1 = signinchest[0];
                Build1 = Instantiate(Buildbox, Map.instance.canvas.transform);
                GameObject g1 = Instantiate(ImageSign(m1.index), Build1.transform);
                g1.transform.localPosition += Vector3.left * 135;
                Buildbox mi = Build1.GetComponent<Buildbox>();
                mi.clickmode = "click";
                mi.info.text = m1.info;
                mi.Build = m1;
                break;
            case 2:
                Build m21 = signinchest[0];
                Build1 = Instantiate(Buildbox, Map.instance.canvas.transform);
                GameObject g21 = Instantiate(ImageSign(m21.index), Build1.transform);
                g21.transform.localPosition += Vector3.left * 135;
                Buildbox mi21 = Build1.GetComponent<Buildbox>();
                mi21.clickmode = "click";
                mi21.info.text = m21.info;
                mi21.Build = m21;
                Build m22 = signinchest[1];
                Build2 = Instantiate(Buildbox, Map.instance.canvas.transform);
                Build2.transform.position += Vector3.down * 225;
                GameObject g22 = Instantiate(ImageSign(m22.index), Build2.transform);
                g22.transform.localPosition += Vector3.left * 135;
                Buildbox mi22 = Build2.GetComponent<Buildbox>();
                mi22.clickmode = "click";
                mi22.info.text = m22.info;
                mi22.Build = m22;
                break;
            case 3:
                System.Random rnd = new();
                int i1, i2, i3;
                do
                {
                    i1 = rnd.Next(signinchest.Count);
                    i2 = rnd.Next(signinchest.Count);
                    i3 = rnd.Next(signinchest.Count);
                } while (i1 == i2 || i1 == i3 || i2 == i3);
                Build m31 = signinchest[i1];
                Build1 = Instantiate(Buildbox, Map.instance.canvas.transform);
                GameObject g31 = Instantiate(ImageSign(m31.index), Build1.transform);
                g31.transform.localPosition += Vector3.left * 135;
                Buildbox mi31 = Build1.GetComponent<Buildbox>();
                mi31.clickmode = "click";
                mi31.info.text = m31.info;
                mi31.Build = m31;

                Build m32 = signinchest[i2];
                Build2 = Instantiate(Buildbox, Map.instance.canvas.transform);
                Build2.transform.position += Vector3.down * 225;
                GameObject g32 = Instantiate(ImageSign(m32.index), Build2.transform);
                g32.transform.localPosition += Vector3.left * 135;
                Buildbox mi32 = Build2.GetComponent<Buildbox>();
                mi32.clickmode = "click";
                mi32.info.text = m32.info;
                mi32.Build = m32;

                Build m33 = signinchest[i3];
                Build3 = Instantiate(Buildbox, Map.instance.canvas.transform);
                Build3.transform.position += Vector3.down * 450;
                GameObject g33 = Instantiate(ImageSign(m33.index), Build3.transform);
                g33.transform.localPosition += Vector3.left * 135;
                Buildbox mi33 = Build3.GetComponent<Buildbox>();
                mi33.clickmode = "click";
                mi33.info.text = m33.info;
                mi33.Build = m33;
                break;
        }
        built++;
        build -= 8;
        tbuild.text = build.ToString() + "/" + 8;
    }
    public void BuildEvent()
    {
        Destroy(Build1);
        Destroy(Build2);
        Destroy(Build3);
    }
}
