using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //스크롤바 이슈, 핸들의 value값이 0.5고정되어있어서 패널값 변경해서 고쳐줌.
        transform.Translate(new Vector3(0, -183.43f, 0));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
