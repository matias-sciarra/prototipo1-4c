using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxscore = 4;

    public float tiempo = 30f;

    public UIManager uiManagerScript;

    private bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;

        uiManagerScript = GameObject.FindObjectOfType<UIManager>();

        uiManagerScript.UpdateScore(score);
        uiManagerScript.UpdateTime(tiempo);
    }

    void Update()
    {
        // reiniciar con R
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // si terminó el juego, no seguir
        if (juegoTerminado)
        {
            return;
        }

        // timer
        tiempo -= Time.deltaTime;

        if (tiempo <= 0)
        {
            tiempo = 0;

            juegoTerminado = true;

            uiManagerScript.MostrarPantallaGameOver();

            Time.timeScale = 0;
        }

        uiManagerScript.UpdateTime(tiempo);

        // win
        if (score >= maxscore)
        {
            juegoTerminado = true;

            uiManagerScript.MostrarPantallaWin();

            Time.timeScale = 0;
        }
    }

    public void AddScore()
    {
        score++;

        uiManagerScript.UpdateScore(score);
    }
}