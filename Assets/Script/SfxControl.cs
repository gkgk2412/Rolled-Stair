using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SfxControl : MonoBehaviour
{
    public Slider SfxVolume;

    public AudioSource HoverSource;
    public AudioSource SubBtnSource;
    public AudioSource MainBtnSource;
    public AudioSource MainHover;

    private float SfxVol=1f;

    private void Start()
    {
        SfxVol = PlayerPrefs.GetFloat("SfxVol",1f);
        SfxVolume.value = SfxVol;
        HoverSource.volume = SfxVolume.value;
        SubBtnSource.volume = SfxVolume.value;
        MainBtnSource.volume = SfxVolume.value;
        MainHover.volume = SfxVolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        SetButtonVolume();
    }

    //ui클릭 음량조절
    public void SetButtonVolume()
    {
        MainBtnSource.volume = SfxVolume.value;
        MainHover.volume = SfxVolume.value;
        SubBtnSource.volume = SfxVolume.value;
        HoverSource.volume = SfxVolume.value;
        SfxVol = SfxVolume.value;
        PlayerPrefs.SetFloat("SfxVol", SfxVol);
    }

    //StartBtn,RankBtn 클릭 이벤트
    public void OnMainSfx()
    {
        MainBtnSource.Play();
    }
    public void OnMainHover()
    {
        MainHover.Play();
    }


    //환경설정,뒤로가기 클릭 이벤트
    public void OnSubSfx()
    {
        SubBtnSource.Play();
    }
    public void OnHoverfx()
    {
        HoverSource.Play();
    }
}
