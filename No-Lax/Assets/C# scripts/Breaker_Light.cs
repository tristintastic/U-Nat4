using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker_Light : Collectable
{
   public Sprite switchPushed;
   public GameObject finishLine;

   protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
           GetComponent<SpriteRenderer>().sprite = switchPushed;
           finishLine.SetActive(true);
        }
    }
}
