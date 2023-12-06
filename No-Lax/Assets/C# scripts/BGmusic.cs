using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BGmusic : MonoBehaviour
{
    public static BGmusic instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Victory!")
            BGmusic.instance.GetComponent<AudioSource>().Pause();


        if (SceneManager.GetActiveScene().name == "MainMenu")
            BGmusic.instance.GetComponent<AudioSource>().Play();

    }
}
