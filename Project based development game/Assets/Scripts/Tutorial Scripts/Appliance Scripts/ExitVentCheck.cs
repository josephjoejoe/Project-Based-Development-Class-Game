using UnityEngine;

public class ExitVentCheck : MonoBehaviour
{
    public bool isConnected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checks"))
        {
            isConnected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checks"))
        {
            isConnected = false;
        }
    }
    //problem with the check scripts for appliances is that they are the same thing.
     //I might even consider just removing trigger enter for appliances since I feel like only the pipes need to do the checking and the appliances are there to verify.
}
