using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscar : MonoBehaviour
{
    private void Start()
    {
        Lasse.Jump += Watch;
    }
    public void Watch()
    {
        Debug.Log("Oh, que bonito");
    }
}
