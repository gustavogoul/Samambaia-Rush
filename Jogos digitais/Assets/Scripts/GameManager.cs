using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }

        
    }
    private void OnDestroy()
    {
        if(Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        gameSpeed = initialSpeed;
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.fixedDeltaTime;
    }
}
