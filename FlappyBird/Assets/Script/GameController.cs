using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool isEndGame;
    bool isStart;
    int gamePoint = 0;
    public Text textPoint;
    public GameObject panelEndGame;
    public Text textEndPoint;
    public Button buttonRestart;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isStart = true;
        isEndGame = false;
        panelEndGame.SetActive(false);//tắt panel
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStart)//nhấn chuột trái vào màn hình
            {
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))//Nhấn để bắt đầu
            {
                Time.timeScale = 1;
            }
        }
    }
    public void GamePoint()
    {
        gamePoint++;
        textPoint.text = "Point: " + gamePoint.ToString();
    }
    void StartGame()
    {
        SceneManager.LoadScene(0);//load lại màn chơi
    }
    public void Restart()
    {
        StartGame();
    }
    public void EndGame()
    {
        isEndGame = true;
        isStart = false;
        Time.timeScale = 0;
        panelEndGame.SetActive(true);//dùng để bật panel
        textEndPoint.text = "Your point\n" + gamePoint.ToString();
    }

}
