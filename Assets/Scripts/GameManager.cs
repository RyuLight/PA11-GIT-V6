using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void ScoreUpdate(int increase)
    {
        score += increase;
    }

    public void OnRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
