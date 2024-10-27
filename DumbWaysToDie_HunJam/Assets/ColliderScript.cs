using System;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObjectControllerScript objectController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Character")
        {
            //right.SetBool("Start",true);
            //left.SetBool("Start",true);
            objectController.LoadSecondFloor();
            
        }
    }
}
