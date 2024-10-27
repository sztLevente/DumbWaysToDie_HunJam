using UnityEngine;
using UnityEngine.SceneManagement; // Importáljuk a SceneManagement névteret

public class Clocky : MonoBehaviour
{
    public Rigidbody2D clock;
    public float rotationSpeed = 360f;

    private void Start()
    {
        StartCoroutine(SwitchSceneAfterDelay(1.5f));
    }

    void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        clock.transform.Rotate(0, 0, rotationAmount);
    }

    private System.Collections.IEnumerator SwitchSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("mainScene");
    }
}
