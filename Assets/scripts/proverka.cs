using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class proverka : MonoBehaviour
{
    private bool palbel = false;
    public bool cinact = false;
    private bool palpink = false;
    private bool palcin = false;
    private bool palyell = false;
    public bool yellAct = false;

    private int NomerScene;

    private bool isWin = false;

    private void Start()
    {
        NomerScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {

        if (NomerScene < 5)
        {
            Scene1_4Update();
        }
        else if (NomerScene == 5)
        {
            Scene5Update();
        }
        
    }

    void Scene1_4Update()
    {
        if (palbel == true && palpink == true && palcin == true)
        {

            int UnlockLevelPlayer = YandexGame.savesData.CompletedLevels;
            string levelName = SceneManager.GetActiveScene().name;
            int LevelScene;
            Int32.TryParse(levelName.Substring(levelName.Length - 1), out LevelScene);
            isWin = true;

            if (UnlockLevelPlayer == LevelScene)
            {
                YandexGame.savesData.CompletedLevels = LevelScene + 1;
                YandexGame.SaveProgress();
            }
            if (LevelScene == 1)
            {
                YandexGame.ReviewShow(true);
            }

            GameObject.Find("Canvas").transform.Find("Loading").GetComponent<LoadingScreenController>().LoadLevel("menu");
            this.enabled = false;

        }
    }

    void Scene5Update()
    {
        if (palbel == true && palpink == true && palcin == true && palyell == true)
        {

            int UnlockLevelPlayer = YandexGame.savesData.CompletedLevels;
            string levelName = SceneManager.GetActiveScene().name;
            int LevelScene;
            Int32.TryParse(levelName.Substring(levelName.Length - 1), out LevelScene);
            isWin = true;

            if (UnlockLevelPlayer == LevelScene)
            {
                YandexGame.savesData.CompletedLevels = LevelScene + 1;
                YandexGame.SaveProgress();
            }

            GameObject.Find("Canvas").transform.Find("Loading").GetComponent<LoadingScreenController>().LoadLevel("menu");
            this.enabled = false;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pink"))
        {
            palpink = true;
            if (palbel == false)
            {
                gameover();
            }

        }
        if (other.gameObject.CompareTag("white"))
        {
            palbel = true;
            if (cinact == false)
            {
                gameover();
            }
        }
        if (other.gameObject.CompareTag("blue"))
        {
            palcin = true;
            if (NomerScene >=5 && yellAct == false)
            {
                gameover();
            }
        }
        if (other.gameObject.CompareTag("Player") && isWin == false)
        {
            gameover();
        }
        if (other.gameObject.CompareTag("yell"))
        {
            palyell = true;
        }
    }
    public void gameover()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
