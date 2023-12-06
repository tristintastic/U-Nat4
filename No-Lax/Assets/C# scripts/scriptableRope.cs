using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class scriptableRope : ScriptableObject
{
    public bool ropeObtained = false;

    void OnEnable()
    {
        ropeObtained = false;
    }
}
