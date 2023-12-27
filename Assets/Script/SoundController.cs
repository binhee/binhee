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

    // ������� ������ �����ϴ� �Լ�
    public void MasterAudioControl()
    {
        float sound = MasteraudioSlider.value;

        // ���� ������ �ּҰ��� -40f��� -80���� ����, �׷��� ������ �Էµ� ���� ������ ����
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

    // ����� ������ ����ϴ� �Լ�
    public void ToggleAudioVolume()
    {
        // ���� ����� �������� ������ 0�̸� 1��, 0�� �ƴϸ� 0���� ���
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}