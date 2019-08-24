using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Personal2D.Move;

namespace Personal2D.Reaction
{
    public class ObstaculeReaction : MonoBehaviour
    {
        Slider health;
        Rigidbody2D body;

        // Start is called before the first frame update
        void Start()
        {

            body = gameObject.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void OnCollisionEnter2D(Collision2D obstacule)
        {
            if (obstacule.gameObject.tag == "Obstaculos")
            {
                //var magnitud=1000;
                var fuerza = gameObject.transform.position - obstacule.transform.position;
                fuerza.Normalize();
                //body.AddForce(fuerza*magnitud);
                body.AddForce(new Vector2(0, 40), ForceMode2D.Impulse);
                Debug.Log("" + obstacule.gameObject.name + " /" + obstacule.gameObject.tag);
            }
            else if (obstacule.gameObject.tag == "Jumper")
            {
                body.AddForce(new Vector2(0, 140), ForceMode2D.Impulse);
            }
        }
    }

}
