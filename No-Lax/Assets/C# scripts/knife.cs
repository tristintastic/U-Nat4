using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
//using UnityEngine.Rendering.Universal;
using UnityEngine;

public class knife : Collectable
{
    public GameObject objectKnife;
    public bool knifeItem;
    public scriptableRope Scriptablerope1;
    
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            knifeItem = true;
            objectKnife.SetActive(false);
        }
    }
}
