using UnityEngine;

public class Tire : MonoBehaviour, IGravity
{
    private bool flying = false;
    public void SetFly(bool state)
    {
        flying = state;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.rotation = Quaternion.Euler(180, 0, 181);
    }

    // Update is called once per frame
    void Update()
    {
        if(flying)
        {
            //Debug.Log(transform.rotation.z);
            if (transform.rotation.z < 0.45)
            {
                   
                transform.Rotate(new Vector3(0, 0, 20f) * Time.deltaTime);
            }
            
        }
        else
        {
            if (transform.rotation.z > 0)
                transform.Rotate(new Vector3(0, 0, -20f) * Time.deltaTime);
        }
    }
}
