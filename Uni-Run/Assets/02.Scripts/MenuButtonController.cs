using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    public GameObject menuPanel;

    public void Menu_button()
    {
        Time.timeScale = 0; //���� �Ͻ�����
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
        Debug.Log("������ ���� �Ǿ����ϴ�.");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Sub");
        Time.timeScale = 1;
    }
}
