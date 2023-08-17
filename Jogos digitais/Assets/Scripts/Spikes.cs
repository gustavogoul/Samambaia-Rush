using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private PlayerMovement player;
    LayerMask _spikeLayer;
    private bool _touched;

    private void Start()
    {
        _spikeLayer = LayerMask.GetMask("Spike");
    }

    private void FixedUpdate() 
    {
        HandleTouch();
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
        player.setPos(destination);
    }
}
