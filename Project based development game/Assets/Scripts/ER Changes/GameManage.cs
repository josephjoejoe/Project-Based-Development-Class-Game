using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public GameObject Location;
    
    public GameObject WinButt;

    public AudioSource pop; 
    public AudioClip bub;
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
        pop = GetComponent<AudioSource>();
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
        ChangeInit("Next");
        Tool.SetActive(false);
        ToolBar.SetActive(false);
        Pipes.SetActive(true);
        Pipebars.SetActive(true);
    Destroy(NextPhase);
    }

    public void WinProc()
    {
        ChangeInit("Win");
        WinButt.SetActive(true);   
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene(0);
    }

    public void bubble()
    {
        pop.PlayOneShot(bub);
    }
    public void ChangeInit(string step)
    {
        RatScript rat = RatPost.GetComponent<RatScript>();
        switch(step)
        {
            case "Check":
                {
                    if(rat!= null){
                    rat.ChangeText("This Stove says it's not feeling too well. We will see if that is the case.");}
                    break;
                }
            case "Done":
                {
                    if(rat!= null)
                    {
                        rat.ChangeText("It seems that the Stove is doing fine! Time to get this hooked onto the exit vent. Press the Next Phase button on the bottom right");
                    }
                    break;
                }
            case"Next":
                {
                    if(rat != null)
                    {
                        rat.ChangeText("Now that we are laying down the pipes. Drag the pipes from the top left bar to the living space so that the exit vent and Stove connects. Make sure the pipes are connecting too!");
                    }
                    break;
                }
            case "Win":

                {
                    if(rat != null)
                    {
                        rat.ChangeText("Congrats, now we can move to more houses with more problems");
                    }
                    break;
                }
        }
    }
}
