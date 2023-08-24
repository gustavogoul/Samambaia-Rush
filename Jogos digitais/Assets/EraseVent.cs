using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseVent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject gridObject = GameObject.Find("Vent");

            if (gridObject != null)
            {
                Destroy(gridObject);
            }
        }
    }
}
