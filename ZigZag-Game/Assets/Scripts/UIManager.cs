using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject zigzagPanel;
    public GameObject GameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highscore1;
    public Text highscore2;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore1.text ="High Score:  "+ PlayerPrefs.GetInt("highscore");
    }

    public void GameStart()
    {
       
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highscore").ToString();
        GameOverPanel.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
