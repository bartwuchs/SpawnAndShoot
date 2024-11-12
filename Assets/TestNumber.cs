using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        Add5(ref a);
        Debug.Log("after "+a);
    }   

    void Add5(ref int a)
    {
        a =+  5;
        Debug.Log("in method " + a);
    }
}
