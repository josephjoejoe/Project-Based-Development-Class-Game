using UnityEngine;

public class ToolOneTest : MonoBehaviour
{
    public bool stove;
    public bool stoveAirVent;
    public bool exitVent;
    public bool gotResults;

    public GameObject goodResult;
    public GameObject badResult;

    public float testTimer = 0;
    public float resetTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stove == true || (stoveAirVent == true) || (exitVent == true)) // the tool starts to test the appliance
        {
            testTimer += Time.deltaTime;
        }
        else
        {
            testTimer = 0; // if the tool is not on the appliance the timer get set back to zero
        }

        if (stove == true && testTimer > 3) // you get the results after 3 second on staying on the appliance
        {
            GoodTestResults();
        }
        if (stoveAirVent == true && testTimer > 3)
        {
            BadTestResults();
        }
        if (exitVent == true && testTimer > 3)
        {
            BadTestResults();
        }

        if(stove == false || (stoveAirVent == false) || (exitVent == false) && gotResults == true) // this helps the results show longer after you drag the tool away from the appiance
        {
            resetTimer += Time.deltaTime; 
        }
        
        if (resetTimer > 1) // when time is over 1 second the results will disapear
        {
            ResetTestResults();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Stove")) // checks to see if the tool on the stove
        {
            stove = true;
        }
        if (collision.gameObject.tag.Equals("StoveAirVent"))
        {
            stoveAirVent = true;
        }
        if (collision.gameObject.tag.Equals("ExitVent"))
        {
            exitVent = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Stove")) // checks to see if the tool isnt on the stove
        {
            stove = false;
        }
        if (collision.CompareTag("StoveAirVent"))
        {
            stoveAirVent = false;
        }
        if (collision.CompareTag("ExitVent"))
        {
            exitVent = false;
        }
    }

    public void GoodTestResults() // will make the result appear as good
    {
        goodResult.SetActive(true);
        gotResults = true;
    }
    public void BadTestResults() // will make the result appear as bad
    {
        badResult.SetActive(true);
        gotResults = true;
    }
    public void ResetTestResults() // will make the result go away
    {
        goodResult.SetActive(false);
        badResult.SetActive(false);
        gotResults = false;
        resetTimer = 0;
    }
}
