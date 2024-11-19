using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasse : MonoBehaviour
{

    public static Action Jump;
    // Start is called before the first frame update
    void Start()
    {
        JumpFromBridge();
    }

    private void JumpFromBridge()
    {
        Jump?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
