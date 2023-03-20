using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Over : MonoBehaviour
{
    [SerializeField] protected Collider2D _collider2D;

    [SerializeField] protected RawImage endBg;
    [SerializeField] protected Text totalScore, playAgain, gameOver, score;
    private bool isOver = false;
    
    private void Update()
    {
        if (!isOver) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mountain"))
        {
            score.GameObject().SetActive(false);
            endBg.GameObject().SetActive(true);
            totalScore.GameObject().SetActive(true);
            totalScore.text=Math.Ceiling(LevelManager.instance.score).ToString();
            playAgain.GameObject().SetActive(true);
            gameOver.GameObject().SetActive(true);
            Time.timeScale = 0f;
            isOver = true;
            AudioManager.instance.Play("gameOver");
        }
    }
}
