using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    private void Start() //this starts shows the descending order
    {
        for (int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }
}
