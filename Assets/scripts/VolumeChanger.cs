using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeChanger : MonoBehaviour
{
    public TMP_Text text;

    private void Start()
    {
        text.text = "���� " + (AudioChanger.Instance.vkl ? "+" : "-");
    }
    public void Click()
    {
        AudioChanger.Instance.Volume();
        text.text = "���� " + (AudioChanger.Instance.vkl ? "+" : "-");
    }
}
