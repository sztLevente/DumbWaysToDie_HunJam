using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour, IGravity
{
    public GameObjectControllerScript GameObjectControllerScript;
    public GameObject Top;
    public Animator pushAnim;


    public void SetFly(bool state)
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Character")
        {
            GameObjectControllerScript.SetGravityOff(true);
            pushAnim.SetBool("pushed", true);
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
