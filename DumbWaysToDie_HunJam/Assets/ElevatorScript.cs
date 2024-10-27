using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    private float timePassed = 0;
    public GameObjectControllerScript objectController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 4f)
        {
            objectController.loaded = true;
        }
    }
}
