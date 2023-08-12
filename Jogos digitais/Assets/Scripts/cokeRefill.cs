using UnityEngine;

public class cokeRefill : MonoBehaviour
{
    [Header("Animation Variables")]
    private Animator _anim;
    private bool isTimerActive = false;
    private float timerDuration = 4.0f;
    private float timer;
    private PlayerMovement player;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (isTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isTimerActive = false;
                _anim.SetBool("isInnactive", false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.GetComponent<PlayerMovement>();

        if (player != null && !_anim.GetBool("isInnactive") && player.HasDash())
        {
            player.RefreshDash();
            _anim.SetBool("isInnactive", true);
            isTimerActive = true;
            timer = timerDuration;
        }
    }
}
