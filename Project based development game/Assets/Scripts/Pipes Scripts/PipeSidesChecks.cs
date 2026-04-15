using UnityEngine;

public class PipeSidesChecks : MonoBehaviour
{
    public bool rightSideConnected;
    

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
        if (collision.gameObject.CompareTag("Stove") || collision.gameObject.CompareTag("StoveAirVent") || collision.gameObject.CompareTag("ExitVent"))
        {
            rightSideConnected = true;
        }    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stove") || collision.gameObject.CompareTag("StoveAirVent") || collision.gameObject.CompareTag("ExitVent"))
        {
            rightSideConnected = false;
        }
    }
}
