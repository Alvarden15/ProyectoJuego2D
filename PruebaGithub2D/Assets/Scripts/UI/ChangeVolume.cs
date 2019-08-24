using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ChangeVolume : MonoBehaviour
{
    public AudioMixer mixer;
  

    public void changeVolumen(float slider)
    {
        mixer.SetFloat("Volumen",slider);
    }
}
