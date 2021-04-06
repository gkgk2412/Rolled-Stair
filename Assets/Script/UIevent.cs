using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIevent : MonoBehaviour
{
    public GameObject UIPanel;

    private bool uiPanelOn = false;
    private bool pauseOn = false;

    void Start()
    {
        UIPanel.SetActive(false);
        uiPanelOn = false;
        pauseOn = false;
    }

    public void PauseButton()//일시정지 버튼을 눌렀을 때 처리.
    {
        Time.timeScale = 0; //시간 흐름 비율을 0으로
        if(pauseOn==false)
        {
            UIPanel.SetActive(true);
            uiPanelOn = true;
            pauseOn = true;
        }
    }
    
    public void ResumeButton()
    {
        Time.timeScale = 1;
        if(pauseOn == true)
        {
            UIPanel.SetActive(false);
            uiPanelOn = false;
            pauseOn = false;
        }
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("Main");
    }
}
