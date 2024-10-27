using UnityEngine;

public class Flame : MonoBehaviour
{
    public Rigidbody2D BoxBody;
    public SpriteRenderer renderer;
    public CharacterScript character;
    private float timer = 8.0f;

    void Start()
    {
        BoxBody.GetComponent<Collider2D>().enabled = false;
        renderer.enabled = false;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            BoxBody.GetComponent<Collider2D>().enabled = true;
            renderer.enabled = true;
        }
        else
        {
            BoxBody.GetComponent<Collider2D>().enabled = false;
            renderer.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CharacterScript>() != null)
        {
            character.Die();
            timer = 9.0f;
            character.transform.position = new Vector2(-9f, -1f);
        }
    }
}
