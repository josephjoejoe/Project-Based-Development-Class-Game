using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCon : MonoBehaviour
{
    public float CD = 1;
    public bool EndCD = false;
    public SpriteRenderer Block;
    public float opac = 0;

    public bool fix = false;
    // Update is called once per frame
    void Update()
    {
        if(EndCD)
        {
            CD -= Time.deltaTime;
            opac += (Time.deltaTime/2);
        }
        if(CD <= 0.01f)
        {
            EndScenario();
            CD = 1;
            EndCD = false;
        }
        Block.color = new Color(0.4f,0.4f,0.4f,opac);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Pipe"))
        {
            EndCD = true;
            //EndScenario();
        }
    }
    
    public void EndScenario()
    {
        if(GameManage.Instance.EndCheck())
        {
            GameManage.Instance.WinProc();
        }
       
    }

    public void BadTrigger()
    {
        
    }
    public void TriggerFix()
    {
        
    }
}
