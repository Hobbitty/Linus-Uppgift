using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgiftScript1 : MonoBehaviour
    //hejan pejsan
{
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float number;
    public float @base;
    [Range(0, 360)] public float angle;
    public float pieces;
    public string username;
    public float radius;
    public int damage;
    public int demonhp;
    public int demons;
    public int maxdmg;
    public int mindmg;
    public double count;
    public float countmulti;
    public int enemydamage;
    public int playermaxlife;
    [Range(0, 1)] public float playerresist;
    // Use this for initialization
    void Start()
    {
        uppgift1();
        uppgift2();
        uppgift3();
        uppgift4();
        uppgift5();
        uppgift6();
        uppgift7();
        uppgift8();
        uppgift10();
        uppgift11();
    }

    // Update is called once per frame
    void Update()
    {
        uppgift9();
    }

    void uppgift1()
    {
        Debug.Log(string.Format("svaret på talet är {0}", (963f * 421f) - (175463f / 87f)));
    }
    void uppgift2()
    {
        Debug.Log(string.Format(sentence1));
        Debug.Log(string.Format(sentence2));
        Debug.Log(string.Format(sentence3));
    }
    void uppgift3()
    {
        Debug.Log(string.Format("{0} upphöjt med 2 blir {1} och kvadratroten ur {0} är {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));

    }
    void uppgift4()
    {
        Debug.Log(string.Format("en triangel med basen {0}m och höjden 8m har arean {1}m^2", @base, (@base * 8) / 2));

    }
    void uppgift5()
    {
        Debug.Log(string.Format("om du delar upp en hel tårta så att varje bit har vinkeln {0} får du {1} hela bitar", angle, (360 / angle)));
        Debug.Log(string.Format("om du delar tårtan i {0} delar så har varje del vinkeln {1} ", pieces, (360 / pieces)));

    }
    void uppgift6()
    {
        Debug.Log(string.Format("Behold! Boss {0} Of Doom has arrived", username));
    }
    void uppgift7()
    {
        Debug.Log(string.Format("Om du har 2978 klot med radien {0} har de alla en sammansatt volym på {1}", radius, (Mathf.Pow(radius, 3) * 4 * 3.14 / 3) * 2978));
    }
    void uppgift8()
    {
        Debug.Log(string.Format("Om du skadar {0} per slag krävs det {1} antal slag för att döda en demon med 890000HP", damage, 890000 / damage));
        Debug.Log(string.Format("Om du skadar {0} per slag krävs det {1} antal slag för att döda {2} demoner med {3}HP", damage, demonhp / damage * demons, demons, demonhp));
        Debug.Log(string.Format("om du har en maxdmg på {0} och en mindmg på {1} krävs det minst {2} slag, max {3} slag och {4} slag i snitt för att döda en demon med HP {5}", maxdmg, mindmg, demonhp / maxdmg, demonhp / mindmg, demonhp / ((maxdmg + mindmg) / 2), demonhp));
    }
    void uppgift9()
    {
        Debug.Log(count);
        count = count * 2;
    }
    void uppgift10()
    {
        Debug.Log(string.Format("Värdet på uppgift 10 är {0}", (countmulti * 3) / 2));
    }
    void uppgift11()
    {
        Debug.Log(string.Format("Monstret slog dig, han skadade {0} men du har {1} i resist så du tog {2} Skada. Du har {3} HP kvar", enemydamage, playerresist, enemydamage * playerresist,  playermaxlife - (enemydamage * playerresist)));
    }
}
