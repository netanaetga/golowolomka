using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeChanger : MonoBehaviour
{
    public TMP_Text text;

    private void Start()
    {
        text.text = "звук " + (AudioChanger.Instance.vkl ? "+" : "-");
    }
    public void Click()
    {
        AudioChanger.Instance.Volume();
        text.text = "звук " + (AudioChanger.Instance.vkl ? "+" : "-");
    }
}
