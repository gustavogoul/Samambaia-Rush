using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    public AudioSource keyPressed;

    // Start is called before the first frame update
    void Start()
    {
        keyPressed = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("ParteInicial");
            keyPressed.Play();
        }
    }
}
