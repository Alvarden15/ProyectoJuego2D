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
        health=GameObject.FindGameObjectWithTag("").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<GameManager>();
    }
}
