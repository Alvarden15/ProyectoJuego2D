using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    bool over;
   
    public static GameManager instance=null;
    private void Awake() {
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void GameOver(){

    }

   
}
