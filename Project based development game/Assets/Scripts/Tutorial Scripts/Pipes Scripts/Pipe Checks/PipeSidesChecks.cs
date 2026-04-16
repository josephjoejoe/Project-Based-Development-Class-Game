using UnityEngine;

public class PipeSidesChecks : MonoBehaviour
{
    public LeftSideCheck leftSC; // gets information from that script
    public RightSideCheck rightSC; // gets information from that script

    public bool bothSidesConnected; // when BOTH side of the pipe is connected or not connected to something
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  // checks to see if both sides of the pipe is connected
        if (leftSC.leftSideConnected == true && rightSC.rightSideConnected == true) // gets the bool information from both scripts
        {
            bothSidesConnected = true;
        }
        else // if both sides arent connected
        {
            bothSidesConnected = false;
        }
    }

    
}
