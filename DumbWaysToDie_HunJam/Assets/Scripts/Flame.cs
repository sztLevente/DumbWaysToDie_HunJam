using Unity.VisualScripting;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public Rigidbody2D BoxBody;
    public SpriteRenderer renderer;
    public CharacterScript character;
    public GameObjectControllerScript timer;

    void Start()
    {
        BoxBody.GetComponent<Collider2D>().enabled = false;
        renderer.enabled = false;
    }
    void Update()
    {
        if (timer.time >= 9f)
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
        }
        if (collision.gameObject.GetComponent<BoxScript>() != null)
        {
            Destroy(collision.gameObject);
        }

    }
}
