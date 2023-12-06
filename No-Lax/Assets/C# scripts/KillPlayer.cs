using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;
    //public float respawnDelay;
    //public GameObject deathTextObject;
    // Start is called before the first frame update
    void Start()
    {
        //deathTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            //deathTextObject.SetActive(true);
            //yield return new WaitForSeconds(respawnDelay);
            SceneManager.LoadScene(Respawn);
        }
    }
}
