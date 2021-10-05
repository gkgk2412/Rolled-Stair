using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteButton : MonoBehaviour
{
    public GameObject deleteMessage;
    private bool isD_butClick = false;

    public void Start()
    {
        deleteMessage.SetActive(false);
    }

    public void DeleteBut()
    {
        //delete 버튼을 누를 경우, text를 띄움
        if (!isD_butClick)
        {
            deleteMessage.SetActive(true);
            isD_butClick = true;
        }
        else
        {
            deleteMessage.SetActive(false);
            isD_butClick = false;
        }
    }

    public void Update()
    {
        //delete 버튼을 눌렀다면
        if(isD_butClick)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                //마우스 포인터 클릭한 자리에 ray를 쏘아서 오브젝트 검출
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hitInformation = Physics2D.Raycast(touchPos, Camera.main.transform.forward);

                if (hitInformation.collider != null)
                {
                    GameObject touchedObject = hitInformation.transform.gameObject;

                    //검출된 obj가 계단일 경우 삭제
                    if (touchedObject.tag == "ColObject" && touchedObject.name != "StairCol")
                    {
                        Destroy(touchedObject.transform.parent.gameObject);
                    }

                    //검출된 obj가 계단일 경우 삭제
                    if (touchedObject.tag == "Stair")
                    {
                        Destroy(touchedObject);
                    }
                }

            }    
        }
    }
}