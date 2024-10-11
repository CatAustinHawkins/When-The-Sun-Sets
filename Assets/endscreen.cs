using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class endscreen : MonoBehaviour
{

    public GameObject DistanceTrackerGO;
    public DistanceTracker DistanceScript;

    public TextMeshProUGUI Distancetext;
    // Start is called before the first frame update
    void Start()
    {
        DistanceTrackerGO = GameObject.FindGameObjectWithTag("DT");
        DistanceScript = DistanceTrackerGO.GetComponent<DistanceTracker>();
        Distancetext.text = "you travelled " + DistanceScript.distanceDT.ToString() +  " distance!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
