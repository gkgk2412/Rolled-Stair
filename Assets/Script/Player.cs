using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//View
//https://a-game-developer0724.tistory.com/116
//https://uemonwe.tistory.com/23

public class Player : MonoBehaviour
{
    //Play
    private float time; //게임 시간
    public static float score = 0; //점수
    private string Name = null; //닉네임

    static public bool[] IsClear = new bool[3];


    [Header("TEXT & PANEL")]
    public Text timeText; //시간 보여주는 텍스트
    public Text socreText; //점수 보여주는 텍스트
    public Text IsScoreText; //판넬 안에서 점수 보여주는 텍스트
    public InputField newname; //닉네임 적는 필드
    public GameObject ClearPanel; //클리어 판넬


    void Start() 
    {
        ClearPanel.SetActive(false);

        score = 0;
    }

    void Update()
    {
        time += Time.deltaTime; //시간 증가
        timeText.text = "time : " + Mathf.Round(time); //현재 시간 보여줌
        socreText.text = "score : " + score; //현재 점수 보여줌


        for (int i = 0; i < 3; ++i)
        {
            if (IsClear[i]) //클리어 했으면
            {
                Name = newname.text;

                PlayerPrefs.SetString("name" + "10", newname.text); //이름과
                PlayerPrefs.SetFloat("10", score); //내 점수를 11등에 저장해놓는다

                if (Name.Length > 0 && Input.GetKeyDown(KeyCode.Return))
                {
                    InsertBank();
                    SceneManager.LoadScene("Ranking");
                }
            }

        }

    }


    void InsertBank()
    {
        for (int i = 0; i < 10; i++)//0부터 9까지, 총 10번 돌림 (1등을 제외한 나머지와(2등~11등)만 비교하면 되기 때문)
        {
            float tempIndex = i; //처음 값이 들어있는 인덱스를 저장한다

            for (int j = i + 1; j < 11; j++) //i = 0이면, 0제외 1부터 시작(i+1)
            {
                //만약 처음 값이 들어있는 인덱스보다 바로 아래에 있는 값이 크면 (1등 값 < 2등 값)
                if (PlayerPrefs.GetFloat(tempIndex.ToString()) < PlayerPrefs.GetFloat(j.ToString()))
                {
                    tempIndex = j;//그 인덱스를 저장한다
                }
            }
            //가장 큰 값과 처음 값을 스왑하는 부분
            float tempValue = PlayerPrefs.GetFloat(i.ToString()); //처음 값을 변수에 저장한다
            string tempChar = PlayerPrefs.GetString("name" + i.ToString()); //처음 닉네임을 변수에 저장한다

            PlayerPrefs.SetFloat(i.ToString(), PlayerPrefs.GetFloat(tempIndex.ToString())); //가장 큰 값을 가진 인덱스를 처음 값에 저장한다
            PlayerPrefs.SetString("name" + i.ToString(), PlayerPrefs.GetString("name" + tempIndex.ToString())); //가장 큰 값을 가진 인덱스의 닉네임을 처음 값에 저장한다

            PlayerPrefs.SetFloat(tempIndex.ToString(), tempValue); //처음 값이 가장 큰 값이 있던 인덱스에 저장된다
            PlayerPrefs.SetString("name" + tempIndex.ToString(), tempChar); //처음 값의 닉네임이 가장 큰 값이 있던 인덱스에 저장된다
        }
    }


    public void ClearFunc()
    {
        ClearPanel.SetActive(true);
        IsScoreText.text = " " + score; //현재 점수 보여줌
    }
}
