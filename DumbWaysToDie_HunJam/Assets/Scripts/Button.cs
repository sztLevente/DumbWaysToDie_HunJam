using UnityEngine;

public class Button : MonoBehaviour, IGravity
{
    public GameObjectControllerScript GameObjectControllerScript;
    public void Fly()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Character")
        {
            GameObjectControllerScript.SetGravityOff();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
