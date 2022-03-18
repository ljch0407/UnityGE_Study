using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour//추상 클래스
{
    public abstract void WarCry();

    private void Start()
    {
        WarCry();
    }

    private void Update()
    {
        
    }
}
