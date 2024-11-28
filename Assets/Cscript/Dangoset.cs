using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Dangoset : MonoBehaviour
{
    public GameObject canvas;
    public static Dangoset instance;
    public List<Dangobox> boxs;
    public List<Dango> dangoall;
    public List<Dango> dangoinmap;
    public List<Dango> dangoinchest;
    public List<Dango> dangoinchest2;
    public Text info;
    public GameObject chest_choice1;
    public GameObject chest_choice2;
    public GameObject chest_choice3;
    public GameObject chest_skip;
    public GameObject chest_skip_prefab;
    public GameObject dangobox;
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
    public GameObject Image_18;
    public GameObject Image_18_1;
    public GameObject Image_18_2;
    public GameObject Image_18_3;
    public GameObject Image_19;
    public GameObject Image_20;
    public GameObject Image_21;
    public GameObject Image_22;
    public GameObject Image_23;
    public GameObject Image_24;
    public GameObject Image_25;
    public GameObject Image_26;
    public GameObject Image_27;
    public GameObject Image_28;
    public GameObject Image_29;
    public GameObject Image_30;
    public GameObject Image_31;
    public GameObject Image_32;
    public GameObject Image_33;
    public GameObject Image_34;
    public GameObject Image_35;
    public GameObject Image_36;
    public GameObject Image_37;
    public GameObject Image_38;
    public GameObject Image_39;
    public GameObject Image_40;
    public GameObject Image_41;
    public GameObject Image_42;
    public GameObject Image_43;
    public GameObject Image_44;
    public GameObject Image_45;
    public GameObject Image_46;
    public GameObject Image_47;
    public GameObject Image_48;
    public GameObject Image_49;
    public GameObject Image_50;
    public GameObject Image_51;
    public GameObject Image_52;
    public GameObject Image_53;
    public GameObject Image_54;
    public GameObject Image_55;
    public GameObject Image_56;
    public GameObject Image_57;
    public GameObject Image_58;
    public GameObject Image_59;
    public GameObject Image_59_1;
    public GameObject Image_59_2;
    public GameObject Image_59_3;
    public GameObject Image_60;
    public GameObject Image_61;
    public GameObject Image_62;
    public GameObject Image_63;
    public GameObject Image_64;
    public GameObject Image_65;
    public GameObject Image_66;
    public GameObject Image_67;
    public GameObject Image_68;
    public GameObject Image_69;
    public GameObject Image_70;
    public GameObject Image_71;
    public GameObject Image_72;
    public GameObject Image_73;
    public GameObject Image_74;
    public GameObject Image_75;
    public GameObject Image_76;
    public GameObject Image_77;
    public GameObject Image_78;
    public GameObject Image_79;
    public GameObject Image_80;
    public GameObject boxbox;

    public GameObject librarybox;
    public List<Dangobox> librarydb;
    public Text libtext;
    public Text libtext2;
    public Text libdango_number;
    public Text libhighday;
    public Text libhighscore;

    public bool sign2 = false;
    public bool dango15 = false;
    public Hex dango19;
    public Hex dango30;
    public Hex dango64;
    public List<Hex> hexactive = new() { };
    public GameObject td34;

    public bool newdaying = false;
    public List<string> Events;

    public bool waterhack = false;
    public bool cheat = false;

    public Dango putting;

    public GameObject buttonnextday;
    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
        dangoall = new List<Dango>
        {
            dango_00, dango_01, dango_02, dango_03, dango_04, dango_05, dango_06, dango_07, dango_08, dango_09, dango_10,
            dango_11, dango_12, dango_13, dango_14, dango_15, dango_16, dango_17, dango_18, dango_19, dango_20, dango_21,
            dango_22, dango_23, dango_24, dango_25, dango_26, dango_27, dango_28, dango_29, dango_30, dango_31, dango_32,
            dango_33, dango_34, dango_35, dango_36, dango_37, dango_38, dango_39, dango_40, dango_41, dango_42, dango_43,
            dango_44, dango_45, dango_46, dango_47, dango_48, dango_49, dango_50, dango_51, dango_52, dango_53, dango_54,
            dango_55, dango_56, dango_57, dango_58, dango_59, dango_60, dango_61, dango_62, dango_63, dango_64, dango_65,
            dango_66, dango_67, dango_68, dango_69, dango_70, dango_71, dango_72, dango_73, dango_74, dango_75,
            dango_76, dango_77, dango_78, dango_79, dango_80,
        };
        dangoinchest = new List<Dango>
        {
            dango_00, dango_01, dango_02, dango_03, dango_04, dango_05, dango_06, dango_07, dango_08, dango_09, dango_11,
            dango_12, dango_13, dango_16, dango_17, dango_18, dango_22, dango_27, dango_28, dango_29, dango_30, dango_31,
            dango_32, dango_36, dango_38, dango_39, dango_41, dango_43, dango_45, dango_47, dango_49, dango_50, dango_51,
            dango_53, dango_54, dango_55, dango_56, dango_59, dango_61, dango_62, dango_67, dango_68, dango_69, dango_75,
            dango_80,
        };
        dangoinchest2 = new List<Dango>
        {
            dango_10, dango_14, dango_15, dango_19, dango_20, dango_21, dango_23, dango_24, dango_25, dango_26, dango_33,
            dango_34, dango_35, dango_37, dango_40, dango_42, dango_44, dango_46, dango_48, dango_52, dango_57, dango_58,
            dango_60, dango_63, dango_64, dango_65, dango_66, dango_70, dango_71, dango_72, dango_73, dango_74, dango_76,
            dango_77, dango_78, dango_79,
        };
        dangoinmap = new List<Dango> { };
        foreach(Dango dango in dangoinchest)
        {
            if (PlayerPrefs.GetInt(dango.index.ToString()) == 1)
            {
                GameObject gol = Instantiate(dangobox, librarybox.transform);
                Dangobox dbl = gol.GetComponent<Dangobox>();
                dbl.clickmode = "lock";
                dbl.refer_dango = dango;
                dbl.twater.text = dango.water.ToString();
                dbl.time.text = Game.Time(dango.time);
                Destroy(dbl.dango);
                dbl.dango = Instantiate(ImageDango(dango.index), gol.transform);
                dbl.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
                dbl.dango.transform.localScale = new Vector3(0.8f, 0.8f);
                gol.transform.localPosition += 80 * (librarydb.Count + 1) * Vector3.down;
                librarydb.Add(dbl);
                librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            }
        }
        foreach (Dango dango in dangoinchest2)
        {
            if (PlayerPrefs.GetInt(dango.index.ToString()) == 1)
            {
                GameObject gol = Instantiate(dangobox, librarybox.transform);
                gol.GetComponent<Image>().color = new Color(0.4f, 0.6f, 0.2f);
                Dangobox dbl = gol.GetComponent<Dangobox>();
                dbl.clickmode = "lock";
                dbl.refer_dango = dango;
                dbl.twater.text = dango.water.ToString();
                dbl.time.text = Game.Time(dango.time);
                Destroy(dbl.dango);
                dbl.dango = Instantiate(ImageDango(dango.index), gol.transform);
                dbl.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
                dbl.dango.transform.localScale = new Vector3(0.8f, 0.8f);
                gol.transform.localPosition += 80 * (librarydb.Count + 1) * Vector3.down;
                librarydb.Add(dbl);
                librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            }
        }
        Box(dango_00);
        Box(dango_01);
        Box(dango_02);
        libdango_number.text = "Dango:" + PlayerPrefs.GetInt("dango").ToString() + "/" + dangoall.Count.ToString();
        libhighday.text = "High days:" + PlayerPrefs.GetInt("day").ToString();
        libhighscore.text = "High score:" + PlayerPrefs.GetInt("score").ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach(Dango d in dangoall)
            {
                Box(d);
            }
            cheat = true;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            waterhack = !waterhack;
            cheat = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Game.Build(8);
            cheat = true;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Game.Miracle(4);
            cheat = true;
        }
    }
    public Dango dango_XX = new()
    {
        info = "bug团子\n持续：???",
        index = -1,
        name = "pea",
        food = -1,
        water = -1,
        time = -1
    };
    public Dango dango_00 = new()
    {
        info = "豌豆团子\n持续：1格内+1水",
        index = 0,
        name = "pea",
        food = 1,
        water = 2,
        time = 120
    };
    public Dango dango_01 = new()
    {
        info = "水团子\n持续：1格内+1水",
        index = 1,
        name = "water",
        food = 1,
        water = 0,
        time = 150
    };
    public Dango dango_02 = new()
    {
        info = "宝箱团子\n放置时：获取一个新团子，+1建筑\n会涨价",
        index = 2,
        name = "chest",
        food = 1,
        water = 0,
        time = 150
    };
    public Dango dango_03 = new()
    {
        info = "双豌豆团子\n是2个团子\n持续：1格内+1水",
        index = 3,
        name = "twinpea",
        food = 2,
        water = 4,
        time = 180
    };
    public Dango dango_04 = new()
    {
        info = "红豆团子\n持续：1格内+2水",
        index = 4,
        name = "pink",
        food = 1,
        water = 5,
        time = 150
    };
    public Dango dango_05 = new()
    {
        info = "符札团子\n放置时：选择一格+2水",
        index = 5,
        name = "spellcard",
        food = 1,
        water = 3,
        time = 150
    };
    public Dango dango_06 = new()
    {
        info = "蘑菇团子\n持续：1格内-1水",
        index = 6,
        name = "mushroom",
        food = 1,
        water = 2,
        time = 60
    };
    public Dango dango_07 = new()
    {
        info = "光芒团子\n持续：1-2格内+1水",
        index = 7,
        name = "light",
        food = 1,
        water = 6,
        time = 120
    };
    public Dango dango_08 = new()
    {
        info = "信仰团子\n是3个团子\n放置时：+1奇迹",
        index = 8,
        name = "fate",
        food = 3,
        water = 9,
        time = 120
    };
    public Dango dango_09 = new()
    {
        info = "红酒团子\n放置时：吃一格团子，每个团子回退15分钟\n持续：1格内+1水",
        index = 9,
        name = "wine",
        food = 1,
        water = 3,
        time = 120
    };
    public Dango dango_10 = new()
    {
        info = "嫉妒团子\n放置时：使幽幽子饭量-1\n持续：1格内+1水\n会涨价",
        index = 10,
        name = "jealous",
        food = 1,
        water = 5,
        time = 180
    };
    public Dango dango_11 = new()
    {
        info = "黑暗团子\n放置时：时间前进至24点\n新的一天：变成一个其他随机团子",
        index = 11,
        name = "darkness",
        food = 1,
        water = 0,
        time = 0
    };
    public Dango dango_12 = new()
    {
        info = "冰团子\n被吃时：生成一个水团子",
        index = 12,
        name = "ice",
        food = 1,
        water = 3,
        time = 150
    };
    public Dango dango_13 = new()
    {
        info = "彩虹团子\n持续：1格内+1水\n放置时：若场上至少存在7种团子(不包括自身)，1格内+1水、+1奇迹",
        index = 13,
        name = "rainbow",
        food = 1,
        water = 2,
        time = 240
    };
    public Dango dango_14 = new()
    {
        info = "魔法球团子\n是3个团子\n放置时：选择1格：+7水",
        index = 14,
        name = "magicball",
        food = 3,
        water = 7,
        time = 420
    };
    public Dango dango_15 = new()
    {
        info = "怀表团子\n放置时：下一个团子无需耗时\n会涨价*",
        index = 15,
        name = "clock",
        food = 1,
        water = 4,
        time = 150
    };
    public Dango dango_16 = new()
    {
        info = "血液团子\n是2个团子\n无需满足水需求也可以制作，但每少1水多耗时00:30",
        index = 16,
        name = "blood",
        food = 2,
        water = 7,
        time = 90
    };
    public Dango dango_17 = new()
    {
        info = "雪花团子\n持续：1格内+1水\n放置时：本格+3水",
        index = 17,
        name = "snow",
        food = 1,
        water = 3,
        time = 180
    };
    public Dango dango_18 = new()
    {
        info = "猫团子\n同一格可以放3个\n持续：1格内+1水",
        index = 18,
        name = "cat",
        food = 1,
        water = 2,
        time = 150
    };
    public Dango dango_19 = new()
    {
        info = "人偶团子\n是2个团子\n可以花00:30使其移动一格",
        index = 19,
        name = "shanghai",
        food = 2,
        water = 6,
        time = 120
    };
    public Dango dango_20 = new()
    {
        info = "春天团子\n放置时：幽幽子食量+2\n持续：2格内+3水",
        index = 20,
        name = "spring",
        food = 1,
        water = 4,
        time = 60
    };
    public Dango dango_21 = new()
    {
        info = "幽灵团子\n是4个团子\n持续：3格内+1水",
        index = 21,
        name = "ghost",
        food = 4,
        water = 12,
        time = 150
    };
    public Dango dango_22 = new()
    {
        info = "半灵团子\n放置时/新的一天/被吃时：随机相邻1格+1水",
        index = 22,
        name = "halfspirit",
        food = 1,
        water = 2,
        time = 120
    };
    public Dango dango_23 = new()
    {
        info = "樱花团子\n放置时：+1奇迹\n持续：幽幽子饭量-2\n会涨价*",
        index = 23,
        name = "sakura",
        food = 1,
        water = 8,
        time = 300
    };
    public Dango dango_24 = new()
    {
        info = "九尾团子\n持续：1格内+1水\n放置时：提前喂食一格团子",
        index = 24,
        name = "ninetail",
        food = 1,
        water = 5,
        time = 150
    };
    public Dango dango_25 = new()
    {
        info = "间隙团子\n新的一天：1格内生成一个随机团子\n会涨价",
        index = 25,
        name = "portal",
        food = 1,
        water = 8,
        time = 150
    };
    public Dango dango_26 = new()
    {
        info = "荧光团子\n是4个团子\n只能在00:00-06:00内放置",
        index = 26,
        name = "flash",
        food = 4,
        water = 13,
        time = 90
    };
    public Dango dango_27 = new()
    {
        info = "小碎骨团子\n不可食用\n放置时：喂食幽幽子3个团子",
        index = 27,
        name = "leftbone",
        food = 0,
        water = 5,
        time = 120
    };
    public Dango dango_28 = new()
    {
        info = "四方帽团子\n放置时：使一种在场团子的制作时间节省1/6(每种限一次)",
        index = 28,
        name = "quadhat",
        food = 1,
        water = 8,
        time = 210
    };
    public Dango dango_29 = new()
    {
        info = "胡萝卜团子\n放置时：本格-3水\n持续：1格内+3水",
        index = 29,
        name = "carrot",
        food = 1,
        water = 5,
        time = 120
    };
    public Dango dango_30 = new()
    {
        info = "红眼团子\n是2个团子\n持续：射线上所有格子+2水",
        index = 30,
        name = "redeyes",
        food = 2,
        water = 4,
        time = 240
    };
    public Dango dango_31 = new()
    {
        info = "2级宝箱团子\n放置时：获取一个新团子，+1建筑\n会涨价",
        index = 31,
        name = "chest2",
        food = 1,
        water = 8,
        time = 120
    };
    public Dango dango_32 = new()
    {
        info = "月球团子\n持续：2格内+2水",
        index = 32,
        name = "moon",
        food = 1,
        water = 6,
        time = 300
    };
    public Dango dango_33 = new()
    {
        info = "蓬莱团子\n是5个团子\n放置时：若处于地图边缘，+3奇迹",
        index = 33,
        name = "hourai",
        food = 5,
        water = 18,
        time = 90
    };
    public Dango dango_34 = new()
    {
        info = "火鸟团子\n有9条命\n放置时：0-2格内-2水",
        index = 34,
        name = "phoneix",
        food = 1,
        water = 15,
        time = 150
    };
    public Dango dango_35 = new()
    {
        info = "铜钱团子\n是6个团子\n放置时：使一种在场团子的水需求-1(每种限一次)",
        index = 35,
        name = "river",
        food = 6,
        water = 12,
        time = 540
    };
    public Dango dango_36 = new()
    {
        info = "黑白团子\n是2个团子\n持续：1格内+1水\n放置时：将一个团子送去冥界，该格+2水",
        index = 36,
        name = "blackwhite",
        food = 2,
        water = 2,
        time = 270
    };
    public Dango dango_37 = new()
    {
        info = "毒素团子\n持续：1格内-4水\n新的一天：生成一个人偶团子",
        index = 37,
        name = "toxic",
        food = 1,
        water = 10,
        time = 150
    };
    public Dango dango_38 = new()
    {
        info = "向日葵团子\n持续：1格内+1水\n新的一天：本格+1水",
        index = 38,
        name = "sunflower",
        food = 1,
        water = 4,
        time = 120
    };
    public Dango dango_39 = new()
    {
        info = "落叶团子\n放置时：每存在一个其他落叶团子，时间前进00:20",
        index = 39,
        name = "fallen",
        food = 1,
        water = 3,
        time = 20
    };
    public Dango dango_40 = new()
    {
        info = "葡萄团子\n是10个团子\n放置时：本格-10水",
        index = 40,
        name = "grape",
        food = 10,
        water = 24,
        time = 120
    };
    public Dango dango_41 = new()
    {
        info = "旋转团子\n持续：1格内+2水\n放置时：25%使1格内-2水",
        index = 41,
        name = "spin",
        food = 1,
        water = 4,
        time = 90
    };
    public Dango dango_42 = new()
    {
        info = "钥匙团子\n放置时：吃掉并打开一个宝箱团子",
        index = 42,
        name = "key",
        food = 1,
        water = 6,
        time = 240
    };
    public Dango dango_43 = new()
    {
        info = "盾牌团子\n持续：1格内+1水，防止本格水被非持续效果减少",
        index = 43,
        name = "sheild",
        food = 1,
        water = 4,
        time = 90
    };
    public Dango dango_44 = new()
    {
        info = "绒球团子\n是6个团子\n放置时：选择一个团子随机移动",
        index = 44,
        name = "hat",
        food = 6,
        water = 9,
        time = 360
    };
    public Dango dango_45 = new()
    {
        info = "御柱团子\n是4个团子\n持续：同一竖线格内水+3",
        index = 45,
        name = "wood",
        food = 4,
        water = 7,
        time = 360
    };
    public Dango dango_46 = new()
    {
        info = "青蛙团子\n持续：1格内+1水\n奇迹发生时：3格内+1水",
        index = 46,
        name = "frog",
        food = 1,
        water = 6,
        time = 180
    };
    public Dango dango_47 = new()
    {
        info = "桶装团子\n是3个团子\n新的一天：变成3个水需求小于4的团子",
        index = 47,
        name = "bucket",
        food = 3,
        water = 5,
        time = 270
    };
    public Dango dango_48 = new()
    {
        info = "西瓜团子\n持续：1格内+4水",
        index = 48,
        name = "watermelon",
        food = 1,
        water = 10,
        time = 150
    };
    public Dango dango_49 = new()
    {
        info = "读心团子\n持续：1格内+3水\n1格内放置团子时：该格-1水",
        index = 49,
        name = "satori",
        food = 1,
        water = 4,
        time = 120
    };
    public Dango dango_50 = new()
    {
        info = "自闭团子\n1格内放置团子时：该格+1水",
        index = 50,
        name = "koishi",
        food = 1,
        water = 4,
        time = 120
    };
    public Dango dango_51 = new()
    {
        info = "核能团子\n不可食用\n持续：3格内+2水\n新的一天：爆炸，0-1格内-1水",
        index = 51,
        name = "nuke",
        food = 0,
        water = 5,
        time = 120
    };
    public Dango dango_52 = new()
    {
        info = "怨灵团子\n放置时：+1建筑，本格-1水",
        index = 52,
        name = "hell",
        food = 1,
        water = 6,
        time = 150
    };
    public Dango dango_53 = new()
    {
        info = "寻宝团子\n是2个团子\n放置时：40%+1奇迹或建筑\n若本格至少有8水：概率翻倍",
        index = 53,
        name = "compass",
        food = 2,
        water = 4,
        time = 180
    };
    public Dango dango_54 = new()
    {
        info = "小伞团子\n持续：1格内+2水\n可以花费00:30随机移动",
        index = 54,
        name = "unbrella",
        food = 1,
        water = 7,
        time = 180
    };
    public Dango dango_55 = new()
    {
        info = "铁拳团子\n放置时：击碎一个相邻团子，本格+3水",
        index = 55,
        name = "fist",
        food = 1,
        water = 2,
        time = 150
    };
    public Dango dango_56 = new()
    {
        info = "船锚团子\n持续：仅2格内+2水\n放置时：0-1格-2水",
        index = 56,
        name = "sinking",
        food = 1,
        water = 8,
        time = 120
    };
    public Dango dango_57 = new()
    {
        info = "宝塔团子\n持续：所有直线上的格子+1水\n放置时：+2奇迹",
        index = 57,
        name = "tower",
        food = 1,
        water = 12,
        time = 90
    };
    public Dango dango_58 = new()
    { 
        info = "佛珠团子\n是14个团子\n放置时：本格水减半，幽幽子食量-1",
        index = 58,
        name = "balls",
        food = 14,
        water = 32,
        time = 120
    };
    public Dango dango_59 = new()
    {
        info = "飞碟团子\n放置时：随机变成一种颜色\n持续：同色集齐3个时，消去同色并且：" +
        "(红)+2奇迹，这3格+2水(绿)喂幽幽子6个团子(蓝)+2建筑",
        index = 59,
        name = "ufo",
        food = 1,
        water = 6,
        time = 80
    };
    public Dango dango_60 = new()
    {
        info = "回声团子\n持续：本格加水时(非持续效果)，随机相邻1空格加相同水",
        index = 60,
        name = "sound",
        food = 1,
        water = 8,
        time = 150
    };
    public Dango dango_61 = new()
    {
        info = "僵尸团子\n新的一天：吃所有1格内团子，每个团子给原在格+2水",
        index = 61,
        name = "zombie",
        food = 1,
        water = 0,
        time = 150
    };
    public Dango dango_62 = new()
    {
        info = "穿墙团子\n放置在非边缘格额外花02:00\n持续：1格内+3水",
        index = 62,
        name = "cross",
        food = 1,
        water = 4,
        time = 90
    };
    public Dango dango_63 = new()
    {
        info = "闪电团子\n持续：1格内+1水\n放置时：本格每有8点水，随机放置一个闪电团子到相邻格(会连锁反应)",
        index = 63,
        name = "lightning",
        food = 1,
        water = 8,
        time = 180
    };
    public Dango dango_64 = new()
    {
        info = "行舟团子\n持续：1格内+3水\n可以免费移动至满足水需求的相邻格",
        index = 64,
        name = "boat",
        food = 1,
        water = 10,
        time = 180
    };
    public Dango dango_65 = new()
    {
        info = "天球团子\n是7个团子\n放置时：+1奇迹，+1建筑",
        index = 65,
        name = "stars",
        food = 7,
        water = 21,
        time = 240
    };
    public Dango dango_66 = new()
    {
        info = "随机团子\n放置时：变身为场上随机一格团子",
        index = 66,
        name = "what",
        food = 1,
        water = 10,
        time = 150
    };
    public Dango dango_67 = new()
    {
        info = "人鱼团子\n持续：1格内+1水\n被吃时：1格内+1水",
        index = 67,
        name = "fish",
        food = 1,
        water = 5,
        time = 180
    };
    public Dango dango_68 = new()
    {
        info = "悬浮团子\n是3个团子\n持续：1格内+1水",
        index = 68,
        name = "float",
        food = 3,
        water = 6,
        time = 240
    };
    public Dango dango_69 = new()
    {
        info = "狼人团子\n持续：1格内+1水\n新的一天：20%变身，效果x4",
        index = 69,
        name = "wolf",
        food = 1,
        water = 3,
        time = 120
    };
    public Dango dango_70 = new()
    {
        info = "音符团子\n持续：1格内+1水\n放置时：选择1格+4水",
        index = 70,
        name = "note",
        food = 1,
        water = 12,
        time = 120
    };
    public Dango dango_71 = new()
    {
        info = "逆天团子\n只能在小于等于水需求的格子放置\n放置时：选择一格改变水的符号",
        index = 71,
        name = "reverse",
        food = 1,
        water = -7,
        time = 150
    };
    public Dango dango_72 = new()
    {
        info = "宝槌团子\n放置时：选择场上的一个团子，将其大小和制作时间翻倍(每种限一次)",
        index = 72,
        name = "cross",
        food = 1,
        water = 20,
        time = 120
    };
    public Dango dango_73 = new()
    {
        info = "太鼓团子\n放置时：本格-8水，1-2格内+1水",
        index = 73,
        name = "lightning",
        food = 1,
        water = 12,
        time = 180
    };
    public Dango dango_74 = new()
    {
        info = "年糕团子\n是3个团子\n放置时：若场上有3个其他年糕团子：喂食幽幽子2个团子",
        index = 74,
        name = "boat",
        food = 3,
        water = 12,
        time = 120
    };
    public Dango dango_75 = new()
    {
        info = "经典团子\n是3个团子\n放置时：本格-1水",
        index = 75,
        name = "stars",
        food = 3,
        water = 5,
        time = 120
    };
    public Dango dango_76 = new()
    {
        info = "睡梦团子\n持续：1格内每次放置团子：多花费00:20且幽幽子当天饭量-1",
        index = 76,
        name = "what",
        food = 1,
        water = 14,
        time = 90
    };
    public Dango dango_77 = new()
    {
        info = "星条团子\n持续：2格内+2水\n新的一天：花费00:30",
        index = 77,
        name = "fish",
        food = 1,
        water = 6,
        time = 150
    };
    public Dango dango_78 = new()
    {
        info = "纯粹团子\n持续：1格内+10水",
        index = 78,
        name = "float",
        food = 1,
        water = 22,
        time = 270
    };
    public Dango dango_79 = new()
    {
        info = "空间团子\n是3个团子\n新的一天：将一格团子流放到异界，每个团子+1建筑",
        index = 79,
        name = "ufo",
        food = 3,
        water = 14,
        time = 120
    };
    public Dango dango_80 = new()
    {
        info = "蝴蝶团子\n持续：1格内+1水\n放置时：选择一个格子：放置一个蝴蝶团子(不连锁反应)",
        index = 80,
        name = "note",
        food = 1,
        water = 7,
        time = 150
    };


    public void Put(List<Hex> map, Dango dango,Hex hex)
    {
        putting = dango;
        if (dango.index != 18)
        {
            hex.godan = Instantiate(ImageDango(dango.index), hex.image.transform);
        }
        hex.ahex.twater.text = "";
        hex.empty = false;
        hex.dango = dango;
        switch (dango.index)
        {
            case 0:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 1:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                //Game.Miracle(1);
                break;
            case 2:
                Game.Events("dango02");
                break;
            case 3:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 4:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                break;
            case 5:
                Game.Events("dango05");
                break;
            case 6:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 7:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(1);
                }
                break;
            case 8:
                Game.Miracle(1);
                break;
            case 9:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Game.Events("dango09");
                break;
            case 10:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Map.instance.real_yuyuko -= 1;
                Game.Yuyuko(-1);
                Game.Food(0);
                dango_10.water += 1;
                boxs.Find(d10 => d10.refer_dango.index == 10).twater.text = dango_10.water.ToString();
                break;
            case 11:
                
                break;
            case 12:
                Game.Food(1);
                break;
            case 13:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                List<int> ld = new();
                foreach(Hex h in Map.instance.hexs)
                {
                    if (!h.empty && h != hex)
                    {
                        ld.Add(h.dango.index);
                    }
                }
                if(ld.Distinct().Count() >= 7)
                {
                    Game.Miracle(1);
                    foreach (Hex h in hex.Distance(map, 1))
                    {
                        h.Water_pe(1);
                    }
                }
                break;
            case 14:
                Game.Events("dango14");
                break;
            case 15:
                dango15 = true;
                dango_15.water += 2;
                boxs.Find(d15 => d15.refer_dango.index == 15).twater.text = dango_15.water.ToString();
                break;
            case 17:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 0))
                {
                    h.Water_pe(3);
                }
                break;
            case 18:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                hex.dango18 += 1;
                Destroy(hex.godan);
                switch (hex.dango18)
                {
                    case 1:
                        hex.godan = Instantiate(Image_18_1, hex.image.transform);
                        hex.ahex.twater.text = hex.water.ToString();
                        break;
                    case 2:
                        hex.godan = Instantiate(Image_18_2, hex.image.transform);
                        hex.ahex.twater.text = hex.water.ToString();
                        break;
                    case 3:
                        hex.godan = Instantiate(Image_18_3, hex.image.transform);
                        break;
                }
                break;
            case 20:
                Map.instance.real_yuyuko += 2;
                Game.Yuyuko(2);
                Game.Food(0);
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(3);
                }
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 21:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(1);
                }
                break;
            case 22:
                System.Random random = new();
                hex.Distance(Map.instance.hexs_active, 1)[random.Next(hex.Distance(Map.instance.hexs_active, 1).Count)].Water_pe(1);
                break;
            case 23:
                dango_23.water += 2;
                boxs.Find(d10 => d10.refer_dango.index == 23).twater.text = dango_23.water.ToString();
                Game.Miracle(1);
                Map.instance.real_yuyuko -= 2;
                Game.Yuyuko(-2);
                Game.Food(0);
                break;
            case 24:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Game.Events("dango24");
                break;
            case 25:
                dango_25.water += 1;
                boxs.Find(d25 => d25.refer_dango.index == 25).twater.text = dango_25.water.ToString();
                break;
            case 27:
                Game.Yuyuko(-3);
                break;
            case 28:
                Game.Events("dango28");
                break;
            case 29:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                foreach (Hex h in hex.Distance(map, 0))
                {
                    h.Water_pe(-3);
                }
                break;
            case 30:
                dango30 = hex;
                hexactive.Add(hex);
                Game.Events("dango30");
                break;
            case 31:
                Game.Events("dango31");
                break;
            case 32:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                break;
            case 33:
                if(hex.x == Map.instance.smx || hex.x == Map.instance.snx ||
                   hex.y == Map.instance.smy || hex.y == Map.instance.sny ||
                   hex.z == Map.instance.smz || hex.z == Map.instance.snz)
                {
                    Game.Miracle(3);
                }
                break;
            case 34:
                hex.dango34 += 9;
                Game.Food(8);
                if(hex.dango34 == 9)
                {
                    foreach (Hex h in hex.Distance(map, 0))
                    {
                        h.Water_pe(-2);
                    }
                    foreach (Hex h in hex.Distance(map, 1))
                    {
                        h.Water_pe(-2);
                    }
                    foreach (Hex h in hex.Distance(map, 2))
                    {
                        h.Water_pe(-2);
                    }
                }
                hex.td34 = Instantiate(td34, hex.image.transform);
                hex.td34.GetComponent<Text>().text = hex.dango34.ToString();
                break;
            case 35:
                Game.Events("dango35");
                break;
            case 36:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Game.Events("dango36");
                break;
            case 37:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-4);
                }
                break;
            case 38:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 39:
                foreach(Hex h in Map.instance.hexs_active)
                {
                    if(h != hex && !h.empty && h.dango.index == 39)
                    {
                        Map.instance.Time(20);
                    }
                }
                break;
            case 40:
                hex.Water_pe(-10);
                break;
            case 41:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                if (UnityEngine.Random.Range(0f, 1f) < 0.25f)
                {
                    foreach (Hex h in hex.Distance(map, 1))
                    {
                        h.Water_pe(-2);
                    }
                };
                break;
            case 42:
                Game.Events("dango42");
                break;
            case 43:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 44:
                Game.Events("dango44");
                break;
            case 45:
                foreach(Hex h in Map.instance.hexs)
                {
                    if(h.x == hex.x)
                    {
                        h.Water(3);
                    }
                }
                break;
            case 46:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 48:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(4);
                }
                break;
            case 49:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 50:
                break;
            case 51:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(2);
                }
                break;
            case 52:
                Game.Build(1);
                hex.Water_pe(-1);
                break;
            case 53:
                float p = 0.4f;
                if(hex.water >= 8)
                {
                    p = 0.8f;
                }
                if(UnityEngine.Random.Range(0f,1f) < p)
                {
                    if (UnityEngine.Random.Range(0f, 1f) < 0.5f)
                    {
                        Game.Miracle(1);
                    }
                    else
                    {
                        Game.Build(1);
                    }
                }
                break;
            case 54:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                break;
            case 55:
                hexactive.Add(hex);
                Game.Events("dango55");
                break;
            case 56:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water_pe(-2);
                }
                foreach (Hex h in hex.Distance(map, 0))
                {
                    h.Water_pe(-2);
                }
                break;
            case 57:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(1);
                    }
                    if (h.y == hex.y)
                    {
                        h.Water(1);
                    }
                    if (h.z == hex.z)
                    {
                        h.Water(1);
                    }
                }
                Game.Miracle(2);
                break;
            case 58:
                hex.Water_pe(-hex.water / 2);
                Game.Yuyuko(-1);
                Map.instance.real_yuyuko -= 1;
                break;
            case 59:
                Destroy(hex.godan);
                float r = UnityEngine.Random.Range(0f, 1f);
                if(r < 1f / 3f)
                {
                    hex.godan = Instantiate(Image_59_1, hex.image.transform);
                    hex.dango59 = "r";
                }
                else if(r < 2f / 3f)
                {
                    hex.godan = Instantiate(Image_59_2, hex.image.transform);
                    hex.dango59 = "g";
                }
                else
                {
                    hex.godan = Instantiate(Image_59_3, hex.image.transform);
                    hex.dango59 = "b";
                }
                int c = 0;
                List<Hex> hc = new();
                foreach(Hex h in Map.instance.hexs_active)
                {
                    if(h.dango59 == hex.dango59 && !h.empty && !h.sign && h.dango != null && h.dango.index == 59)
                    {
                        c++;
                        Debug.Log(c);
                        hc.Add(h);
                    }
                }
                if(c >= 3)
                {
                    switch (hex.dango59)
                    {
                        case "r":
                            Game.Miracle(2);
                            foreach (Hex dh in hc)
                            {
                                dh.Water_pe(2);
                            }
                            break;
                        case "g":
                            Game.Yuyuko(-6);
                            break;
                        case "b":
                            Game.Build(2);
                            break;
                    }
                    foreach (Hex dh in hc)
                    {
                        Game.Food(-dango_59.food);
                        Eat(Map.instance.hexs_active, dh);
                        dh.dango59 = "";
                    }
                }
                break;
            case 62:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 63:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                int q = Math.Max(0, hex.water / 8);
                List<Hex> lh = new();
                foreach(Hex h in hex.Distance(Map.instance.hexs_active, 1))
                {
                    if (h.empty) { lh.Add(h); }
                }
                q = math.min(q, lh.Count);
                while (q > 0)
                {
                    System.Random a = new();
                    Hex ph = lh[a.Next(lh.Count)];
                    Put(Map.instance.hexs_active, dango_63, ph);
                    Game.Food(dango_63.food);
                    q--;
                    lh.Clear();
                    foreach (Hex h in hex.Distance(Map.instance.hexs_active, 1))
                    {
                        if (h.empty) { lh.Add(h); }
                    }
                    q = math.min(lh.Count, q);
                }
                break;
            case 64:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 65:
                Game.Miracle(1);
                Game.Build(1);
                break;
            case 66:
                List<Dango> lsd = new();
                foreach(Hex h in Map.instance.hexs_active)
                {
                    if(!h.empty && !h.sign && h.dango.index != 66)
                    {
                        lsd.Add(h.dango);
                    }
                }
                if(lsd.Count == 0) { return; }
                System.Random rr = new();
                Eat(Map.instance.hexs, hex);
                Game.Food(-dango_66.food);
                Put(Map.instance.hexs, lsd[rr.Next(lsd.Count)], hex);
                Game.Food(hex.dango.food);
                break;
            case 67:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 68:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 69:
                hex.dango69 = false;
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 70:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Game.Events("dango70");
                break;
            case 71:
                Game.Events("dango71");
                break;
            case 72:
                Game.Events("dango72");
                break;
            case 73:
                hex.Water_pe(-8);
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water_pe(1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water_pe(1);
                }
                break;
            case 74:
                int d74 = 0;
                foreach(Hex h in Map.instance.hexs_active)
                {
                    if(!h.empty && h.dango.index == 74) { d74++; }
                }
                if(d74 > 3) { Game.Yuyuko(-2); }
                break;
            case 75:
                hex.Water_pe(-1);
                break;
            case 77:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                break;
            case 78:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(10);
                }
                break;
            case 79:
                Game.Events("dango79");
                break;
            case 80:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Game.Events("dango80");
                break;
        }
        foreach(Hex h in Map.instance.hexs_active)
        {
            if(h.empty && h.water >= 0) { buttonnextday.SetActive(false); return; }
        }
        buttonnextday.SetActive(true);
    }
    public void Eat(List<Hex> map, Hex hex)
    {
        Destroy(hex.godan);
        hex.ahex.twater.text = hex.water.ToString();
        if(hex.water == 0)
        {
            hex.ahex.twater.text = "";
        }
        hex.empty = true;
        switch (hex.dango.index)
        {
            case 0:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 1:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 3:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 4:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 6:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 7:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-1);
                }
                break;
            case 9:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 10:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 12:
                Put(map, dango_01, hex);
                return;
            case 13:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 17:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 18:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                hex.dango18 -= 1;
                switch (hex.dango18)
                {
                    case 1:
                        hex.godan = new();
                        hex.godan = Instantiate(Image_18_1, hex.image.transform);
                        hex.empty = false;
                        return;
                    case 2:
                        hex.godan = new();
                        hex.godan = Instantiate(Image_18_2, hex.image.transform);
                        hex.empty = false;
                        return;
                }
                break;
            case 20:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-3);
                }
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 21:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(-1);
                }
                break;
            case 22:
                System.Random random = new();
                hex.Distance(Map.instance.hexs_active, 1)[random.Next(hex.Distance(Map.instance.hexs_active, 1).Count)].Water_pe(1);
                break;
            case 23:
                Map.instance.real_yuyuko += 2;
                Game.Yuyuko(2);
                Game.Food(0);
                break;
            case 24:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 29:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 30:
                foreach (Hex h in Map.instance.hexs)
                {
                    Vector3 v3 = new(h.x - hex.x, h.y - hex.y, h.z - hex.z);
                    Debug.Log(v3);
                    Debug.Log(hex.dango30);
                    if (v3.normalized == hex.dango30.normalized)
                    {
                        h.Water(-2);
                    }
                }
                break;
            case 32:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 34:
                Destroy(hex.td34);
                if(hex.dango34 > 1)
                {
                    hex.dango34 -= 10;
                    Game.Food(-8);
                    Put(map, dango_34, hex);
                }
                else
                {
                    hex.dango34 = 0;
                }
                break;
            case 36:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 37:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(4);
                }
                break;
            case 38:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 41:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 43:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 45:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(-3);
                    }
                }
                break;
            case 46:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 48:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-4);
                }
                break;
            case 49:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 51:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(-2);
                }
                break;
            case 54:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 56:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 57:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(-1);
                    }
                    if (h.y == hex.y)
                    {
                        h.Water(-1);
                    }
                    if (h.z == hex.z)
                    {
                        h.Water(-1);
                    }
                }
                break;
            case 62:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 63:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 64:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 67:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                    h.Water_pe(1);
                }
                break;
            case 68:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 69:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                if (hex.dango69)
                {
                    //hex.image.transform.localScale /= 1.5f;
                    Game.Food(-3);
                    if(Game.Clickmode() == "eat")
                    {
                        Game.Yuyuko(-3);
                    }
                    foreach (Hex nh in hex.Distance(Map.instance.hexs, 1))
                    {
                        nh.Water(-3);
                    }
                }
                break;
            case 70:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 77:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 78:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-10);
                }
                break;
            case 80:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
        }
        if(hex.dango34 < 1)
        {
            hex.dango = null;
        }
    }
    public void Newday()
    {
        foreach (Hex h in Map.instance.hexs_active)
        {
            if (!h.empty && h.dango.index == 11 && h.newday)
            {
                h.newday = false;
                Game.Food(-h.dango.food);
                Eat(Map.instance.hexs, h);
                System.Random random = new();
                int i = 0;
                do
                {
                    i = random.Next(dangoinmap.Count);
                } while (i == 11);//防止抽中自己

                Dango d = dangoinmap[i];
                Put(Map.instance.hexs, d, h);
                Game.Food(h.dango.food);
            }
            if (!h.empty && h.dango.index == 22 && h.newday)
            {
                h.newday = false;
                System.Random random = new();
                h.Distance(Map.instance.hexs_active, 1)[random.Next(h.Distance(Map.instance.hexs_active, 1).Count)].Water_pe(1);
            }
            if (!h.empty && h.dango.index == 25 && h.newday)
            {
                List<Hex> ah = new();
                foreach (Hex ph in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (ph.empty) { ah.Add(ph); }
                }
                if (ah.Count == 0)
                {
                    
                }
                else
                {
                    System.Random random = new();
                    int i, j;
                    i = random.Next(dangoinmap.Count);
                    j = random.Next(ah.Count);
                    Dango d = dangoinmap[i];
                    ah[j].newday = false;
                    h.newday = false;
                    Put(Map.instance.hexs, d, ah[j]);
                    Game.Food(d.food);
                    
                }
            }
            if (!h.empty && h.dango.index == 37 && h.newday)
            {
                List<Hex> ah = new();
                foreach (Hex ph in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (ph.empty) { ah.Add(ph); }
                }
                if (ah.Count == 0)
                {
                    
                }
                else
                {
                    System.Random random = new();
                    int j;
                    j = random.Next(ah.Count);
                    ah[j].newday = false;
                    h.newday = false;
                    Put(Map.instance.hexs, dango_19, ah[j]);
                    Game.Food(dango_19.food);
                    
                }
            }
            if (!h.empty && h.dango.index == 38 && h.newday)
            {
                h.newday = false;
                h.Water_pe(1);
            }
            if (!h.empty && h.dango.index == 47 && h.newday)
            {
                List<Hex> lah = new();
                foreach(Hex ah in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (ah.empty) { lah.Add(ah); }
                }
                while (lah.Count > 3)
                {
                    System.Random r = new();
                    lah.Remove(lah[r.Next(lah.Count)]);
                }
                Debug.Log(lah.Count);
                for (int i = 0; i < lah.Count;)
                {
                    Debug.Log(i);
                    System.Random r = new();
                    Hex dh = lah[r.Next(lah.Count)];
                    lah.Remove(dh);
                    Dango d;
                    do
                    {
                        d = dangoinmap[r.Next(dangoinmap.Count)];
                    } while (d.water >= 4);
                    Put(Map.instance.hexs, d, dh);
                    Game.Food(dh.dango.food);
                    dh.newday = false;
                }
                h.newday = false;
                Game.Food(-h.dango.food);
                Eat(Map.instance.hexs, h);
            }
            if (!h.empty && h.dango.index == 51 && h.newday)
            {
                h.newday = false;
                Eat(Map.instance.hexs_active, h);
                foreach(Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    nh.Water_pe(-1);
                }
                h.Water_pe(-1);
            }
            if (!h.empty && h.dango.index == 61 && h.newday)
            {
                h.newday = false;
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    if(!nh.empty && nh.dango.food > 0)
                    {
                        int d69 = 0;
                        if (nh.dango.index == 69 && nh.dango69) { d69 = 3; }
                        nh.Water_pe((nh.dango.food + d69) * 2);
                        Game.Food(-nh.dango.food);
                        Eat(Map.instance.hexs, nh);
                        nh.newday = false;
                    }
                }
            }
            if (!h.empty && h.dango.index == 69 && h.newday)
            {
                h.newday = false;
                if(!h.dango69 && UnityEngine.Random.Range(0f, 1f) < 0.2f)
                {
                    h.dango69 = true;
                    h.godan.transform.localScale *= 1.5f;
                    Game.Food(3);
                    foreach(Hex nh in h.Distance(Map.instance.hexs, 1))
                    {
                        nh.Water(3);
                    }
                }
            }
            if (!h.empty && h.dango.index == 77 && h.newday)
            {
                h.newday = false;
                Map.instance.Time(30);
            }
            if (!h.empty && h.dango.index == 78 && h.newday)
            {
                h.newday = false;
                Game.Events("dango78");
            }
            if (h.sign && h.build.index == 0 && h.newday)
            {
                h.newday = false;
                foreach(Hex ah in h.Distance(Map.instance.hexs_active,1))
                {
                    ah.Water_pe(2);
                }
            }
            if (h.sign && h.build.index == 1 && h.newday)
            {
                h.newday = false;
                foreach (Hex ah in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (ah.empty)
                    {
                        Dango d;
                        do
                        {
                            System.Random r = new();
                            d = dangoinmap[r.Next(dangoinmap.Count)];
                        } while (d.water >= 3);
                        Game.Food(d.food);
                        Put(Map.instance.hexs, d, ah);
                    }
                }
            }
            if (h.sign && h.build.index == 2 && h.newday)
            {
                h.newday = false;
                sign2 = true;
            }
            if (h.sign && h.build.index == 4 && h.newday)
            {
                h.newday = false;
                bool i = true;
                foreach(Hex fh in h.Distance(Map.instance.hexs, 1))
                {
                    if(fh.empty || fh.sign)
                    {
                        i = false;
                    }
                }
                if (i)
                {
                    Map.instance.real_yuyuko -= 1;
                    Game.Yuyuko(-1);
                }
            }
            if (h.sign && h.build.index == 9 && h.newday)
            {
                h.newday = false;
                foreach(Hex ph in h.Distance(Map.instance.hexs_active, 1))
                {
                    if(!ph.empty && !ph.sign)
                    {
                        ph.Water_pe(1);
                    }
                }
                foreach (Hex ph in h.Distance(Map.instance.hexs_active, 2))
                {
                    if (!ph.empty && !ph.sign)
                    {
                        ph.Water_pe(1);
                    }
                }
            }
            if (h.sign && h.build.index == 11 && h.newday)
            {
                h.newday = false;
                foreach(Hex nh in h.Distance(Map.instance.hexs_active, 2))
                {
                    if (nh.ahex.twater_pe.text != ""&& (int.Parse(nh.ahex.twater_pe.text) < 0))
                    {
                        nh.Water_pe(1);
                    }
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (nh.ahex.twater_pe.text != "" && (int.Parse(nh.ahex.twater_pe.text) < 0))
                    {
                        nh.Water_pe(1);
                    }
                }
            }
            if (h.sign && h.build.index == 12 && h.newday)
            {
                h.newday = false;
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    if(!nh.empty && !nh.sign) { Map.instance.Time(-5); }
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 2))
                {
                    if (!nh.empty && !nh.sign) { Map.instance.Time(-5); }
                }
            }
            if (h.sign && h.build.index == 14 && h.newday)
            {
                h.newday = false;
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    nh.Water_pe(-1);
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 2))
                {
                    nh.Water_pe(-1);
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 3))
                {
                    nh.Water_pe(-1);
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 4))
                {
                    nh.Water_pe(-1);
                }
            }
            if (h.sign && h.build.index == 16 && h.newday)
            {
                h.newday = false;
                bool i = true;
                foreach (Hex fh in h.Distance(Map.instance.hexs, 1))
                {
                    if (fh.empty || fh.sign)
                    {
                        i = false;
                    }
                }
                if (i)
                {
                    Game.Build(2);
                }
            }
            if (h.sign && h.build.index == 17 && h.newday)
            {
                h.newday = false;
                if (dangoinchest.Count > 0)
                {
                    System.Random r = new();
                    Dango i = dangoinchest[r.Next(dangoinchest.Count)];
                    Box(i);
                    List<Hex> lh = new();
                    foreach (Hex ph in h.Distance(Map.instance.hexs_active, 1))
                    {
                        if (ph.empty) { lh.Add(ph); }
                    }
                    if (lh.Count > 0)
                    {
                        Game.Food(i.food);
                        Put(Map.instance.hexs, i, lh[r.Next(lh.Count)]);
                    }
                }
            }
            }
        foreach (Hex h in Map.instance.hexs_active)
        {
            if (h.sign && h.build.index == 13 && h.newday)
            {
                h.newday = false;
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 1))
                {
                    if (nh.empty) { nh.Water_pe(1); }
                }
                foreach (Hex nh in h.Distance(Map.instance.hexs_active, 2))
                {
                    if (nh.empty) { nh.Water_pe(1); }
                }
            }
        }
        foreach (Hex h in Map.instance.hexs)
        {
            h.newday = false;
            newdaying = false;
        }
    }
    public GameObject ImageDango(int index)
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
            18 => Image_18,
            19 => Image_19,
            20 => Image_20,
            21 => Image_21,
            22 => Image_22,
            23 => Image_23,
            24 => Image_24,
            25 => Image_25,
            26 => Image_26,
            27 => Image_27,
            28 => Image_28,
            29 => Image_29,
            30 => Image_30,
            31 => Image_31,
            32 => Image_32,
            33 => Image_33,
            34 => Image_34,
            35 => Image_35,
            36 => Image_36,
            37 => Image_37,
            38 => Image_38,
            39 => Image_39,
            40 => Image_40,
            41 => Image_41,
            42 => Image_42,
            43 => Image_43,
            44 => Image_44,
            45 => Image_45,
            46 => Image_46,
            47 => Image_47,
            48 => Image_48,
            49 => Image_49,
            50 => Image_50,
            51 => Image_51,
            52 => Image_52,
            53 => Image_53,
            54 => Image_54,
            55 => Image_55,
            56 => Image_56,
            57 => Image_57,
            58 => Image_58,
            59 => Image_59,
            60 => Image_60,
            61 => Image_61,
            62 => Image_62,
            63 => Image_63,
            64 => Image_64,
            65 => Image_65,
            66 => Image_66,
            67 => Image_67,
            68 => Image_68,
            69 => Image_69,
            70 => Image_70,
            71 => Image_71,
            72 => Image_72,
            73 => Image_73,
            74 => Image_74,
            75 => Image_75,
            76 => Image_76,
            77 => Image_77,
            78 => Image_78,
            79 => Image_79,
            80 => Image_80,
            _ => null,
        };
    }
    public void Box(Dango dango, params int[] level)
    {
        if (dangoinmap.Contains(dango))
        {
            return;
        }
        dangoinchest.Remove(dango);
        dangoinchest2.Remove(dango);
        dangoinmap.Add(dango);
        GameObject go = Instantiate(dangobox, boxbox.transform);
        if(level.Length == 1 && level[0] == 2)
        {
            go.GetComponent<Image>().color = new Color(0.4f, 0.6f, 0.2f);
        }
        Dangobox db = go.GetComponent<Dangobox>();
        db.clickmode = "put";
        db.refer_dango = dango;
        db.twater.text = dango.water.ToString();
        db.time.text = Game.Time(dango.time);
        Destroy(db.dango);
        db.dango = Instantiate(ImageDango(dango.index), go.transform);
        db.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        go.transform.localPosition += 80 * (dangoinmap.Count) * Vector3.down;// + new Vector3(650, -432);
        boxs.Add(db);
        boxbox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, dangoinmap.Count * 80);
        if (PlayerPrefs.GetInt(dango.index.ToString()) == 0)
        {
            GameObject gol = Instantiate(Dangoset.instance.dangobox, librarybox.transform);
            Dangobox dbl = gol.GetComponent<Dangobox>();
            dbl.clickmode = "lock";
            dbl.refer_dango = dango;
            dbl.twater.text = dango.water.ToString();
            dbl.time.text = Game.Time(dango.time);
            Destroy(dbl.dango);
            dbl.dango = Instantiate(Dangoset.instance.ImageDango(dango.index), gol.transform);
            dbl.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
            dbl.dango.transform.localScale = new Vector3(0.8f, 0.8f);
            gol.transform.localPosition += 80 * (librarydb.Count + 1) * Vector3.down;
            librarydb.Add(dbl);
            librarybox.GetComponent<RectTransform>().sizeDelta = new Vector2(-1, librarydb.Count * 80);
            PlayerPrefs.SetInt("dango", PlayerPrefs.GetInt("dango") + 1);
        }
        PlayerPrefs.SetInt(dango.index.ToString(), 1);
        libdango_number.text = libdango_number.text = "Dango:" + PlayerPrefs.GetInt("dango").ToString() + "/" + dangoall.Count.ToString();
        // + new Vector3(650, -432);
        
    }
    public void Chestopen()
    {
        if (dangoinchest.Count == 0)
        {
            Chestclose(1,false);
            Game.Info("You have found all lv1 dangos!");
            return;
        }
        System.Random random = new();
        Dango d1;
        Dango d2;
        Dango d3;
        if (dangoinchest.Count == 1)
        {
            d1 = dangoinchest[0];
            d2 = dangoinchest[0];
            d3 = dangoinchest[0];
        }
        else if(dangoinchest.Count == 2)
        {
            d1 = dangoinchest[0];
            d2 = dangoinchest[0];
            d3 = dangoinchest[1];
        }
        else
        {
            int index1 = random.Next(dangoinchest.Count);
            int index2;
            int index3;
            do
            {
                index2 = random.Next(dangoinchest.Count);
                index3 = random.Next(dangoinchest.Count);
            } while (index2 == index1 || index3 == index1 || index2 == index3);
            d1 = dangoinchest[index1];
            d2 = dangoinchest[index2];
            d3 = dangoinchest[index3];
        }
        chest_choice1 = Instantiate(dangobox, canvas.transform);
        chest_choice2 = Instantiate(dangobox, canvas.transform);
        chest_choice3 = Instantiate(dangobox, canvas.transform);
        chest_skip = Instantiate(chest_skip_prefab, canvas.transform);
        Dangobox db1 = chest_choice1.GetComponent<Dangobox>();
        Dangobox db2 = chest_choice2.GetComponent<Dangobox>();
        Dangobox db3 = chest_choice3.GetComponent<Dangobox>();
        db1.clickmode = "chest";
        db2.clickmode = "chest";
        db3.clickmode = "chest";
        Game.Clickmode("chest");
        db1.refer_dango = d1;
        db2.refer_dango = d2;
        db3.refer_dango = d3;
        db1.twater.text = d1.water.ToString();
        db2.twater.text = d2.water.ToString();
        db3.twater.text = d3.water.ToString();
        db1.time.text = Game.Time(d1.time);
        db2.time.text = Game.Time(d2.time);
        db3.time.text = Game.Time(d3.time);
        Destroy(db1.dango);
        Destroy(db2.dango);
        Destroy(db3.dango);
        db1.dango = Instantiate(ImageDango(d1.index), chest_choice1.transform);
        db2.dango = Instantiate(ImageDango(d2.index), chest_choice2.transform);
        db3.dango = Instantiate(ImageDango(d3.index), chest_choice3.transform);
        db1.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db2.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db3.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db1.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        db2.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        db3.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        chest_choice1.transform.localScale = new Vector3(2, 2);
        chest_choice2.transform.localScale = new Vector3(2, 2);
        chest_choice3.transform.localScale = new Vector3(2, 2);
        chest_choice1.transform.localPosition = new Vector3(-200, 150);
        chest_choice2.transform.localPosition = new Vector3(-200, -75);
        chest_choice3.transform.localPosition = new Vector3(-200, -300);

        dango_02.water += 1;
        boxs[2].twater.text = dango_02.water.ToString();
        Game.Info("Choose one!");
    }
    public void Chestopen2()
    {
        if (dangoinchest2.Count == 0)
        {
            Chestclose(2, false);
            Game.Clickmode(Events[0]);
            Game.Info("You have found all lv2 dangos!");
            return;
        }
        System.Random random = new();
        Dango d1;
        Dango d2;
        Dango d3;
        if (dangoinchest2.Count == 1)
        {
            d1 = dangoinchest2[0];
            d2 = dangoinchest2[0];
            d3 = dangoinchest2[0];
        }
        else if (dangoinchest2.Count == 2)
        {
            d1 = dangoinchest2[0];
            d2 = dangoinchest2[0];
            d3 = dangoinchest2[1];
        }
        else
        {
            int index1 = random.Next(dangoinchest2.Count);
            int index2;
            int index3;
            do
            {
                index2 = random.Next(dangoinchest2.Count);
                index3 = random.Next(dangoinchest2.Count);
            } while (index2 == index1 || index3 == index1 || index2 == index3);
            d1 = dangoinchest2[index1];
            d2 = dangoinchest2[index2];
            d3 = dangoinchest2[index3];
        }
        chest_choice1 = Instantiate(dangobox, canvas.transform);
        chest_choice2 = Instantiate(dangobox, canvas.transform);
        chest_choice3 = Instantiate(dangobox, canvas.transform);
        chest_skip = Instantiate(chest_skip_prefab, canvas.transform);
        Dangobox db1 = chest_choice1.GetComponent<Dangobox>();
        Dangobox db2 = chest_choice2.GetComponent<Dangobox>();
        Dangobox db3 = chest_choice3.GetComponent<Dangobox>();
        db1.clickmode = "chest2";
        db2.clickmode = "chest2";
        db3.clickmode = "chest2";
        Game.Clickmode("chest2");
        db1.refer_dango = d1;
        db2.refer_dango = d2;
        db3.refer_dango = d3;
        db1.twater.text = d1.water.ToString();
        db2.twater.text = d2.water.ToString();
        db3.twater.text = d3.water.ToString();
        db1.time.text = Game.Time(d1.time);
        db2.time.text = Game.Time(d2.time);
        db3.time.text = Game.Time(d3.time);
        Destroy(db1.dango);
        Destroy(db2.dango);
        Destroy(db3.dango);
        db1.dango = Instantiate(ImageDango(d1.index), chest_choice1.transform);
        db2.dango = Instantiate(ImageDango(d2.index), chest_choice2.transform);
        db3.dango = Instantiate(ImageDango(d3.index), chest_choice3.transform);
        db1.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db2.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db3.dango.transform.localPosition = 50 * Vector3.left + new Vector3(100, 50);
        db1.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        db2.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        db3.dango.transform.localScale = new Vector3(0.8f, 0.8f);
        chest_choice1.transform.localScale = new Vector3(2, 2);
        chest_choice2.transform.localScale = new Vector3(2, 2);
        chest_choice3.transform.localScale = new Vector3(2, 2);
        chest_choice1.transform.localPosition = new Vector3(-200, 150);
        chest_choice2.transform.localPosition = new Vector3(-200, -75);
        chest_choice3.transform.localPosition = new Vector3(-200, -300);
        dango_31.water += 1;
        boxs.Find(d31 => d31.refer_dango.index == 31).twater.text = dango_31.water.ToString();
        Game.Info("Choose one!");
    }
    public void Chestclose(int i, bool dango)
    {
        Destroy(chest_choice1);
        Destroy(chest_choice2);
        Destroy(chest_choice3);
        Destroy(chest_skip);
        Game.EventExecute();
        int j = 2;
        if (dango) { j = 1; }
        Game.Build(j);
    }

    public void Put_silent(List<Hex> map, Dango dango, Hex hex)
    {
        putting = dango;
        if (dango.index != 18)
        {
            hex.godan = Instantiate(ImageDango(dango.index), hex.image.transform);
        }
        hex.ahex.twater.text = "";
        hex.empty = false;
        hex.dango = dango;
        switch (dango.index)
        {
            case 0:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 1:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 3:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 4:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                break;
            case 6:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 7:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(1);
                }
                break;
            case 10:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 13:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 17:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 18:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                Destroy(hex.godan);
                switch (hex.dango18)
                {
                    case 1:
                        hex.godan = Instantiate(Image_18_1, hex.image.transform);
                        hex.ahex.twater.text = hex.water.ToString();
                        break;
                    case 2:
                        hex.godan = Instantiate(Image_18_2, hex.image.transform);
                        hex.ahex.twater.text = hex.water.ToString();
                        break;
                    case 3:
                        hex.godan = Instantiate(Image_18_3, hex.image.transform);
                        break;
                }
                break;
            case 20:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(3);
                }
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 21:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(1);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(1);
                }
                break;
            case 23:
                Game.Miracle(1);
                break;
            case 24:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 29:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 30:
                int a = 0;
                Debug.Log(hex.dango30.x + 10 * hex.dango30.y);
                hex.dango30 = hex.dango30 * MathF.Pow(2, 0.5f);
                int b = (int)MathF.Round(hex.dango30.x + 10 * hex.dango30.y);
                switch (b)
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
                hex.godan.transform.Rotate(0, 0, a);
                hex.dango30.Normalize();
                foreach (Hex h in Map.instance.hexs)
                {
                    Vector3 v3 = new(h.x - hex.x, h.y - hex.y, h.z - hex.z);
                    v3 = v3.normalized;
                    if (v3 == hex.dango30)
                    {
                        h.Water(2);
                    }
                }
                break;
            case 32:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                break;
            case 34:
                hex.td34 = Instantiate(td34, hex.image.transform);
                hex.td34.GetComponent<Text>().text = hex.dango34.ToString();
                break;
            case 36:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 37:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-4);
                }
                break;
            case 38:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 41:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                break;
            case 43:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 45:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(3);
                    }
                }
                break;
            case 46:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 48:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(4);
                }
                break;
            case 49:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 51:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(2);
                }
                break;
            case 54:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                break;
            case 56:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                break;
            case 57:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(1);
                    }
                    if (h.y == hex.y)
                    {
                        h.Water(1);
                    }
                    if (h.z == hex.z)
                    {
                        h.Water(1);
                    }
                }
                break;
            case 62:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 63:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 64:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(3);
                }
                break;
            case 67:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 68:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 69:
                hex.dango69 = false;
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 70:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 77:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(2);
                }
                break;
            case 78:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(10);
                }
                break;
            case 80:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
        }
    }
    public void Eat_silent(List<Hex> map, Hex hex)
    {
        Destroy(hex.godan);
        hex.ahex.twater.text = hex.water.ToString();
        if (hex.water == 0)
        {
            hex.ahex.twater.text = "";
        }
        hex.empty = true;
        switch (hex.dango.index)
        {
            case 0:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 1:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 3:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 4:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 6:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(1);
                }
                break;
            case 7:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-1);
                }
                break;
            case 9:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 10:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 13:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 17:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 18:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 20:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-3);
                }
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 21:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-1);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(-1);
                }
                break;
            case 24:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 29:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 30:
                foreach (Hex h in Map.instance.hexs)
                {
                    Vector3 v3 = new(h.x - hex.x, h.y - hex.y, h.z - hex.z);
                    Debug.Log(v3);
                    Debug.Log(hex.dango30);
                    if (v3.normalized == hex.dango30.normalized)
                    {
                        h.Water(-2);
                    }
                }
                break;
            case 32:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 34:
                Destroy(hex.td34);
                break;
            case 36:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 37:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(4);
                }
                break;
            case 38:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 41:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 43:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 45:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(-3);
                    }
                }
                break;
            case 46:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 48:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-4);
                }
                break;
            case 49:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 51:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 3))
                {
                    h.Water(-2);
                }
                break;
            case 54:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                break;
            case 56:
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 57:
                foreach (Hex h in Map.instance.hexs)
                {
                    if (h.x == hex.x)
                    {
                        h.Water(-1);
                    }
                    if (h.y == hex.y)
                    {
                        h.Water(-1);
                    }
                    if (h.z == hex.z)
                    {
                        h.Water(-1);
                    }
                }
                break;
            case 62:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 63:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 64:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-3);
                }
                break;
            case 67:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                    h.Water_pe(1);
                }
                break;
            case 68:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 69:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                if (hex.dango69)
                {
                    //hex.image.transform.localScale /= 1.5f;
                    Game.Food(-3);
                    Game.Yuyuko(-3);
                    foreach (Hex nh in hex.Distance(Map.instance.hexs, 1))
                    {
                        nh.Water(-3);
                    }
                }
                break;
            case 70:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
            case 77:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-2);
                }
                foreach (Hex h in hex.Distance(map, 2))
                {
                    h.Water(-2);
                }
                break;
            case 78:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-10);
                }
                break;
            case 80:
                foreach (Hex h in hex.Distance(map, 1))
                {
                    h.Water(-1);
                }
                break;
        }
        if (hex.dango34 < 1)
        {
            hex.dango = null;
        }
    }
}