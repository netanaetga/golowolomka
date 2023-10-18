using UnityEngine;

public class AudioChanger : MonoBehaviour
{
    public static AudioChanger Instance;
    public AudioClip menuClip;
    public AudioClip igraClip;
    public AudioSource source;

    private float volumeStart;
    public bool vkl = true;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
        volumeStart = source.volume;
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ChangeMusic(string nameScene)
    {
        if (nameScene == "menu")
        {
            source.clip = menuClip;
        }
        else
        {
            source.clip = igraClip;
        }

        source.Play();
    }

    public void Volume()
    {
        vkl = !vkl;
        if (vkl == true)
        {
            source.volume = volumeStart;
        }
        else
        {
            source.volume = 0;
        }
    }
}
