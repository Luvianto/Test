using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameoverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int tambah){
        score = score + tambah;
        scoreText.text = score.ToString();
    }

    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover(){
        gameoverScreen.SetActive(true);
    }
}
