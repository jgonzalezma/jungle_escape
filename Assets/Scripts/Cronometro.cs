using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoCrono;
    [SerializeField] private float tiempo;

    private int tiempoMinutos, tiempoSegundos, tiempoDecimasSegundo;
    private bool cronometroCorriendo = true;

    public GameObject deathCanvas;
    private DeathController deathController;

    private void Start()
    {
        deathController = deathCanvas.GetComponent<DeathController>();
        deathCanvas.SetActive(false);
        if (deathController != null )
        {
            deathController.DesactivarMenuPausa();
        }
    }

    void ActualizarCronometro()
    {
        if (cronometroCorriendo)
        {
            tiempo += Time.deltaTime;

            tiempoMinutos = Mathf.FloorToInt(tiempo / 60);
            tiempoSegundos = Mathf.FloorToInt(tiempo % 60);
            tiempoDecimasSegundo = Mathf.FloorToInt((tiempo % 1) * 100);

            textoCrono.text = string.Format("{0:00}:{1:00}:{2:00}", tiempoMinutos, tiempoSegundos, tiempoDecimasSegundo);
        }
    }

    private void Update()
    {
        ActualizarCronometro();
    }
    public void DetenerCronometro()
    {
        cronometroCorriendo = false;
        deathCanvas.SetActive(true);
        deathController.ActivarMenuPausa();
        Time.timeScale = 0;
    }
}
