using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    void OnEnable()
    {
        print("컴포넌트가 활성화 되었습니다");
    }

    private void OnDisable()
    {
        print("컴포넌트가 비활성화 되었습니다");
    }

    void Update()
    {
       print("컴포넌트가 업데이트 되었습니다.");
    }

    private void FixedUpdate()
    {
        print("컴포넌트가 주기적으로 업데이트 되었습니다.");
    }
}
