using Unity.VisualScripting;
using UnityEngine;

public class CharacterScript : MonoBehaviour, IGravity
{
    private Vector2 RightSpeed = new Vector2(5, 0);
    private Vector2 LeftSpeed = new Vector2(-5, 0);

    public Rigidbody2D CharacterRigidbody2D;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterRigidbody2D.gravityScale = 0;
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CharacterRigidbody2D.linearVelocity = RightSpeed;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            CharacterRigidbody2D.linearVelocity = new Vector2(0,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = LeftSpeed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = new Vector2(0,0);
        }
    }
    public void Die()
    {
        
    }

    public void Fly()
    {
        CharacterRigidbody2D.gravityScale = -1;
        this.transform.rotation = Quaternion.Euler(180,0,0);
    }
}
