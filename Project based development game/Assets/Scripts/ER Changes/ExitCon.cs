using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCon : MonoBehaviour
{
    public float CD = 1;
    public bool EndCD = false;

    public bool fix = false;
    // Update is called once per frame
    void Update()
    {
        if(EndCD)
        {
            CD -= Time.deltaTime;
        }
        if(CD <= 0.01f)
        {
            EndScenario();
            CD = 1;
            EndCD = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Pipe"))
        {
            EndCD = true;
            EndScenario();
        }
    }
    
    public void EndScenario()
    {
        if(GameManage.Instance.EndCheck())
        {
            SceneManager.LoadScene(3);  
            Debug.Log("Winner");
        }
        else
        {
            Debug.Log("Bruh");
        }
    }

    public void BadTrigger()
    {
        
    }
    public void TriggerFix()
    {
        
    }
}
