using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class complexType
{
    public string name;
    public int age;
    public float hieght;
}

public class TU_Study : MonoBehaviour
{
    // Start is called before the first frame update
    public complexType type; 
    void Start()
    {
        print("게임이 시작 되었습니다");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
