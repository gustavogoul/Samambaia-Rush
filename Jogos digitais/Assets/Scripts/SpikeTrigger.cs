using UnityEngine;

public class SpikeTrigger : MonoBehaviour
{
    private Transform destination;
    private Spikes[] spikes;

    private void Start()
    {
        destination = GameObject.Find("Respawn").transform;
        spikes = GameObject.FindObjectsOfType<Spikes>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Passou"+ destination.position);
        foreach (Spikes spike in spikes)
        {
             if (spike == null)
             {
                return;
             }
             else
             {
                spike.setNewDestination(destination);
             }
        }
    }
}