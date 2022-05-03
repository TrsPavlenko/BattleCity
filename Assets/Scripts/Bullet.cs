using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField] float damage = 10;

   public float Damage()
   {
      return damage;
   }
}
