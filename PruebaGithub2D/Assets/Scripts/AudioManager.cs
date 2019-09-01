using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] clips;

    public static AudioManager instance=null;

    public AudioSource effects;
    // Start is called before the first frame update
    void Awake()
    {
        /*
       
         */
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(gameObject);
        }
         DontDestroyOnLoad(this);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectedGem(){
        effects.volume=0.4f;
        effects.clip=clips[0];
        effects.Play();
    }
    public void PlayClip(AudioClip clip){
        effects.clip=clip;
        effects.Play();
    }
}
