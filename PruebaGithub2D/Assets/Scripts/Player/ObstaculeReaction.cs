﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Personal2D.Move;

namespace Personal2D.Reaction
{
    public class ObstaculeReaction : MonoBehaviour
    {
        public Slider health;
        Rigidbody2D body;

        GameObject GameOverScreen;

        // Start is called before the first frame update
        void Start()
        {

            body = gameObject.GetComponent<Rigidbody2D>();
            GameOverScreen=GameObject.FindGameObjectWithTag("GameOver");
            GameOverScreen.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void OnCollisionEnter2D(Collision2D obstacule)
        {
            switch(obstacule.gameObject.tag){
                case "Obstaculos":
                      //var magnitud=1000;
                      /*
                      var fuerza = gameObject.transform.position - obstacule.transform.position;
                      fuerza.Normalize();
                       */
                    //body.AddForce(fuerza*magnitud);
                    body.AddForce(new Vector2(0, 50), ForceMode2D.Impulse);
                    health.value-=10;
                    //Debug.Log("" + obstacule.gameObject.name + " /" + obstacule.gameObject.tag);
                    if(health.value<=0){
                        GameOverScreen.SetActive(true);
                        GameManager.instance.GameOver();
                    }
                
                break;
                case "Jumper":
                    body.AddForce(new Vector2(0, 240), ForceMode2D.Impulse);
                ;break;

                case "Gemas":
                    AudioManager.instance.CollectedGem();
                    GameManager.instance.Agarrar(1);
                
                ;break;

                case "Fin":
                    SceneManager.LoadSceneAsync(0);
                
                ;break;

                case "Mortales":
                    GameOverScreen.SetActive(true);
                    GameManager.instance.GameOver();
                
                ;break;

            }

            /*
            if (obstacule.gameObject.tag == "Obstaculos")
            {
                //var magnitud=1000;
                var fuerza = gameObject.transform.position - obstacule.transform.position;
                fuerza.Normalize();
                //body.AddForce(fuerza*magnitud);
                body.AddForce(new Vector2(0, 40), ForceMode2D.Impulse);
                health.value-=10;
                //Debug.Log("" + obstacule.gameObject.name + " /" + obstacule.gameObject.tag);
            }
            else if (obstacule.gameObject.tag == "Jumper")
            {
                body.AddForce(new Vector2(0, 140), ForceMode2D.Impulse);
            }

            if(obstacule.gameObject.tag == "Gemas"){
                
                AudioManager.instance.CollectedGem();
                GameManager.instance.Agarrar(1);
            }

            if(obstacule.gameObject.tag == "Fin"){
                SceneManager.LoadSceneAsync(0);
            }
             */
            


        }
    }

}
