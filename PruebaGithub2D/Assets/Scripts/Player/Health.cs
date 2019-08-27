using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Slider health;
    // Start is called before the first frame update
    void Start()
    {
        health=gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
