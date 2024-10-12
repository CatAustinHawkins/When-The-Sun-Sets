using UnityEngine;
using TMPro;
public class endscreen : MonoBehaviour
{
    public GameObject DistanceTrackerGO;
    public DistanceTracker DistanceScript;

    public TextMeshProUGUI Distancetext;

    void Start()
    {
        DistanceTrackerGO = GameObject.FindGameObjectWithTag("DT");
        DistanceScript = DistanceTrackerGO.GetComponent<DistanceTracker>();
        Distancetext.text = "you travelled " + DistanceScript.distanceDT.ToString() +  " distance!";
    }
}
