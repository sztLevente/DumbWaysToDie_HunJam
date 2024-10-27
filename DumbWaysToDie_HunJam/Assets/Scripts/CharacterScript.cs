using System;
using Unity.VisualScripting;
using UnityEngine;
using Math = Unity.Mathematics.Geometry.Math;

public class CharacterScript : MonoBehaviour, IGravity
{
    private Vector2 RightSpeed = new Vector2(5, 0);
    private Vector2 LeftSpeed = new Vector2(-5, 0);

    private Animator CharacterAnimator;
    private Rigidbody2D CharacterRigidbody2D;

    private bool flying = false;
    private bool upsideDown = false;
    private float flyTime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //flying = false;
        CharacterAnimator = GetComponent<Animator>();
        CharacterRigidbody2D = GetComponent<Rigidbody2D>();
        CharacterRigidbody2D.gravityScale = 1;

        CharacterRigidbody2D.sharedMaterial = new PhysicsMaterial2D() { friction = 0, bounciness = 0 };

        // Perd�letre hat� s�rl�d�s kikapcsol�sa
        CharacterRigidbody2D.angularDamping = 0f;

        // Perd�let �s forg�s kikapcsol�sa
        CharacterRigidbody2D.freezeRotation = true;

        //CharacterRigidbody2D.linearVelocity = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
       if(flying)
       {
            //CharacterRigidbody2D.linearVelocity = new Vector3(0, 0, -1);
            flyTime += Time.deltaTime;
            if(flyTime >= 0.8)
            {
                flying = false;
                upsideDown = !upsideDown;
                flyTime = 0;
            }
       }
       else
       {
            Move();
       }
     
       
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CharacterRigidbody2D.linearVelocity = RightSpeed;
            CharacterAnimator.SetBool("Walking",true);
            if (upsideDown)
            {
                transform.rotation = Quaternion.Euler(180,0,0);
            }
            else {
                 transform.rotation = new Quaternion(0,0,0f,0);
            }
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            CharacterRigidbody2D.linearVelocity = new Vector3(0,0,-2);
            CharacterAnimator.SetBool("Walking",false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = LeftSpeed;
            CharacterAnimator.SetBool("Walking",true);
            if (upsideDown)
            {
                transform.rotation = Quaternion.Euler(180,180,0);
            }
            else {
                transform.rotation = new Quaternion(0,180,0,0);
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = new Vector3(0,0,-2);
            CharacterAnimator.SetBool("Walking",false);
        }
    }
    public void Die()
    {
        Debug.Log("I died");
    }

    

    public void SetFly(bool state)
    {
        if (state)
        {
            flying = true;
            CharacterRigidbody2D.linearVelocity = new Vector3(0, 0, 0);
            CharacterRigidbody2D.gravityScale = -1.5f;
        }
        else
        {
            flying = true;
            CharacterRigidbody2D.linearVelocity = new Vector3(0, 0, 0);
            CharacterRigidbody2D.gravityScale = 1.5f;
        }
    }
}
