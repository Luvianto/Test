using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// import terlebih dahulu Scene Management
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void playGame(){
        // Menampilkan scene Flappy Bird
        SceneManager.LoadScene(0);
    }

    // Function quitGame untuk keluar dari game
    public void quitGame(){
        Application.Quit();
    }
}
