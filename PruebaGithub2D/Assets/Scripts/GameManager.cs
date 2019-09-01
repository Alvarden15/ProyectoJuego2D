using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool over;
    int colectados;
    public static GameManager instance=null;
    private void Awake() {
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
        colectados=0;
    }

    public void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Agarrar(int i){
        
        colectados+=0;
    }

    public void Mostrar(){

    }
   
}
