using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class volumeSet : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private TMP_Text volumeText = null;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.onValueChanged.AddListener(delegate { LoadValues(); });
    }
    public void VolumeSlider(float volume)
    {
        volumeText.text = volume.ToString("0");
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumeValue", volumeSlider.value);
    }
    void LoadValues()
    {
        SaveVolume();
        AudioListener.volume= PlayerPrefs.GetFloat("volumeValue")/100;
    }
}
