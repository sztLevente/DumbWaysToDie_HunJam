using UnityEngine;

public class ObstacleCode : MonoBehaviour, IGravity
{
    public void Fly()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = -1;
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
