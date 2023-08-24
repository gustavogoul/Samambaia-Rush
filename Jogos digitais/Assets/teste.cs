using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject acordaCanvas;
    [SerializeField] private GameObject atrasarCanvas;
    private GameObject activeCanvas;

    private void Start()
    {
        // Start with the 'Filho' canvas active
        activeCanvas = transform.Find("Filho").gameObject;
        activeCanvas.SetActive(true);

        acordaCanvas.SetActive(false);
        atrasarCanvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCanvas();
        }
    }

    private void SwitchCanvas()
    {
        // Deactivate the current active canvas
        activeCanvas.SetActive(false);

        // Activate the next canvas in the sequence
        if (activeCanvas == acordaCanvas)
        {
            activeCanvas = atrasarCanvas;
        }
        else if (activeCanvas == atrasarCanvas)
        {
            // Stop at the 'Atrasar' canvas
            return;
        }
        else
        {
            activeCanvas = acordaCanvas;
        }

        activeCanvas.SetActive(true);
    }
}
