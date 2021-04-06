using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public Text Rank; //순위, 이름 뜰 텍스트
    public Text ScoreRank; //점수 뜰 텍스트

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            //순위와 이름 text
            Rank.text += (i + 1).ToString() + "\t\t\t\t\t\t\t\t" + PlayerPrefs.GetString("name" + i.ToString()) + "\n\n";
            //점수 text
            ScoreRank.text += PlayerPrefs.GetFloat(i.ToString()) + "\n\n";
        }
    }

    //C 누르면 초기화 -> 테스트 용, 후 삭제 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteAll(); //초기화
        }
    }
}
