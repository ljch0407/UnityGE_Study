using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class TU_Study : MonoBehaviour
{
   //Invoke 를 이용해 보자
   private void Start()
   {
      Invoke("PrintText",3.0f);
   }

   void PrintText()
   {
      print("공격함!");
   }
}
