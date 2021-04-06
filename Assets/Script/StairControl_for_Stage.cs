using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StairControl_for_Stage: MonoBehaviour
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
        //자식오브젝트의 태그에 따라서 index 변화있게 만들고, 각 스테이지내에서 자식오브젝트 태그만 바꾸면 
        // 이미지가 바뀌게 만듦.

        //1번째 이미지
        if(StairImage[0].transform.GetChild(0).tag == "0") //1번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[0] = 0;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "1") //1번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[0] = 1;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "2") //1번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[0] = 2;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "3") //1번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[0] = 3;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "4") //1번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[0] = 4;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "5") //1번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[0] = 5;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "6") //1번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[0] = 6;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "7") //1번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[0] = 7;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }
        if (StairImage[0].transform.GetChild(0).tag == "8") //1번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[0] = 8;
            StairImage[0].sprite = RandStairImage[indexCheck[0]];
        }

        //2번째 이미지
        if (StairImage[1].transform.GetChild(0).tag == "0") //2번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[1] = 0;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "1") //2번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[1] = 1;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "2") //2번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[1] = 2;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "3") //2번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[1] = 3;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "4") //2번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[1] = 4;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "5") //2번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[1] = 5;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "6") //2번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[1] = 6;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "7") //2번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[1] = 7;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[1].transform.GetChild(0).tag == "8") //2번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[1] = 8;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }

        //3번째 이미지
        if (StairImage[2].transform.GetChild(0).tag == "0") //3번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[2] = 0;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "1") //3번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[2] = 1;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "2") //3번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[2] = 2;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "3") //3번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[2] = 3;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "4") //3번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[2] = 4;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "5") //3번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[2] = 5;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "6") //3번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[2] = 6;
            StairImage[2].sprite = RandStairImage[indexCheck[2]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "7") //3번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[2] = 7;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }
        if (StairImage[2].transform.GetChild(0).tag == "8") //3번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[2] = 8;
            StairImage[1].sprite = RandStairImage[indexCheck[1]];
        }

        //4번째 이미지
        if (StairImage[3].transform.GetChild(0).tag == "0") //4번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[3] = 0;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "1") //4번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[3] = 1;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "2") //4번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[3] = 2;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "3") //4번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[3] = 3;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "4") //4번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[3] = 4;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "5") //4번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[3] = 5;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "6") //4번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[3] = 6;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "7") //4번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[3] = 7;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }
        if (StairImage[3].transform.GetChild(0).tag == "8") //4번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[3] = 8;
            StairImage[3].sprite = RandStairImage[indexCheck[3]];
        }

        //5번째 이미지
        if (StairImage[4].transform.GetChild(0).tag == "0") //5번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[4] = 0;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "1") //5번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[4] = 1;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "2") //5번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[4] = 2;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "3") //5번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[4] = 3;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "4") //5번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[4] = 4;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "5") //5번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[4] = 5;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "6") //5번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[4] = 6;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "7") //5번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[4] = 7;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }
        if (StairImage[4].transform.GetChild(0).tag == "8") //5번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[4] = 8;
            StairImage[4].sprite = RandStairImage[indexCheck[4]];
        }

        //6번째 이미지
        if (StairImage[5].transform.GetChild(0).tag == "0") //6번째 이미지의 자식오브젝트 태그 0 일때
        {
            indexCheck[5] = 0;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "1") //6번째 이미지의 자식오브젝트 태그 1 일때
        {
            indexCheck[5] = 1;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "2") //6번째 이미지의 자식오브젝트 태그 2 일때
        {
            indexCheck[5] = 2;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "3") //6번째 이미지의 자식오브젝트 태그 3 일때
        {
            indexCheck[5] = 3;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "4") //6번째 이미지의 자식오브젝트 태그 4 일때
        {
            indexCheck[5] = 4;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "5") //6번째 이미지의 자식오브젝트 태그 5 일때
        {
            indexCheck[5] = 5;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "6") //6번째 이미지의 자식오브젝트 태그 6 일때
        {
            indexCheck[5] = 6;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "7") //6번째 이미지의 자식오브젝트 태그 7 일때
        {
            indexCheck[5] = 7;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
        if (StairImage[5].transform.GetChild(0).tag == "8") //6번째 이미지의 자식오브젝트 태그 8 일때
        {
            indexCheck[5] = 8;
            StairImage[5].sprite = RandStairImage[indexCheck[5]];
        }
    }
    

    public void AfterRandStair()
    {
        RandStair(); 

        if (DragStair_for_Stage.FirstStair)
        {
            StairImage[0].sprite = RandStairImage[indexCheck[0]];           

            DragStair_for_Stage.FirstStair = false;

        }

        if (DragStair_for_Stage.SecondStair)
        {
            StairImage[1].sprite = RandStairImage[indexCheck[1]];            

            DragStair_for_Stage.SecondStair = false;
        }

        if (DragStair_for_Stage.ThirdStair)
        {           
            StairImage[2].sprite = RandStairImage[indexCheck[2]];          

            DragStair_for_Stage.ThirdStair = false;
        }

        if (DragStair_for_Stage.ForthStair)
        {            
            StairImage[3].sprite = RandStairImage[indexCheck[3]];                       

            DragStair_for_Stage.ForthStair = false;
        }

        if (DragStair_for_Stage.FifthStair)
        {            
            StairImage[4].sprite = RandStairImage[indexCheck[4]];           

            DragStair_for_Stage.FifthStair = false;
        }

        if (DragStair_for_Stage.SixthStair)
        {           
            StairImage[5].sprite = RandStairImage[indexCheck[5]];         

            DragStair_for_Stage.SixthStair = false;
        }
    }
}
