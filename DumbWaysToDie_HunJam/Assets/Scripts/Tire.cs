using UnityEngine;

public class Tire : MonoBehaviour, IGravity
{
    private bool flying = false;

    public GameObjectControllerScript gameobjController;


    public void SetFly(bool state)
    {
        flying = state;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Character")
        {
            gameobjController.KillCharacter();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if(flying)
        {
            //Debug.Log(transform.rotation.z);
            if (transform.rotation.z < 0.5)
            {
                   
                transform.Rotate(new Vector3(0, 0, 30f) * Time.deltaTime);
            }
            
        }
        else
        {
            if (transform.rotation.z > 0)
                transform.Rotate(new Vector3(0, 0, -40f) * Time.deltaTime);
        }
    }
}
