using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadSceneAsync("mainScene");
    }
}
