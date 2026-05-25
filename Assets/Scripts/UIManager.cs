using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoscore;
    public TextMeshProUGUI textoTiempo;

    void Start()
    {
        UpdateScore(0);
    }
        public void UpdateScore(int score){
            textoscore.text = "Score: " + score.ToString();
        }

        public void UpdateTime(float tiempo)
    {
            textoTiempo.text = "Tiempo: " + tiempo.ToString("F2");
    }

}
