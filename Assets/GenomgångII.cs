using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenomgångII : MonoBehaviour
{
    public bool IsChecked;
    public int MYIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("its true");
        }
        else
        {
            Debug.Log("its not true");
        }
    }

    // Update is called once per frame
    void Update()
    {       // == lika med
            // != inte lika med 
            // <= mindre än elle rlika med
            // >= sätte än eller lika med
            // > större än
            // < mindre än
            // && betyer OCH 
            // || (altgr + större/mindre) betyder ELLER 


        //if (MYIntValue == 10 && IsChecked == true)
        //{
        //    print("Måndag");
        //}
        //else if(MYIntValue == 9)
        //{
        //    print("Tisdag");
        //}
        //else
        //{
        //    print("Onsdag");
        //}

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            Debug.Log(string.Format("du går frammåt"));
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log(string.Format("du går till vänster"));
        }
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log(string.Format("du går baklänges"));
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log(string.Format("du går till höger"));
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            // ha alltid en tal högre eftersom den inte räknar med 10(i detta fall)
            print(Random.Range(0, 11f));
        }
    }
}
