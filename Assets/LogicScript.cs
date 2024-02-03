using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int tambah){
        score = score + tambah;
        scoreText.text = score.ToString();
    }
}
