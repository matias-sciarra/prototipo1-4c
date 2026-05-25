using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
 
 {
    public int score = 0;
    public UIManager uiManagerScript;
    public GameManager gameManager;
    
    void Awake()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    } 

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            gameManager.AddScore();
        }
    }
}