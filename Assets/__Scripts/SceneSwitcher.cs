using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void GotoStartScene()
    {
        SceneManager.LoadScene("Start");
        EnemyScript.score = 0;
        ScoreManager.time = 0;
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
