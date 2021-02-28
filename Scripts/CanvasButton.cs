    using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasButton : MonoBehaviour
{
    public Sprite musicOn, musicOff;

    private void Start()
    {
        if (PlayerPrefs.GetString("Music") == "No" && gameObject.name == "Music")
            GetComponent<Image>().sprite = musicOff;
    }

    public void RestartGame()
    {
        if (PlayerPrefs.GetString("Music") != "No")
            GetComponent<AudioSource>().Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void LoadShop()
    {
        if (PlayerPrefs.GetString("Music") != "No")
            GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("Shop");
            }

    public void CloseShop()
    {
        if (PlayerPrefs.GetString("Music") != "No")
            GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("1");
    }


    public void LoadInst()
    {
        Application.OpenURL("https://vk.com/a_a_pavl");
        if (PlayerPrefs.GetString("Music") != "No")
            GetComponent<AudioSource>().Play();
    }

    public void MusicWork()
    {
        // Музыка включена, надо выключить
        if (PlayerPrefs.GetString("Music") == "No")
        {
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetString("Music", "Yes");
            GetComponent<Image>().sprite = musicOn;
          //  GameObject.Find("GameControl").GetComponent<AudioSource>().Stop();
        }
        else
        {
            PlayerPrefs.SetString("Music", "No");
            GetComponent<Image>().sprite = musicOff;
        }
    }
    
}
