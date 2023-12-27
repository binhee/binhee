using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider MasteraudioSlider;
    public Slider BGMaudioSlider;
    public Slider EffectaudioSlider;

    // 오디오의 볼륨을 조절하는 함수
    public void MasterAudioControl()
    {
        float sound = MasteraudioSlider.value;

        // 만약 볼륨이 최소값인 -40f라면 -80으로 설정, 그렇지 않으면 입력된 볼륨 값으로 설정
        if (sound == -40f)
        {
            masterMixer.SetFloat("Master", -80);
        }
        else
        {
            masterMixer.SetFloat("Master", sound);
        }
    }

    public void BGMAudioControl()
    {
        float sound = BGMaudioSlider.value;

        if (sound == -40f)
        {
            masterMixer.SetFloat("BGM", -80);
        }
        else
        {
            masterMixer.SetFloat("BGM", sound);
        }
    }

    public void EffectAudioControl()
    {
        float sound = EffectaudioSlider.value;

        if (sound == -40f)
        {
            masterMixer.SetFloat("Effect", -80);
        }
        else
        {
            masterMixer.SetFloat("Effect", sound);
        }
    }

    // 오디오 볼륨을 토글하는 함수
    public void ToggleAudioVolume()
    {
        // 현재 오디오 리스너의 볼륨이 0이면 1로, 0이 아니면 0으로 토글
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}