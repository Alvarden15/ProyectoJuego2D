using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{

    public Slider health;
    public Slider stamina;

    float cantidad;
    bool isSprinting;
    // Start is called before the first frame update
    void Start()
    {
        health.value=100;
        stamina.value=100;
        cantidad=100;
    }

    void FixedUpdate() {
        if(Input.GetKey(KeyCode.LeftShift) && cantidad>0){
                cantidad-=1f;

        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            while(cantidad<100){
                cantidad+=0.5f;
            }
            
        }

        stamina.value=cantidad;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
