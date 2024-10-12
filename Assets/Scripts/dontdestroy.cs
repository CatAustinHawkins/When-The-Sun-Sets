using UnityEngine;

public class dontdestroy : MonoBehaviour
{
    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("bugs"); //bug music

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
