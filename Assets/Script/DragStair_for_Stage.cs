using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class DragStair_for_Stage : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler/*마우스를 놓으면 호출*/, IDropHandler/*이미지와 마우스가 닿아있을때 놓으면 호출*/
{
    [SerializeField]
    public List<Transform> CanvasStair;
    public List<Transform> TestStair;
    public List<Image> StairIma;

    //canvas 계단객체(clone) 관리하는 리스트
    List<Transform> StairList = new List<Transform>();

    //camera 계단객체(clone) 관리하는 리스트
    List<Transform> CanvStairList = new List<Transform>();

    public static bool isDragEnd = false;
    public static bool isDrop = false;
    //public static bool isGridTime = false;


    private bool onceFirst = false;

    bool NoChange = false;

    //계단좌표 변경
    private float MoveX = 76.417910f;
    private float MoveY = 76.03960f;

    //계단생성체크, 이미지 변경
    public static bool FirstStair = false;
    public static bool SecondStair = false;
    public static bool ThirdStair = false;
    public static bool ForthStair = false;
    public static bool FifthStair = false;
    public static bool SixthStair = false;

    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        Debug.Log("onceFirst  " + onceFirst);
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        NoChange = false;
        //isGridTime = true;

        for (int i = 0; i < 9; i++)
        {
            //이미지 1
            if (tag == "Image1")
            {
                if (StairControl_for_Stage.indexCheck[0] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform; //canvas position
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;//camera position

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                        //StairIma[0].enabled = false;
                        //StairIma[0].color = new Color(255, 255, 255, 0);
                        //StairIma[0].GetComponent<SpriteRenderer>().enabled = false;
                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos1.x, StairPosition.pos1.y, StairPosition.pos1.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos1.x / MoveX, StairPosition.pos1.y / MoveY, StairPosition.pos1.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[0].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }
                }
            }

            //이미지 2
            if (tag == "Image2")
            {
                if (StairControl_for_Stage.indexCheck[1] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos2.x, StairPosition.pos2.y, StairPosition.pos2.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos2.x / MoveX, StairPosition.pos2.y / MoveY, StairPosition.pos2.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[1].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }
                }
            }

            //이미지 3
            if (tag == "Image3")
            {
                if (StairControl_for_Stage.indexCheck[2] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos3.x, StairPosition.pos3.y, StairPosition.pos3.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos3.x / MoveX, StairPosition.pos3.y / MoveY, StairPosition.pos3.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[2].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }
                }
            }

            //이미지 4
            if (tag == "Image4")
            {
                if (StairControl_for_Stage.indexCheck[3] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos4.x, StairPosition.pos4.y, StairPosition.pos4.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos4.x / MoveX, StairPosition.pos4.y / MoveY, StairPosition.pos4.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[3].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }
                }
            }

            //이미지 5
            if (tag == "Image5")
            {
                if (StairControl_for_Stage.indexCheck[4] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos5.x, StairPosition.pos5.y, StairPosition.pos5.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos5.x / MoveX, StairPosition.pos5.y / MoveY, StairPosition.pos5.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[4].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }
                }
            }

            //이미지 6
            if (tag == "Image6")
            {
                if (StairControl_for_Stage.indexCheck[5] == i)
                {
                    if (i == 0)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[0], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[0], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 1)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[1], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[1], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 2)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[2], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[2], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 3)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[3], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[3], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 4)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[4], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[4], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 5)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[5], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[5], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 6)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[6], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[6], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

                    }

                    else if (i == 7)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[7], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[7], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }

                    else if (i == 8)
                    {
                        //드래그를 시작하면 계단을 하나 생성.
                        Transform _Stair = Instantiate(CanvasStair[8], new Vector3(StairPosition.pos6.x, StairPosition.pos6.y, StairPosition.pos6.z), Quaternion.identity) as Transform;
                        Transform _CanvasStair = Instantiate(TestStair[8], new Vector3(StairPosition.pos6.x / MoveX, StairPosition.pos6.y / MoveY, StairPosition.pos6.z), Quaternion.identity) as Transform;

                        StairList.Add(_Stair);
                        CanvStairList.Add(_CanvasStair);
                        StairIma[5].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    }
                }
            }
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("ONDrag");
        //Debug.Log("eventData.position = " + eventData.position);

        transform.position = eventData.position;

        StairList[StairList.Count - 1].position = eventData.position;
        CanvStairList[CanvStairList.Count - 1].position = eventData.position / MoveX;
    }

    public void OnDrop(PointerEventData eventData) //drop발생 하지않으면 잘못된 위치에 놓아진것 (ex. 화면밖 -> 그럴경우 이미지가 설치되면 x)
    {
        Debug.Log("Drop");

        //if (!CanvasStairManager.isFinishCol)
        //    isDrop = true; // Drop 실행 -> 이미지 생성    
    }

    public void OnEndDrag(PointerEventData eventData) //onEndDrag 발생시 이미지가 원위치로 복귀
    {
        Debug.Log("End Drag");

        CreateImage(); //이미지생성..      
        isDragEnd = true;
        //isGridTime = false;



        for (int i = 0; i < 6; i++)
        {
            StairIma[i].transform.localScale = new Vector3(1, 1, 1);
        }

        ////Xobject 삭제
        //GameObject[] objects = GameObject.FindGameObjectsWithTag("Xobject");
        //for (int i = 0; i < objects.Length; i++)
        //    Destroy(objects[i]);   
    }

    void CreateImage()
    {
        // 첫번째계단이 바닥에 놓여지지 않았으면 놓을수x
        if (CanvasStairManager.isFinishCol/*메뉴화면등 ui에 충돌하지않았는지 체크*/
            /*|| !EmptyObjManager.isFloorSet*//*첫번째계단이 바닥에 있는지 체크*/
            || !EmptyObjManager.isEmptyObj)
        {
            StairList[StairList.Count - 1].gameObject.tag = "CanvasStair";
            CanvStairList[CanvStairList.Count - 1].gameObject.tag = "CanvasStair";

            //알맞은 위치가 아니면 삭제
            GameObject[] objects = GameObject.FindGameObjectsWithTag("CanvasStair");
            for (int i = 0; i < objects.Length; i++)
                Destroy(objects[i]);

            NoChange = true;
        }

        if (!CanvasStairManager.isFinishCol && !NoChange || EmptyObjManager.isEmptyObj)
        {
            StairList[StairList.Count - 1].gameObject.tag = "Finish";

            //ColObject 태그를 찾아서, 제거
            GameObject[] objects = GameObject.FindGameObjectsWithTag("ExtraObject");
            for (int i = 0; i < objects.Length; i++)
                Destroy(objects[i]);

            for (int i = 0; i < 9; i++)
            {
                //이미지 1
                if (tag == "Image1")
                {
                    if (StairControl_for_Stage.indexCheck[0] == i)
                        FirstStair = true;
                }

                //이미지 2
                if (tag == "Image2")
                {
                    if (StairControl_for_Stage.indexCheck[1] == i)
                        SecondStair = true;
                }

                //이미지 3
                if (tag == "Image3")
                {
                    if (StairControl_for_Stage.indexCheck[2] == i)
                        ThirdStair = true;
                }

                //이미지 4
                if (tag == "Image4")
                {
                    if (StairControl_for_Stage.indexCheck[3] == i)
                        ForthStair = true;
                }

                //이미지 5
                if (tag == "Image5")
                {
                    if (StairControl_for_Stage.indexCheck[4] == i)
                        FifthStair = true;
                }

                //이미지 6
                if (tag == "Image6")
                {
                    if (StairControl_for_Stage.indexCheck[5] == i)
                        SixthStair = true;
                }
            }
        }
    }
}



//void OnCollisionStay2D(Collision2D other)
//{
//    if (other.gameObject.tag == "Finish" || other.gameObject.tag == "Image1" || other.gameObject.tag == "Image2" || other.gameObject.tag == "Image3" || other.gameObject.tag == "Image4"
//        || other.gameObject.tag == "Image5" || other.gameObject.tag == "Image6")
//    {
//        isInMenu = true; // Drop 실행 x
//    }
//}



//if (EmptyObjManager.isEmptyObj && EmptyObjManager.isFloorSet)
//{
//    StairList[StairList.Count - 2].transform.GetChild(0).gameObject.tag = "Xobject";
//    StairList[StairList.Count - 2].transform.GetChild(1).gameObject.tag = "Xobject";
//    StairList[StairList.Count - 2].transform.GetChild(2).gameObject.tag = "Xobject";
//    StairList[StairList.Count - 2].transform.GetChild(3).gameObject.tag = "Xobject";
//}


//        if (!CanvasStairManager.isFinishCol) //첫번째 계단이 놓이고 난후, ui에도 충돌하지않음
//        {
//            if (!EmptyObjManager.isEmptyObj/*extraobject가 colObject에 닿았는지 체크 false = 닿지않음*/)
//            {
//                StairList[StairList.Count - 1].gameObject.tag = "CanvasStair";
//                CanvStairList[CanvStairList.Count - 1].gameObject.tag = "CanvasStair";

//                //알맞은 위치가 아니면 삭제
//                GameObject[] object_ = GameObject.FindGameObjectsWithTag("CanvasStair");
//                for (int i = 0; i<object_.Length; i++)
//                    Destroy(object_[i]);

//NoChange = true;
//            }
//        }
