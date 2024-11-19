using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paula : MonoBehaviour
{
    private void Start()
    {
        Lasse.Jump += Scream;
    }
    public void Scream()
    {
        Debug.Log("AHHHHHHH");
    }
}
