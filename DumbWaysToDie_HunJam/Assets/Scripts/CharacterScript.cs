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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterAnimator = GetComponent<Animator>();
        CharacterRigidbody2D = GetComponent<Rigidbody2D>();
        CharacterRigidbody2D.gravityScale = 0;
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
            CharacterAnimator.SetBool("Walking",true);
            if (flying)
            {
                transform.rotation = Quaternion.Euler(180,0,0);
            }
            else {
                 transform.rotation = new Quaternion(0,0,0f,0);
            }
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            CharacterRigidbody2D.linearVelocity = new Vector3(0,0,-1);
            CharacterAnimator.SetBool("Walking",false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = LeftSpeed;
            CharacterAnimator.SetBool("Walking",true);
            if (flying)
            {
                transform.rotation = Quaternion.Euler(180,180,0);
            }
            else {
                transform.rotation = new Quaternion(0,180,0,0);
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            CharacterRigidbody2D.linearVelocity = new Vector3(0,0,-1);
            CharacterAnimator.SetBool("Walking",false);
        }
    }
    public void Die()
    {
        
    }

    public void Fly()
    {
        flying = true;
        CharacterRigidbody2D.gravityScale = -1;
        this.transform.rotation = Quaternion.Euler(180,0,0);
    }
}
