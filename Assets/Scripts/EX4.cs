using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    public int LeftStart;
    public int RightEnd;
    public int i;

    private void Start()
    {
        int i = LeftStart;
        while (i < RightEnd) //you have a limit end and a limit start
        {
            if( i % 5 == 0)
            {
                Debug.Log(message: $"{i}");
            }
            
            i++;

        }

        
    }
}
