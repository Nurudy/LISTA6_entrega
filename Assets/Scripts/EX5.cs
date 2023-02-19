using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX5 : MonoBehaviour
{
    public int[] arrayN;
    private int Result;

    private void Start()
    {
        foreach(int i in arrayN)
        {
            Result = Result + i;
        }

        Debug.Log($"{arrayN[0]} + {arrayN[1]} + {arrayN[2]} + {arrayN[3]} + {arrayN[4]} = {Result}"); //there's all the sum of the arrays and the result

    }

}
