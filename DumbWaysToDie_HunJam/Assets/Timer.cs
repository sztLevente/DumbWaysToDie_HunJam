using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObjectControllerScript timer;
    public Text text;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = Mathf.FloorToInt(60f - timer.time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.time <= 60)
        {
            text.text = Mathf.FloorToInt(60f - timer.time).ToString();
        }
    }
}
