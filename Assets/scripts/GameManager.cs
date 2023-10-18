using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)   
            AudioChanger.Instance.ChangeMusic("igra");
        else
            AudioChanger.Instance.ChangeMusic("menu");
    }

}
