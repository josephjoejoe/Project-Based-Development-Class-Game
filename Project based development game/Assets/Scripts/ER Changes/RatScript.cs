using System;
using TMPro;
using UnityEngine;

public class RatScript : MonoBehaviour
{
    public TextMeshPro Speaktext;

    public void Awake()
    {
        Speaktext = GetComponentInChildren<TextMeshPro>();
    }
    
    public void ChangeText(String Speech)
    {
        Speaktext.text = Speech;
    }
   
}
