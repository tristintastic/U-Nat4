using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class Enemyfollow : MonoBehaviour
{
    //public NavMeshAgent Enemy;
    //public Transform Player; 
    public GameObject player;
    public float speed;
    public float distanceBetween;

    public float distance;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy.SetDestination(Player.position);
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        //transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}




