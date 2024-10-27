using UnityEngine;
using UnityEngine.TextCore.Text;

public class BoxScript : MonoBehaviour
{
    public Rigidbody2D BoxBody;
    public GameObjectControllerScript timer;

    void Start()
    {
        BoxBody.gravityScale = 0.0f;
    }
    void Update()
    {
        if (timer.time >= 5f)
        {
            BoxBody.gravityScale = 1.0f;
        }
        else
        {
            BoxBody.transform.position = new Vector3(-1.43f, 6f,-1);
            BoxBody.gravityScale = 0.0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
