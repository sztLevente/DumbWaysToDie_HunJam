//using UnityEditor.Animations;
using UnityEngine;

public class Unicorn : MonoBehaviour
{


    public Sprite ActionSprite;
    public Sprite SleepSprite;
    /*public AnimatorController Action;
    public AnimatorController SleepAnimation;*/
    private float timeSinceStart = 0;
    public Animator animator;
    private bool killer = false;
    public GameObjectControllerScript gameObjectController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Character" && killer)
        {
            gameObjectController.KillCharacter();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = ActionSprite;
        //animator.runtimeAnimatorController = Action;
        killer = true;
        
       
    }
    void Update()
    {
        timeSinceStart += Time.deltaTime;
        if (timeSinceStart < 1.0f)
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector3(2, 0, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
        }
        if (timeSinceStart >= 10.0f)
        {
            GetComponent<SpriteRenderer>().sprite = SleepSprite;
            //animator.runtimeAnimatorController = SleepAnimation;
            killer = false;
        }

    }
}
