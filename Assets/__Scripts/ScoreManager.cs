using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{ 
    public Text scoreText;
    public Text timeText;
    public static float time;
    public float speed = 1;

    void Start()
    {
        
    }
    void Update()
    {
        scoreText.text = EnemyScript.score.ToString();
        time += Time.deltaTime * speed;
        string seconds = (time % 60).ToString("000");
        timeText.text = seconds;

        if (EnemyScript.score == 10)
        {
            time = time;
            SceneManager.LoadScene(sceneName:"End");
        }
    }
}