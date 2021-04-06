using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairPosition : MonoBehaviour
{
    //계단의 갯수
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;

    //실시간 위치를 저장할 벡터
    public static Vector3 pos1;
    public static Vector3 pos2;
    public static Vector3 pos3;
    public static Vector3 pos4;
    public static Vector3 pos5;
    public static Vector3 pos6;

    //초기 위치를 저장할 벡터
    public static Vector3 InPos1;
    public static Vector3 InPos2;
    public static Vector3 InPos3;
    public static Vector3 InPos4;
    public static Vector3 InPos5;
    public static Vector3 InPos6;

// Start is called before the first frame update
void Start()
    {
        InPos1 = Image1.gameObject.transform.position;
        InPos2 = Image2.gameObject.transform.position;
        InPos3 = Image3.gameObject.transform.position;
        InPos4 = Image4.gameObject.transform.position;
        InPos5 = Image5.gameObject.transform.position;
        InPos6 = Image6.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos1 = Image1.gameObject.transform.position; //이미지의 실시간 위치
        pos2 = Image2.gameObject.transform.position; //이미지의 실시간 위치
        pos3 = Image3.gameObject.transform.position; //이미지의 실시간 위치
        pos4 = Image4.gameObject.transform.position; //이미지의 실시간 위치
        pos5 = Image5.gameObject.transform.position; //이미지의 실시간 위치
        pos6 = Image6.gameObject.transform.position; //이미지의 실시간 위치

        if(DragStair.isDragEnd)
        {
            //원래위치로 복귀
            Image1.transform.position = new Vector3(83.1f, 690.3f, 0);
            Image2.transform.position = new Vector3(83.1f, 559.5f, 0);
            Image3.transform.position = new Vector3(83.1f, 425.4f, 0);
            Image4.transform.position = new Vector3(83.1f, 291.4f, 0);
            Image5.transform.position = new Vector3(83.1f, 157.4f, 0);
            Image6.transform.position = new Vector3(83.1f, 23.3f, 0);


            DragStair.isDragEnd = false;
        }

        if (DragStair_for_Stage.isDragEnd)
        {
            //원래위치로 복귀
            Image1.transform.position = new Vector3(83.1f, 690.3f, 0);
            Image2.transform.position = new Vector3(83.1f, 559.5f, 0);
            Image3.transform.position = new Vector3(83.1f, 425.4f, 0);
            Image4.transform.position = new Vector3(83.1f, 291.4f, 0);
            Image5.transform.position = new Vector3(83.1f, 157.4f, 0);
            Image6.transform.position = new Vector3(83.1f, 23.3f, 0);


            DragStair_for_Stage.isDragEnd = false;
        }
    }
}
