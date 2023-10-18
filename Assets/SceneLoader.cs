using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class SceneLoader : MonoBehaviour
{
    // ������������� �� ������� GetDataEvent � OnEnable
    private void OnEnable() => YandexGame.GetDataEvent += GetData;

    // ������������ �� ������� GetDataEvent � OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetData;

    private void Awake()
    {
        // ��������� ���������� �� ������
        if (YandexGame.SDKEnabled == true)
        {
            // ���� ����������, �� ��������� ��� �����
            GetData();

            // ���� ������ ��� �� �����������, �� ����� �� ����������� � ������ Start,
            // �� �� ���������� ��� ������ ������� GetDataEvent, ����� ��������� �������
        }
    }

    // ��� �����, ������� ����� ����������� � ������
    public void GetData()
    {
        SceneManager.LoadScene("menu");
        YandexGame.GameReadyAPI();
    }
}

