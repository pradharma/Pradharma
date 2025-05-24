using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TombolKeluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
    public void Mulai()
    {
        SceneManager.LoadScene("MulaiAR");
    }

    public void Penjelasan()
    {
        SceneManager.LoadScene("Penjelasan");
    }
    public void Tentang()
    {
        SceneManager.LoadScene("Tentang");
    }

}
