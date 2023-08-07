using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Ground : MonoBehaviour
{
    public bool isTheGameOver;
    private void Awake()
    {
    }

    private void Update()
    {
        isTheGameOver = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gameOver;
        if (isTheGameOver == false)
        {
            transform.position -= new Vector3(6f * Time.deltaTime, 0, 0);
        }
    }

    
}
