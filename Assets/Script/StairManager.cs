using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * 이 스크립트를 Image 객체에 넣고 번호를 매겨주면 각 번호에 해당되는 계단이미지로 바뀐다.
 * zero base
 * 1번과 2번의 경우 image 객체 자체의 크기도 바꿔준다.
 */

public class StairManager : MonoBehaviour
{
    public int stairNum;
    Image stairIma;

    private static StairManager instance;
    public static StairManager Instance => instance;

    public StairManager()
    {
        //자기 자신에 대한 정보를 static 형태의 instacne 변수에 저장하여 외부에서 접근이 쉽도록 함
        instance = this;
    }


    private void Start()
    {
        stairIma = this.GetComponent<Image>();

        switch (stairNum)
        {
            case 0:
                {
                    ChangeIma(0);
                    transform.localScale = new Vector3(transform.localScale.x / 2.0f, transform.localScale.y / 2.0f, transform.localScale.z);
                    break;
                }
               
            case 1:
                {
                    ChangeIma(1);
                    transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y / 2.0f, transform.localScale.z);
                    break;
                }

            case 2:
                {
                    ChangeIma(2);
                    transform.localScale = new Vector3(transform.localScale.x * 1.6f, transform.localScale.y / 2.0f, transform.localScale.z);
                    break;
                }

            case 3:
                {
                    ChangeIma(3);
                    transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y, transform.localScale.z);
                    break;
                }

            case 4:
                {
                    ChangeIma(4);
                    transform.localScale = new Vector3(transform.localScale.x * 1.3f, transform.localScale.y, transform.localScale.z);
                    break;
                }


            case 5:
                {
                    ChangeIma(5);
                    transform.localScale = new Vector3(transform.localScale.x * 1.6f, transform.localScale.y, transform.localScale.z);
                    break;
                }

            case 6:
                {
                    ChangeIma(6);
                    transform.localScale = new Vector3(transform.localScale.x * 1.6f, transform.localScale.y, transform.localScale.z);
                    break;
                }

            case 7:
                {
                    ChangeIma(7);
                    transform.localScale = new Vector3(transform.localScale.x * 1.6f, transform.localScale.y * 1.3f, transform.localScale.z);
                    break;
                }

            case 8:
                {
                    ChangeIma(8);
                    transform.localScale = new Vector3(transform.localScale.x * 1.6f, transform.localScale.y * 1.3f, transform.localScale.z);
                    break;
                }
        }
    }

    void ChangeIma(int stairNum)
    {
        stairIma.sprite = SpriteStair.Instance.stairSprite[stairNum];
    }

}
