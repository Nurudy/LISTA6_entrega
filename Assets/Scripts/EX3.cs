using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    public int CountDown;

    private void Start()
    {
        for (int i = (CountDown); i >= 0; i--) //the variable for the countdown
        {
            Debug.Log(i); //you choose the number to make the countdown
        }
    }
}
