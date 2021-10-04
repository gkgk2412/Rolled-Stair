using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/*
 * 현 스크립트가 들어있는 객체를 클릭 시 똑같은 이미지의 객체 생성
 * 생성된 객체를 알맞은 구역에서 드랍 시 위치 고정
 * 알맞지 않은 구역에서 드랍 시 캔슬
 */
public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler/*마우스를 놓으면 호출*/, IDropHandler/*이미지와 마우스가 닿아있을때 놓으면 호출*/
{
    private GameObject newStair = null;
    public GameObject[] stairPrefabs = new GameObject[9];

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        Debug.Log(this.GetComponent<StairManager>().stairNum);

        for(int i = 0; i < 9; ++i)
        {
            //stairNum에 따라서 알맞은 이미지를 생성
            if (this.GetComponent<StairManager>().stairNum == i)
            {
                //드래그를 시작하면 계단을 하나 생성.
                newStair = Instantiate(stairPrefabs[i], Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1)), Quaternion.identity) as GameObject;
                newStair.transform.parent = GameObject.Find("StairCanvas").transform;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        newStair.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
    }


    public void OnDrop(PointerEventData eventData) //drop발생 하지않으면 잘못된 위치에 놓아진것 (ex. 화면밖 -> 그럴경우 이미지가 설치되면 x)
    {
        Debug.Log("Drop");
    }

    public void OnEndDrag(PointerEventData eventData) //onEndDrag 발생시 이미지가 원위치로 복귀
    {
        Debug.Log("End Drag");

        if (CheckCollectCol.isCollect)
        {
            Destroy(newStair);
        }        
    }
}
