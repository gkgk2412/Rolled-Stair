using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; //PointerEventData 사용하기위해 

public class ButtonControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject StartButton;
    public GameObject RankButton;
    private GameObject OptButton;
    private GameObject ReturnButton;
    public GameObject GoButton;


    private Vector3 preScale_Start;
    private Vector3 preScale_Rank;

    public GameObject OptionPanel;
    private bool OptPanel;
    
    public static bool isCilckGoBut = false;

    void Start()
    {
        OptionPanel.SetActive(false);
        OptPanel = false;
        isCilckGoBut = false;
    }

    public void OnPointerEnter(PointerEventData eventData) //마우스포인터가 충돌범위안에 들어올때 이벤트
    {
        //데이터 저장 (커진 값)
        preScale_Start = StartButton.transform.localScale;
        preScale_Rank = RankButton.transform.localScale;

        //커짐
        StartButton.transform.localScale = new Vector3(preScale_Start.x + 0.1f, preScale_Start.y + 0.1f, preScale_Start.z + 0.1f);
        RankButton.transform.localScale = new Vector3(preScale_Rank.x + 0.1f, preScale_Rank.y + 0.1f, preScale_Rank.z + 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)//마우스포인터가 충돌범위밖으로 나갈때 이벤트
    {
        //작아짐
        StartButton.transform.localScale = preScale_Start;
        RankButton.transform.localScale = preScale_Rank;
    }

    public void _OptButton()
    {
        if(OptPanel==false)
        {
            OptionPanel.SetActive(true);
            OptPanel = true;
        }
    }

    public void _ReturnButton()
    {
        if (OptPanel == true)
        {
            OptionPanel.SetActive(false);
            OptPanel = false;
        }
    }
    
    public void GoStageMenu()
    {
        SceneManager.LoadScene("StageMenu");
    }

    public void GoRanking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void GoMain()
    {
        SceneManager.LoadScene("Main");
    }
    
    public void GoStage_a() // 1 스테이지
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage1");
    }

    public void GoStage_b() // 2 스테이지
    {
        if (Player.IsClear[0])
        { 
            Time.timeScale = 1; 
            SceneManager.LoadScene("Stage2"); 
        }
           
    }

    public void GoStage_c() // 3 스테이지
    {
        if (Player.IsClear[1])
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Stage3");
        }
    }

    public void ExitGame()
    {

    }

    public void GoMove()
    {
        if(!isCilckGoBut)
        {
            GoButton.GetComponentInChildren<Text>().text = "STOP";
            isCilckGoBut = true;
        }

        else
        {
            GoButton.GetComponentInChildren<Text>().text = "GO";
            isCilckGoBut = false;
        }        
    }
}

