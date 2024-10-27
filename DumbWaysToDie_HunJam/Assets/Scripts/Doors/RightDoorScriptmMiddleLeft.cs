using UnityEngine;

public class RightDoorScriptMiddleLeft : MonoBehaviour
{
    public GameObject Parent;
    private bool MoveFinished = false;
    private float time = 0; 
    private float time2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();  
    }
    
    void Move()
    {
        if (time2 > 0.3)
        {
            
            if (!MoveFinished)
            {
                if (transform.position.x < -6.64 + Parent.transform.position.x)
                {
                    transform.position +=  new Vector3(1f, 0,transform.position.z) * Time.deltaTime;
                }
                else
                {
                    //  LeftDoorRigidbody2D.linearVelocity = new Vector2(0, 0);
                    time += Time.deltaTime;
                }

                if (!(time > 2f)) return;
                transform.position = new Vector3(transform.position.x, transform.position.y, -3);
                if (transform.position.x > -7.34 + Parent.transform.position.x)
                {
                    
                    transform.position += new Vector3(-2f, 0, transform.position.z) * Time.deltaTime;
                }
                else
                {
                    //  LeftDoorRigidbody2D.linearVelocity = new Vector2(0, 0);
                    MoveFinished = true;
                }
            }
        }
        else
        {
            time2 += Time.deltaTime;
        }
    }
}
