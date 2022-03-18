using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class AScript : MonoBehaviour
{
   private GameObject ObjectB;

   private void Start()
   {
      ObjectB = new GameObject("B");
      ObjectB.AddComponent<BScript>();
      print(ObjectB.name);
      
      ObjectB.SendMessage("SayHello");

   }
   
   
}
