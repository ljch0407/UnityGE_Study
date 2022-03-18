using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScript : MonoBehaviour
{
   private GameObject ObjectB;

   private void Start()
   {
      ObjectB = GameObject.FindObjectOfType<BScript>().gameObject;
      print(ObjectB.name);
   }
}
