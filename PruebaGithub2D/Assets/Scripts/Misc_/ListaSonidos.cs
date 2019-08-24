using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaSonidos : MonoBehaviour
{

    public AudioClip[] clips;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
      
    }

    
}
