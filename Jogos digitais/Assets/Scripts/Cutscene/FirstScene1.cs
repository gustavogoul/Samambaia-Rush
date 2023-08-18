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
        
    }

    // Update is called once per frame
    void Update()
    {
        keyPressed = GetComponent<AudioSource>();
        if (Input.anyKey)
        {
            Invoke("ChangeScene", 1.5f);
        }
    }

    private void ChangeScene()
    {
        keyPressed.Play();
        SceneManager.LoadScene("ParteInicial");
    }
}
