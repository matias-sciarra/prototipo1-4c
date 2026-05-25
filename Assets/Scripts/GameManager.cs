using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxscore = 4;
    public float tiempo = 30f;
    public UIManager uiManagerScript;
    
    void Start()
    {
    uiManagerScript = GameObject.FindObjectOfType<UIManager>();

    uiManagerScript.UpdateScore(score);
    uiManagerScript.UpdateTime(tiempo);
    }

    
    void Update()
    {
        tiempo -= Time.deltaTime;

        uiManagerScript.UpdateTime(tiempo);

        if (tiempo <= 0)
        {
            Debug.Log("Loss");
            tiempo = 0;

        }

    uiManagerScript.UpdateTime(tiempo);

        if (score >= maxscore)
        {
            Debug.Log("Win");
        }

    }

    public void AddScore()
    {
    score ++;
    uiManagerScript.UpdateScore(score);
}

}