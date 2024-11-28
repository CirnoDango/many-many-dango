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
        info = "����\n����ʱ�����ַ�������\n�µ�һ�죺1����+2ˮ"
    };
    public static Build sign_01 = new()
    {
        index = 1,
        info = "ħ��ɭ��\n����ʱ������Ģ������\n�µ�һ�죺ÿ�����ڸ��������һ��ˮ����С��3������"
    };
    public static Build sign_02 = new()
    {
        index = 2,
        info = "ħ��\n����ʱ������ѪҺ����\n����������1���ڷ���ÿ���һ�����ӣ�������ʱ��"
    };
    public static Build sign_03 = new()
    {
        index = 3,
        info = "��֮��\n����ʱ������ˮ���ӡ������ӡ�ѩ���Ӳ���1/3��ʱ\n������1����+3ˮ"
    };
    public static Build sign_04 = new()
    {
        index = 4,
        info = "�������\n����ʱ�����ְ������ӣ�1����+1ˮ\n�µ�һ�죺������6�񶼴������ӣ������ӷ���-1"
    };
    public static Build sign_05 = new()
    {
        index = 5,
        info = "������\n����ʱ������ӣ�����ӣ�+1�漣\n�����漣ʱ��2����+1ˮ"
    };
    public static Build sign_06 = new()
    {
        index = 6,
        info = "����\n����ʱ�����ֺ��ܲ�����\n������ÿ��1���ڷ���1�����ӣ���1���ڷ���1���������"
    };
    public static Build sign_07 = new()
    {
        index = 7,
        info = "��;��\n����ʱ������ͭǮ���Ӻͺڰ�����\n������2�������ӱ���ʱ���ø�+1ˮ"
    };
    public static Build sign_08 = new()
    {
        index = 8,
        info = "ֲ��԰\n����ʱ������˫�㶹���ӡ����տ����ӡ��춹���Ӳ�ʹˮ�����Ϊ2\n������1����+2ˮ"
    };
    public static Build sign_09 = new()
    {
        index = 9,
        info = "����֮ɽ\n����ʱ�����ֺ�Ҷ����\n�µ�һ�죺2���ڴ������ӵĸ�+1ˮ"
    };
    public static Build sign_10 = new()
    {
        index = 10,
        info = "��֮��\n����ʱ�������������ӣ�+1�漣\n�����漣ʱ��������һ��2�����ӣ���������ѷ�����������ڸ�"
    };
    public static Build sign_11 = new()
    {
        index = 11,
        info = "�����\n����ʱ�����ֶ������Ӻ��Ա�����\n�µ�һ�죺2��������ˮ<0�ĸ���+1ˮ"
    };
    public static Build sign_12 = new()
    {
        index = 12,
        info = "���ȵ�\n����ʱ�����ֺ������\n�µ�һ�죺2���ڵ�ÿ������ʹʱ�����00:05"
    };
    public static Build sign_13 = new()
    {
        index = 13,
        info = "��Ժ\n����ʱ�����ֽ�ʬ����\n�µ�һ�죺2���ڿո�+1ˮ"
    };
    public static Build sign_14 = new()
    {
        index = 14,
        info = "��������\n����ʱ�����ֺ�������\n����ʱ�����и���+2ˮ\n�µ�һ�죺4����-1ˮ"
    };
    public static Build sign_15 = new()
    {
        index = 15,
        info = "�ж���\n����ʱ���������ӣ���ȱ��\n������3-5����+1ˮ��1-2����+2ˮ"
    };
    public static Build sign_16 = new()
    {
        index = 16,
        info = "����\n����ʱ������Թ������\n�µ�һ�죺������6�񶼴������ӣ�+2����"
    };
    public static Build sign_17 = new()
    {
        index = 17,
        info = "�ƺ�¥\n����ʱ�����ֲʺ�����\n������2����+1ˮ\n�µ�һ�죺������һ��1������"
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
