using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectControllerScript : MonoBehaviour
{

    public GameObject BottomRoom;
    public GameObject TopRoom;
    public GameObject MiddleRoom;
    public GameObject Character;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGravityOff()
    {
        foreach (IGravity go in MiddleRoom.GetComponentsInChildren<IGravity>())
        {
            go.Fly();
        }
        Character.GetComponent<IGravity>().Fly();
    }


    // Ezzel toltjuk ujra a jatekot halalnal
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
