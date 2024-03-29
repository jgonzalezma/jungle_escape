using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        if (playerController == null)
        {
            Debug.LogWarning("PlayerController no encontrado en la escena.");
        }
    }
    public void JugarDeNuevo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("InGameScene");
    }

    public void MenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }

    public void ActivarMenuPausa()
    {
        Time.timeScale = 0;
        playerController.enabled = false;
    }

    public void DesactivarMenuPausa()
    {
        Time.timeScale = 1;
        playerController.enabled = true;
    }
}
