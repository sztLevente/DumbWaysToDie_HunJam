using UnityEngine;

public class ButtonDown : MonoBehaviour, IGravity
{
    public GameObjectControllerScript GameObjectControllerScript;
    public Animator pushAnim;

    public void SetFly(bool state)
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Character")
        {
            GameObjectControllerScript.SetGravityOff(false);
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
