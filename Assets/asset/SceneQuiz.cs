using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneQuiz : MonoBehaviour
{
    public void QuizFix()
    {
        SceneManager.LoadScene("QuizFix");
    }

    public void VideoMateri()
    {
        SceneManager.LoadScene("VideoMateri");
    }

    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

     public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}