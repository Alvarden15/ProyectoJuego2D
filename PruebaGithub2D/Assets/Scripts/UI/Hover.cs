using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    AudioSource source;
    AudioClip[] Sonidos;
    GameObject panel;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        source = GameObject.FindGameObjectWithTag("Main").GetComponent<ListaSonidos>().source;
        Sonidos = GameObject.FindGameObjectWithTag("Main").GetComponent<ListaSonidos>().clips;
    }
   

    public void pointerEnter()
    {
        source.clip = Sonidos[0];
        source.Play();
    }

/*
    public void OnMouseOver()
    {
       
        source.clip = Sonidos[0];
        source.Play();
    }

    private void OnMouseDown()
    {
        source.clip = Sonidos[1];
        source.Play();
    }

 */

    public void push()
    {
        source.clip = Sonidos[1];
        source.Play();
    }
}
