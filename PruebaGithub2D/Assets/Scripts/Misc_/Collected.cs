using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Collected : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag.Equals("Player")){
            animator.SetBool("Collected",true);
        }
    }

    public void Desaparecer(){
        gameObject.SetActive(false);
    }

    public void Transparentar(){
        gameObject.GetComponent<PolygonCollider2D>().enabled=false;
    }
}
