using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{ 
    //Play
    float time; //게임 시간
    float score; //점수

    public Text timeText; //시간 보여주는 텍스트
    public Text socreText; //점수 보여주는 텍스트
    public Text IsScoreText; //판넬 안에서 점수 보여주는 텍스트

    private string Name = null; //닉네임
    public InputField newname; //닉네임 적는 필드

    public GameObject ClearPanel; //클리어 판넬

    static public bool[] IsClear = new bool[3]; 
    
    //Move
    public float movespeed = 1.5f;
    public bool IsJump = false;
    public float JumpPower;
    public static bool IsRight;
    bool IsLeft;

    //Animation
    Rigidbody2D rigid;
    Animator animator;
    SpriteRenderer renderer;

    //View
    //https://a-game-developer0724.tistory.com/116
    //https://uemonwe.tistory.com/23

    [SerializeField] private bool m_bDebugMode = false;

    [SerializeField] private LayerMask m_viewTargetMask; //타겟(계단 레이어마스크)의 레이어만 검출시킴

    [SerializeField] private float m_viewRadius = 1f; //원의 반지름(시야 거리)
    [Range(-180f, 180f)] //-180~+180으로 값을 제한
    [SerializeField] private float m_viewRotateZ = 0f; //시야의 방향을 회전시키는데 사용

    Vector2 TargetPosition;

    bool HitStair = false;

    //Sound
    public AudioSource audioSource;
    public AudioClip JumpaudioClip;
    public AudioClip ClearaudioClip;
    public AudioClip HitaudioClip;

    void Start() 
    {
        ClearPanel.SetActive(false);

        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        time += Time.deltaTime; //시간 증가
        score = transform.position.y; //플레이어의 y 위치가 점수가 됨
        timeText.text = "time : " + Mathf.Round(time); //현재 시간 보여줌
        socreText.text = "score : " + score; //현재 점수 보여줌

        if (IsRight) //오른쪽 걷기
        {
            m_viewRotateZ = -250f;
            transform.position += Vector3.right * movespeed * Time.deltaTime;
            renderer.flipX = false;
            animator.SetBool("IsRightRunning", true);
        }

        if(IsLeft) //왼쪽 걷기
        {
            m_viewRotateZ = 250f;
            transform.position += Vector3.left * movespeed * Time.deltaTime;
            renderer.flipX = true;
            animator.SetBool("IsLeftRunning", true);
        }

        if (IsJump) //점프
        {
            if (IsRight)
            {
                audioSource.PlayOneShot(JumpaudioClip);
                IsRight = false;
                animator.SetTrigger("DoJumping");
                animator.SetBool("IsJumping", true);
                rigid.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
                IsJump = false;
                IsRight = true;
            }
            else if (IsLeft)
            {
                audioSource.PlayOneShot(JumpaudioClip);
                IsLeft = false;
                animator.SetTrigger("DoJumping");
                animator.SetBool("IsJumping", true);
                rigid.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
                IsJump = false;
                IsLeft = true;
            }
        }

        if (transform.position.x >= 12.8) //오른쪽 벽 넘으면
        {
            IsRight = false;
            IsLeft = true;
        }

        if (transform.position.x <= 3) //왼쪽 벽 넘으면
        {
            IsRight = true;
            IsLeft = false;
        }

        Vector2 originPos = transform.position; //내 위치 받아옴

        Vector3 lookDir = AngleToDirZ(m_viewRotateZ); //시야각 방향

        //Stair Layer에 닿이면
        if (Physics.Raycast(originPos, lookDir * m_viewRadius, out RaycastHit hit, Mathf.Infinity, m_viewTargetMask)
            && !HitStair && !IsJump)
        {
            Debug.Log("계단에 닿였습니다.");
            //계단의 위치를 저장
            TargetPosition = hit.transform.position;
            IsJump = true; //점프 시키고
            HitStair = true; //계단에 닿였음 체크
        }

        for (int i = 0; i < 3; ++i)
        {
            if (IsClear[i]) //클리어 했으면
            {
                Name = newname.text;

                PlayerPrefs.SetString("name" + "10", newname.text); //이름과
                PlayerPrefs.SetFloat("10", score); //내 점수를 11등에 저장해놓는다

                if (Name.Length > 0 && Input.GetKeyDown(KeyCode.Return))
                {
                    InsertBank();
                    SceneManager.LoadScene("Ranking");
                }
            }

        }

    }

    //입력한 Angle(-180~180)을 Up Vector 기준 Direction으로 변환해주는 함수
    private Vector3 AngleToDirZ(float angleInDegree)
    {
        float radian = (angleInDegree - transform.eulerAngles.z) * Mathf.Deg2Rad; //입력한 Angle을 Local Direction으로 변환시킴
        return new Vector3(Mathf.Sin(radian), Mathf.Cos(radian), 0f);
    }

    //시야각 그려주는 함수
    private void OnDrawGizmos()
    {
        if (m_bDebugMode) //디버그 모드를 체크하면 시야각 보이게 함
        {
            Vector2 originPos = transform.position; //내 위치 받아옴

            Vector3 lookDir = AngleToDirZ(m_viewRotateZ); //시야각 방향

            Gizmos.DrawWireSphere(originPos, m_viewRadius);
            Debug.DrawRay(originPos, lookDir * m_viewRadius, Color.red); //회전 ray 쏨
        }
    }

    //layer 또는 tag로 닿였음을 확인하는 함수
    private void OnTriggerEnter2D(Collider2D other)
    {
        //점프 후 바닥에 닿였는지 확인
        if (other.gameObject.layer == 10 && rigid.velocity.y < 0)
        {
            animator.SetBool("IsJumping", false);
            HitStair = false;
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear")
        {
            audioSource.PlayOneShot(HitaudioClip);

            IsRight = false;
            IsLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
            IsClear[0] = true;
            audioSource.PlayOneShot(ClearaudioClip);

            ClearPanel.SetActive(true);
            IsScoreText.text = " " + score; //현재 점수 보여줌

            
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear2")
        {
            audioSource.PlayOneShot(HitaudioClip);

            IsRight = false;
            IsLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);
            IsClear[1] = true;
            audioSource.PlayOneShot(ClearaudioClip);

            ClearPanel.SetActive(true);
            IsScoreText.text = " " + score; //현재 점수 보여줌

           
        }

        //상자에 닿였으면
        if (other.gameObject.tag == "clear3")
        {
            audioSource.PlayOneShot(HitaudioClip);

            IsRight = false;
            IsLeft = false;
            animator.SetBool("IsRightRunning", false);
            animator.SetBool("IsLeftRunning", false);

            IsClear[2] = true;
            audioSource.PlayOneShot(ClearaudioClip);

            ClearPanel.SetActive(true);
            IsScoreText.text = " " + score; //현재 점수 보여줌

        }
    }

    //순위 제작
    void InsertBank()
    {
        for (int i = 0; i < 10; i++)//0부터 9까지, 총 10번 돌림 (1등을 제외한 나머지와(2등~11등)만 비교하면 되기 때문)
        {
            float tempIndex = i; //처음 값이 들어있는 인덱스를 저장한다

            for (int j = i + 1; j < 11; j++) //i = 0이면, 0제외 1부터 시작(i+1)
            {
                //만약 처음 값이 들어있는 인덱스보다 바로 아래에 있는 값이 크면 (1등 값 < 2등 값)
                if (PlayerPrefs.GetFloat(tempIndex.ToString()) < PlayerPrefs.GetFloat(j.ToString()))
                {
                    tempIndex = j;//그 인덱스를 저장한다
                }
            }
            //가장 큰 값과 처음 값을 스왑하는 부분
            float tempValue = PlayerPrefs.GetFloat(i.ToString()); //처음 값을 변수에 저장한다
            string tempChar = PlayerPrefs.GetString("name" + i.ToString()); //처음 닉네임을 변수에 저장한다

            PlayerPrefs.SetFloat(i.ToString(), PlayerPrefs.GetFloat(tempIndex.ToString())); //가장 큰 값을 가진 인덱스를 처음 값에 저장한다
            PlayerPrefs.SetString("name" + i.ToString(), PlayerPrefs.GetString("name" + tempIndex.ToString())); //가장 큰 값을 가진 인덱스의 닉네임을 처음 값에 저장한다

            PlayerPrefs.SetFloat(tempIndex.ToString(), tempValue); //처음 값이 가장 큰 값이 있던 인덱스에 저장된다
            PlayerPrefs.SetString("name" + tempIndex.ToString(), tempChar); //처음 값의 닉네임이 가장 큰 값이 있던 인덱스에 저장된다
        }
    }
}
