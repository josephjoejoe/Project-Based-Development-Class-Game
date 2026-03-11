using UnityEngine;

public class ToolOneTest : MonoBehaviour
{
    public bool stove;
    public bool stoveAirVent;
    public bool exitVent;

    public GameObject goodResult;
    public GameObject badResult;

    public float testTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stove == true || (stoveAirVent == true) || (exitVent == true))
        {
            testTimer += Time.deltaTime;
        }
        else
        {
            testTimer = 0;
        }

        if (stove == true && testTimer > 3)
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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Stove"))
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
        if (collision.CompareTag("Stove"))
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

    public void GoodTestResults()
    {
        goodResult.SetActive(true);
    }
    public void BadTestResults()
    {
        badResult.SetActive(true);
    }
    public void ResetTestResults()
    {
        goodResult.SetActive(false);
        badResult.SetActive(false);
    }
}
