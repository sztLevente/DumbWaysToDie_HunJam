using UnityEngine;
using UnityEngine.TextCore.Text;

public class PoisionObject : MonoBehaviour
{

    public Rigidbody2D PoisonBody;
    public CharacterScript character;
    public SpriteRenderer renderer;

    private float timer = 3.0f;
    
    void Start()
    {
        PoisonBody.GetComponent<Collider2D>().enabled = false;
        renderer.enabled = false;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            renderer.enabled = true;
            PoisonBody.GetComponent<Collider2D>().enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (character != null)
        {
            character.Die();
            character.transform.position = new Vector2(0f, 0f);
        }
    }
}

