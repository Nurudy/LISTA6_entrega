using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    public string message;
    private void Start() //this shows 20 times the message
    {
        int i = 1;
        while (i <= 20)
        {
            Debug.Log(message: $"{message}"); //you put the message on the inspector
            i++;
        }
    }

}
