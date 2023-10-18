using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingScreenController : MonoBehaviour
{

    public Slider progressBar; 
    public Image zatemnaylka;

    AsyncOperation async;
    public TMP_Text progressText;

    public float durationLoad;

    private bool isLoading = false;

    private void Start()
    {
    }

    public void LoadLevel(string levelName)
    {
        if (isLoading == false)
        {
            StartCoroutine(LoadLevelWithProgressBar(levelName));
            isLoading = true;
        }
    }

    IEnumerator LoadLevelWithProgressBar(string levelName)
    {
        yield return FadeLoadingScreen(1, 3, zatemnaylka);
        progressBar.gameObject.SetActive(true);

        async = SceneManager.LoadSceneAsync(levelName);
        async.allowSceneActivation = false;

        bool startEnd = false;
        float time = 0;
        float targetValue = 0.4f;
        float startValue = 0;
        float progressValue = 0;

        while (!async.isDone)
        {
            if (time > durationLoad && !startEnd)
            {
                startEnd = true;
                targetValue = async.progress / 0.9f;
                time = 0;
                durationLoad = 2;
                startValue = progressValue;
            }

            progressValue = Mathf.Lerp(startValue, targetValue, time / durationLoad);
            time += Time.deltaTime;
            progressText.text = "Загрузка: " + Mathf.Round(progressValue * 100) + "%";
            progressBar.value = progressValue;

            if (progressValue >= 0.9f)
            {

                //Change the Text to show the Scene is ready
                progressText.text = "Нажмите пробел, чтобы продолжить";
                //Wait to you press the space key to activate the Scene
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    async.allowSceneActivation = true;
                }
                //Activate the Scene

            }
            yield return null;
        }
    }
    IEnumerator FadeLoadingScreen(float targetValue, float duration, Image imageFade)
    {
        float startValue = imageFade.color.a;
        float time = 0;
        while (time < duration)
        {
            imageFade.color = new Color(0, 0, 0, Mathf.Lerp(startValue, targetValue, time / duration));
            time += Time.deltaTime;
            yield return null;
        }
        imageFade.color = new Color(0, 0, 0, targetValue);
    }
}