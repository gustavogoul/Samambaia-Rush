using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transicao : MonoBehaviour
{
    [SerializeField] private string sceneTargetName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que colidiu � o jogador
        if (collision.CompareTag("Player"))
        {
            GotoScene();
        }
    }

    private void GotoScene() 
    {
        if (!string.IsNullOrEmpty(sceneTargetName))
        {
            SceneManager.LoadScene(sceneTargetName);
        }
    }
}
