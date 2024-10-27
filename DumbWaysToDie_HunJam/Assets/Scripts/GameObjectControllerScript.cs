using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectControllerScript : MonoBehaviour
{

    public bool loaded = false;
    public GameObject BottomRoom;
    public GameObject TopRoom;
    public GameObject MiddleRoom;
    public GameObject Elevator;
    public GameObject CurrentRoom;
    public GameObject Character;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentRoom = TopRoom;
    }

    // Update is called once per frame
    void Update()
    {
        LoadElevator();
    }

    public void KillCharacter()
    {
        Character.gameObject.GetComponent<CharacterScript>().Die();
    }

    public void SetGravityOff(bool state)
    {
        foreach (IGravity go in MiddleRoom.GetComponentsInChildren<IGravity>())
        {
            go.SetFly(state);
        }
        Character.GetComponent<IGravity>().SetFly(state);
    }


    // Ezzel toltjuk ujra a jatekot halalnal
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadSecondFloor()
    {
        TopRoom.SetActive(false);
        MiddleRoom.SetActive(true);
        Character.transform.position = new Vector3(-10f, 2, -2f);
    }

    public void LoadThirdFloor()
    {
        MiddleRoom.SetActive(false);
        BottomRoom.SetActive(true);
        Character.transform.position = new Vector3(6.7f, -2.141264f, -2f);
    }

    public void LoadElevator()
    {
        if (loaded)
        {
            Character.SetActive(true);
            Elevator.SetActive(false);
            if (CurrentRoom == MiddleRoom)
            {
                LoadSecondFloor();
            }

            if (CurrentRoom == BottomRoom)
            {
                LoadThirdFloor();
            }
        }
    }

    public void LoadNext()
    {
        loaded = false;
        if (CurrentRoom == (TopRoom))
        {
            TopRoom.SetActive(false);
            CurrentRoom = MiddleRoom;
        }
        else if (CurrentRoom == (MiddleRoom))
        {
            MiddleRoom.SetActive(false);
            CurrentRoom = BottomRoom;
        }
        Character.SetActive(false);
        Elevator.SetActive(true);
    }
}
