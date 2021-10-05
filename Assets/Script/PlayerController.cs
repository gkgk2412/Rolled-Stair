using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public UnityEvent _ClearEventON;

    SpriteRenderer renderer;
    Animator animator;
    Rigidbody2D rigid;

    private bool isRight, isLeft, isJump;
    private bool HitStair;
    private float rightWallPos = 110;
    private float leftWallPos = -300;

    [Header("PLAYER STATUS")]
    [SerializeField] private float movespeed = 80.0f;
    [SerializeField] private float JumpPower = 30.0f;
    [SerializeField] private LayerMask m_viewTargetMask;
    [SerializeField] private float m_viewRadius = 1f; //원의 반지름(시야 거리)
    [SerializeField] private float m_viewRotateZ = 0f; //시야의 방향을 회전시키는데 사용


    [Header("SOUND")]
    public AudioSource audioSource;
    public AudioClip JumpaudioClip;
    public AudioClip ClearaudioClip;
    public AudioClip HitaudioClip;


    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
        renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Go버튼이 눌러졌으면
        if (ButtonControl.isCilckGoBut)
        {
            Vector2 originPos = transform.position; //내 위치 받아옴
            Vector3 lookDir = AngleToDirZ(m_viewRotateZ); //시야각 방향

            if (isRight)
            {
                m_viewRotateZ = -250f;
                transform.position += Vector3.right * movespeed * Time.deltaTime;
                renderer.flipX = false;
                animator.SetBool("IsRightRunning", true);
            }

            if (isLeft) //왼쪽 걷기
            {
                m_viewRotateZ = 250f;
                transform.position += Vector3.left * movespeed * Time.deltaTime;
                renderer.flipX = true;
                animator.SetBool("IsLeftRunning", true);
            }

            if (isJump) //점프
            {
                Player.score += 10;

                if (isRight)
                {
                    audioSource.PlayOneShot(JumpaudioClip);
                    isRight = false;
                    animator.SetTrigger("DoJumping");
                    animator.SetBool("IsJumping", true);
                    rigid.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
                    isJump = false;
                    isRight = true;
                }

                else
                {
                    audioSource.PlayOneShot(JumpaudioClip);
                    isLeft = false;
                    animator.SetTrigger("DoJumping");
                    animator.SetBool("IsJumping", true);
                    rigid.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
                    isJump = false;
                    isLeft = true;
                }
            }

            RaycastHit2D hit = Physics2D.Raycast(originPos, lookDir, m_viewRadius, m_viewTargetMask);

            if (hit.collider != null && !isJump && !HitStair) 
            {
                HitStair = true; //계단에 닿였음 체크
                isJump = true;
            }

            if (transform.position.x >= rightWallPos) //오른쪽 벽 넘으면
            {
                transform.position = new Vector2(rightWallPos, this.transform.position.y);
                isRight = false;
                isLeft = true;
            }

            if (transform.position.x <= leftWallPos) //왼쪽 벽 넘으면
            {
                transform.position = new Vector2(leftWallPos, this.transform.position.y);
                isRight = true;
                isLeft = false;
            }
        }

        //Stop버튼이 눌러졌으면
        else
        {
            if (transform.position.x >= rightWallPos) //오른쪽 벽 넘으면
            {
                transform.position = new Vector2(rightWallPos, this.transform.position.y);
            }

            if (transform.position.x <= leftWallPos) //왼쪽 벽 넘으면
            {
                transform.position = new Vector2(leftWallPos, this.transform.position.y);
            }

            isJump = false;
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
        }
    }


    //시야각 그려주는 함수
    private void OnDrawGizmos()
    {
        Vector2 originPos = transform.position; //내 위치 받아옴
        Vector3 lookDir = AngleToDirZ(m_viewRotateZ); //시야각 방향

        Gizmos.DrawWireSphere(originPos, m_viewRadius);
        Debug.DrawRay(originPos, lookDir * m_viewRadius, Color.red); //회전 ray 쏨
    }

    //입력한 Angle(-180~180)을 Up Vector 기준 Direction으로 변환해주는 함수
    private Vector3 AngleToDirZ(float angleInDegree)
    {
        float radian = (angleInDegree - transform.eulerAngles.z) * Mathf.Deg2Rad; //입력한 Angle을 Local Direction으로 변환시킴
        return new Vector3(Mathf.Sin(radian), Mathf.Cos(radian), 0f);
    }

    //layer 또는 tag로 닿였음을 확인하는 함수
    private void OnTriggerEnter2D(Collider2D other)
    {
        //점프 후 바닥에 닿였는지 확인
        if (other.gameObject.layer == 8 || other.gameObject.layer == 9 && rigid.velocity.y < 0)
        {
            animator.SetBool("IsJumping", false);
            HitStair = false;
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear")
        {
            audioSource.PlayOneShot(HitaudioClip);

            isRight = false;
            isLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
            audioSource.PlayOneShot(ClearaudioClip);

            Player.IsClear[0] = true;

            ClearPanelOn();
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear2")
        {
            audioSource.PlayOneShot(HitaudioClip);

            isRight = false;
            isLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
            audioSource.PlayOneShot(ClearaudioClip);

            Player.IsClear[1] = true;

            ClearPanelOn();
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear3")
        {
            audioSource.PlayOneShot(HitaudioClip);

            isRight = false;
            isLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
            audioSource.PlayOneShot(ClearaudioClip);

            Player.IsClear[2] = true;

            ClearPanelOn();
        }
    }

    public void ClearPanelOn()
    {
        _ClearEventON.Invoke();
    }
}
