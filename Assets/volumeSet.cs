using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volumeSet : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeText = null;

    private void Start()
    {
        LoadValues();
    }
    public void VolumeSlider(float volume)
    {
        volumeText.text = volume.ToString("0");
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumeValue", volumeSlider.value);
        LoadValues();
    }
    void LoadValues()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeValue");
        AudioListener.volume= PlayerPrefs.GetFloat("volumeValue");
    }
}
