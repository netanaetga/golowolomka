using UnityEngine;
using UnityEngine.UI;
using YG;

public class securuty_button : MonoBehaviour
{
    public GameObject text;
    public GameObject zamok;


    private Button button;
    public int Level;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        if (YandexGame.savesData.CompletedLevels < Level)
        {
            Lock();
        }
    }

    public void Lock()
    {
        text.SetActive(false);
        zamok.SetActive(true);
        button.interactable = false;
    }
}
