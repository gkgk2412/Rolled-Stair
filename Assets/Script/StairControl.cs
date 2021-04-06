using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StairControl : MonoBehaviour
{
    public List<Image> StairImage; //스크롤패널에 있는 이미지 위치
    public List<Sprite> RandStairImage; //스크롤패널에 있는 이미지에 계단 이미지 부여
    [SerializeField] //직렬화

    public static int index;
    public static int[] indexCheck = new int[8];
    public static int test = 0;



    // Start is called before the first frame update
    void Start()
    {
        RandStair();
    }

    void Update()
    {
        AfterRandStair();
    }

    //계단이미지 랜덤 배치
    public void RandStair()
    {      
        foreach (Image rand in StairImage)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            rand.sprite = RandStairImage[index];//0~5번 이미지 중에 랜덤으로 화면상에 표시될 UI 이미지를 바꿔줌

            indexCheck[test] = index;

            test++;
        }
    }

    public void AfterRandStair()
    {      
        if (DragStair.FirstStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[0].sprite = RandStairImage[index];

            indexCheck[0] = index;
   
            DragStair.FirstStair = false;

        }

        if (DragStair.SecondStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[1].sprite = RandStairImage[index];

            indexCheck[1] = index;

            DragStair.SecondStair = false;
        }

        if (DragStair.ThirdStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[2].sprite = RandStairImage[index];

            indexCheck[2] = index;

            DragStair.ThirdStair = false;
        }

        if (DragStair.ForthStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[3].sprite = RandStairImage[index];

            indexCheck[3] = index;

            DragStair.ForthStair = false;
        }

        if (DragStair.FifthStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[4].sprite = RandStairImage[index];

            indexCheck[4] = index;

            DragStair.FifthStair = false;
        }

        if (DragStair.SixthStair)
        {
            index = Random.Range(0, 9);//0~8까지 랜덤으로 숫자 생성
            StairImage[5].sprite = RandStairImage[index];

            indexCheck[5] = index;

            DragStair.SixthStair = false;
        }
    }
}
