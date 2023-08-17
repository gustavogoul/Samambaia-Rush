using UnityEngine;

public class Spikes : MonoBehaviour
{
    private Transform _destination;
    [SerializeField] private PlayerMovement player;
    LayerMask _spikeLayer;
    private bool _touched;

    private void Start()
    {
        _spikeLayer = LayerMask.GetMask("Spike");
        _destination = GameObject.Find("Respawn").transform;
    }

    private void FixedUpdate() 
    {
        HandleTouch();
    }

    public void setNewDestination(Transform destination)
    {
        _destination = destination;
    }

    private void HandleTouch()
    {
        if (player != null)
        {
            BoxCollider2D boxCollider = player.getBoxCollider2D();
            if (boxCollider != null)
            {
                RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.03f, _spikeLayer);
                _touched = raycastHit.collider != null;
                if (_touched) Teleport();
            }
        }
    }

    private void Teleport()
    {
        player.setPos(_destination);
    }
}
