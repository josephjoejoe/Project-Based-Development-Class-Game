using UnityEngine;

public class PracticeForCase : MonoBehaviour
{// for practice ONLY

    //public bool stove;
    //public bool stoveAirVent;
    //public bool exitVent;
    //public bool gotResults;

    //public GameObject goodResult;
    //public GameObject badResult;

    //public GameObject stove;

    //public float testTimer = 0;
    //public float resetTimer = 0;

    //public GameObject appliance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //switch(appliance)
        //{
        //    case stove: Debug.Log("i selected stove"); break;
        //    case stoveAirVent: Debug.Log("i selected stove air vent"); break;
        //    case exitVent1: Debug.Log("i selected exit vent"); break;
        //}

        //if (stove == true || (stoveAirVent == true) || (exitVent == true))
        //{
        //    testTimer += Time.deltaTime;
        //}
        //else
        //{
        //    testTimer = 0;
        //}

        //if (stove == true && testTimer > 3)
        //{
        //    GoodTestResults();
        //}
        //if (stoveAirVent == true && testTimer > 3)
        //{
        //    BadTestResults();
        //}
        //if (exitVent == true && testTimer > 3)
        //{
        //    BadTestResults();
        //}

        //if (stove == false || (stoveAirVent == false) || (exitVent == false) && gotResults == true)
        //{
        //    resetTimer += Time.deltaTime;
        //}

        //if (resetTimer > 1)
        //{
        //    ResetTestResults();
        //}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag.Equals("Stove"))
        //{
        //    stove = true;
        //}
        //if (collision.gameObject.tag.Equals("StoveAirVent"))
        //{
        //    stoveAirVent = true;
        //}
        //if (collision.gameObject.tag.Equals("ExitVent"))
        //{
        //    exitVent = true;
        //}

        //appliance = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.CompareTag("Stove"))
        //{
        //    stove = false;
        //}
        //if (collision.CompareTag("StoveAirVent"))
        //{
        //    stoveAirVent = false;
        //}
        //if (collision.CompareTag("ExitVent"))
        //{
        //    exitVent = false;
        //}
    }

    public void GoodTestResults()
    {
        //goodResult.SetActive(true);
        //gotResults = true;
    }
    public void BadTestResults()
    {
        //badResult.SetActive(true);
        //gotResults = true;
    }
    public void ResetTestResults()
    {
        //goodResult.SetActive(false);
        //badResult.SetActive(false);
        //gotResults = false;
        //resetTimer = 0;
    }
}
