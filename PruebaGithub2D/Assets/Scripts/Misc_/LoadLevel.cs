using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public GameObject loader;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = loader.GetComponent<Slider>();
        StartCoroutine(Load(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // Update is called once per frame
    IEnumerator Load(int index)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(index);
        var n = operacion.progress;
        while (!operacion.isDone)
        {
            float progress = Mathf.Clamp01(operacion.progress / .9f);
            slider.value = progress;
            yield return null;
        }


    }

    
}
