using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * image 사이의 x간격을 조절
 */

public class SortingIma : MonoBehaviour
{
    [SerializeField]
    private GameObject[] stairImage = new GameObject[5];

    private float betweenlength;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stairImage.Length; ++i)
        {
            if (stairImage[i + 1].transform.position.x != stairImage[i].transform.position.x + betweenlength)
            {
                if (stairImage[i + 1].GetComponent<StairManager>().stairNum == 0)
                {
                    betweenlength = 70;
                }

                else if (stairImage[i + 1].GetComponent<StairManager>().stairNum == 1 
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 3
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 4)
                {
                    betweenlength = 120;
                }

                else if (stairImage[i + 1].GetComponent<StairManager>().stairNum == 2
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 5
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 6
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 7 
                    || stairImage[i + 1].GetComponent<StairManager>().stairNum == 8)
                {
                    betweenlength = 150;
                }

                if(stairImage[i].GetComponent<StairManager>().stairNum == 1
                    || stairImage[i].GetComponent<StairManager>().stairNum == 3
                    || stairImage[i].GetComponent<StairManager>().stairNum == 4)
                {
                    betweenlength += 20;
                }

                if (stairImage[i].GetComponent<StairManager>().stairNum == 2
                    || stairImage[i].GetComponent<StairManager>().stairNum == 5
                    || stairImage[i].GetComponent<StairManager>().stairNum == 6
                    || stairImage[i].GetComponent<StairManager>().stairNum == 7
                    || stairImage[i].GetComponent<StairManager>().stairNum == 8)
                {
                    betweenlength += 30;
                }

                stairImage[i + 1].transform.position = new Vector3(stairImage[i].transform.position.x + betweenlength, stairImage[i + 1].transform.position.y, stairImage[i + 1].transform.position.z);
            }
        }
    }
}

/*
 
                

                
               
 */
