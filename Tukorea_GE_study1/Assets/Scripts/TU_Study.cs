using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class TU_Study : MonoBehaviour
{
    //타이머 방식을 이용해보자
    private const float AttackInterval = 3.0f;
    private float m_attackIntervalTimer;
    private void Update()
    {
        m_attackIntervalTimer += Time.deltaTime;
        if (m_attackIntervalTimer > 3.0f)
            PrintText();

        m_attackIntervalTimer = 0.0f;
    }

    void PrintText()
    {
        print("공격함!");
    }
}
