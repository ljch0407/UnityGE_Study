using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScript : MonoBehaviour
{
   public GameObject ObjectB;

   private void Start()
   {
      print(ObjectB.name);
   }
}
