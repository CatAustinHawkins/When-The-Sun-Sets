using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{

    public float distanceDT;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DT");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
