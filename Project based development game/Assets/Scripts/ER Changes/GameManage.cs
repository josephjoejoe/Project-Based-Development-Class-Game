using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public static GameManage Instance {get; private set; }
    public List<GameObject> pipes = new List<GameObject>();
    public bool bruh;
    public int pCount = 0;
    public int TCount = 0;
 
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
    public void Update()
    {
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
        for (int i = 1; i < (pipes.Count ); i++)
        {
            PipeField pip = pipes[i + 1].GetComponent<PipeField>();
            if(pip != null)
            {
                if(pip.Connected)
                {
                    TCount ++;
                }
                else
            {
                Debug.Log("Bruh");
            }
            }
            if(TCount == pCount)
            {
                bruh = true;
            }
            else
            {
                bruh = false;
            }
        }
        Debug.Log(TCount);
        return bruh;
    }
}
