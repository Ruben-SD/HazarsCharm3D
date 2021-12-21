using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        SceneManager.UnloadSceneAsync("hillClimb");
        SceneManager.LoadScene("planets");
    }
}
