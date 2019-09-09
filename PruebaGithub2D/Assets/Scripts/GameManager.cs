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

    GameObject GameOverScreen;
    private void Awake() {
        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);

        colectados=0;
        PlayerPrefs.SetInt("colectados",0);
        //GameOverScreen=GameObject.FindGameObjectWithTag("GameOver");
        //GameOverScreen.SetActive(false);
    }

    private void Start() {
        
        /*
        
         */
        
    }
    public void GameOver(){
        Time.timeScale = 0;
        //GameOverScreen.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Agarrar(int i){

        colectados+=i;
        Debug.Log("Gemas colectadas: "+colectados);
    }

    public void Mostrar(){

    }
   
}
