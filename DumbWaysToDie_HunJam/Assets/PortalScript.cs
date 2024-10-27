using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CharacterScript>() != null)
        {
            SceneManager.LoadSceneAsync("End");
        }
    }

}
