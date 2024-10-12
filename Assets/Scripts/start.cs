using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    public void clicked()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
