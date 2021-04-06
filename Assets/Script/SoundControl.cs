using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    public Slider BackVolume;

    public AudioSource MusicSource;
   
    private float SoundVol = 1f;

    private void Start()
    {
        SoundVol = PlayerPrefs.GetFloat("SoundVol", 1f);
        BackVolume.value = SoundVol;        
        MusicSource.volume = BackVolume.value;
    }

    void Update()
    {
        BackGroundMusicSlider();
    }

    public void BackGroundMusicSlider()
    {
        MusicSource.volume = BackVolume.value;
        SoundVol = BackVolume.value;
        PlayerPrefs.SetFloat("SoundVol", SoundVol);
    }
}
