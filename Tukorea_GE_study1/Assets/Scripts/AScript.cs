using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class AScript : MonoBehaviour
{
    private void Start()
    {
        var C = transform.Find("B/C");
        print(C.name);
        
        
    }
}
