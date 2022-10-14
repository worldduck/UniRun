using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    public GameObject menuPanel;

    public void Menu_button()
    {
        Time.timeScale = 0; //게임 일시정지
        menuPanel.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
    }

    public void GoIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void GameQuit()
    {
        Application.Quit();
        Debug.Log("게임이 종료 되었습니다.");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Sub");
        Time.timeScale = 1;
    }
}
