using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManage : MonoBehaviour
{
    public static GameManage Instance {get; private set; }
    public List<GameObject> pipes = new List<GameObject>();
    public bool bruh;
    public int pCount = 0;
    public int TCount = 0;
    public GameObject NextPhase;
    public GameObject Tool;
    public GameObject ToolBar;
    public GameObject Pipes;
    public GameObject Pipebars;
    public GameObject RatPre;
    public GameObject RatPost;
 
    private void Awake()
    {
       if(Instance != null && Instance != this)
        {
            Destroy(this);
        } 
        else
        {
            Instance = this;
        }
    }

    public void Start()
    {
        RatPost = Instantiate(RatPre);
    }
    public void Update()
    {
         if(Input.GetMouseButtonDown(1))
        {
         Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if(hit.collider.gameObject.CompareTag("ExitVent"))
            {
                ExitCon CC = hit.collider.gameObject.GetComponent<ExitCon>();
                if(CC != null)
                {
                    CC.TriggerFix();
                }
            } 
        
        }

        if(Input.GetMouseButtonDown(1))
        {
         Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
         
        if(hit)
            {
                pipes.Remove(hit.collider.gameObject);
                Destroy(hit.collider.gameObject);
            }
        }
        pCount = pipes.Count;
        
    }

    public void AddPipe(GameObject other)
    {
        pipes.Add(other);
    }
    public bool EndCheck()
    {
      Debug.Log(pCount);
        for (int i = 0; i < pipes.Count - 1 ; i++)
        {
            PipeField pip = pipes[i + 1].GetComponent<PipeField>();
            if(pip != null)
            {
                if(pip.Connected == false)
                {
                    return false;
                    
                }
                else
            {
                bruh = true;
            }
            }
            
        }
        Debug.Log(TCount);   
        return bruh;
    }

    public void NP()
    {
        Tool.SetActive(false);
        ToolBar.SetActive(false);
        Pipes.SetActive(true);
        Pipebars.SetActive(true);
    Destroy(NextPhase);
    }
}
