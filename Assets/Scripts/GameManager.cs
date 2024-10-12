using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public int randomint;
    public GameObject SpawnPoint;
    public float speedMultiplier;

    public TextMeshProUGUI distanceUI;
    private float distance;

    public GameObject DistanceControl;
    public DistanceTracker DistanceScript;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDelay());
        StartCoroutine(DistanceTimer());
    }

    // Update is called once per frame
    void Update()
    {
        DistanceScript.distanceDT = distance;
    }

    IEnumerator DistanceTimer()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        distance = distance + 0.5f;
        distanceUI.text = distance.ToString();
        StartCoroutine(DistanceTimer());
    }

    IEnumerator SpawnDelay()
    {
        randomint = Random.Range(0, 2);
        Instantiate(spawnObjects[randomint], SpawnPoint.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(Random.Range(1, 3));
        StartCoroutine(SpawnDelay());
    }
}
