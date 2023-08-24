using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject acorda;
    public GameObject atrasar;
    public GameObject filho;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (acorda.activeInHierarchy == true)
        {
            acorda.SetActive(false);
            atrasar.SetActive(true);
        }

        if (atrasar.activeInHierarchy == true)
        {
            atrasar.SetActive(false);
            filho.SetActive(true);
        }

        else
        {
            Application.Quit();
        }
    }
}
