using UnityEngine;
using UnityEngine.TextCore.Text;

public class PoisionObject : MonoBehaviour
{

    public Rigidbody2D PoisonBody;
    public CharacterScript character;
    public SpriteRenderer renderer;
    public GameObjectControllerScript timer;
    
    void Start()
    {
        PoisonBody.GetComponent<Collider2D>().enabled = false;
        renderer.enabled = false;
    }
    void Update()
    {
 
        if (timer.time >= 3f)
        {
            renderer.enabled = true;
            PoisonBody.GetComponent<Collider2D>().enabled = true;
        }
        else 
        {
            renderer.enabled = false;
            PoisonBody.GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CharacterScript>() != null)
        {
            character.Die();
            character.transform.position = new Vector2(-9f, -1f);
        }
    }
}

