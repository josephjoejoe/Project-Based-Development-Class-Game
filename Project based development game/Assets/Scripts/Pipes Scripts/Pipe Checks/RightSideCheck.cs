using UnityEngine;

public class RightSideCheck : MonoBehaviour
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
    {   // checks if the the pipe is touching/connected to another thing on the right side
        if (collision.gameObject.CompareTag("Stove") || collision.gameObject.CompareTag("StoveAirVent") || collision.gameObject.CompareTag("ExitVent") || collision.gameObject.CompareTag("Pipe"))
        {
            rightSideConnected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {   // checks if the the pipe is touching/connected to another thing on the right side
        if (collision.gameObject.CompareTag("Stove") || collision.gameObject.CompareTag("StoveAirVent") || collision.gameObject.CompareTag("ExitVent") || collision.gameObject.CompareTag("Pipe"))
        {
            rightSideConnected = false;
        }
    }
}
