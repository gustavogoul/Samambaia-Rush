using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Ground : MonoBehaviour
{
    private void Awake()
    {
    }

    private void Update()
    {
        transform.position -= new Vector3(6f * Time.deltaTime, 0, 0);
    }
}
