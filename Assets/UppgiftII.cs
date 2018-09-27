using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UppgiftII : MonoBehaviour
{
    public int UserValue;
    private int DiceGame = 10;
    private int DiceGameOutput;
    private int DragonHP;
    private int DragonATT;
    private int DragonATTChance;
    private int PlayerHP = 100;
    private int PlayerATT;
    private float DragonGameW = 1;
    private float DragonGameL = 1;


    // Use this for initialization
    void Start()
    {
        info();
    }

    // Update is called once per frame
    void Update()
    {

        uppgift1();
        uppgift2();
        uppgift3();
    }


    void info()
    {
        print("För att göra uppgift 1 tryck piltangenterna");
        print("för att spela tärningspelet tryck R");
        print("för att spela drakspelet tryck A");
    }
    void uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserValue = UserValue * 2;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue = UserValue / 2;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(UserValue);
        }
    }
    void uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DiceGame += (Random.Range(1, 7));
            DiceGameOutput = DiceGame - (Random.Range(1, 7));
            print(DiceGameOutput);
            if (DiceGameOutput < 0 || DiceGameOutput > 20)
            {
                DiceGameOutput = 0;
                DiceGame = 10;
                if (DiceGameOutput > 0)
                {
                    print("Game Over");
                }
                else
                {
                    print("YOU WIN");
                }
            }
        }
    }

    void uppgift3()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("---------------------------------------------------");
            print("---------------------------------------------------");
            DragonHP = (Random.Range(100, 151));
            PlayerHP = 100;
            Debug.Log(string.Format("drakens HP är {0}", DragonHP));
            print("Du har 100 HP");
            print("tryck mellanslag för att börja sloss");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("---------------------------------------------------");
            DragonATT = (Random.Range(10, 21));
            DragonATTChance = (Random.Range(0, 2));

            if (DragonATTChance == 0)
            {
                PlayerHP = PlayerHP - DragonATT;
                Debug.Log(string.Format("Draken slog dig och skadade {0}", DragonATT));
            }
            else
            {
                Debug.Log(string.Format("Draken missade"));
            }
            PlayerATT = (Random.Range(5, 26));
            DragonHP = DragonHP - PlayerATT;
            Debug.Log(string.Format("Du slog draken och gjorde {0} skada", PlayerATT));
            Debug.Log(string.Format("draken har {0} HP kvar", DragonHP));
            Debug.Log(string.Format("Du har {0} HP kvar", PlayerHP));
            if (PlayerHP < 0)
            {
                print("GAME OVER");
                print("tryck A för att börja igen");
                DragonGameL += 1;
                Debug.Log(string.Format("du har en Win/Loss på {0}", DragonGameW / DragonGameL));
            }
            if (DragonHP < 0)
            {
                print("YOU WIN");
                print("tryck A för att börja igen");
                DragonGameW += 1;
                Debug.Log(string.Format("du har en Win/Loss på {0}", DragonGameW / DragonGameL));
            }


        }
    }
}
