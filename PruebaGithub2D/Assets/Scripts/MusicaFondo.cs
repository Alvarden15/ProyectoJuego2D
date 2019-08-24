using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{

    AudioSource source;
    AudioClip[] clips;

    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
        clips = GetComponent<ListaSonidos>().clips;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
