using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Penjelasan : MonoBehaviour
{

    public void Balik()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void TasAnyaman()
    {
        SceneManager.LoadScene("Tas Anyaman");
    }

    public void TasAnjat()
    {
        SceneManager.LoadScene("Tas Anjat");
    }
    public void TasTempat()
    {
        SceneManager.LoadScene("Tas Tempat Penginangan");
    }
    public void TasSelempang()
    {
        SceneManager.LoadScene("Tas Selempang");
    }
    public void TasUlap()
    {
        SceneManager.LoadScene("Tas Ulap Doyo");
    }

    public void TasEtnik()
    {
        SceneManager.LoadScene("Tas Etnik");
    }
    public void TasManik()
    {
        SceneManager.LoadScene("Tas Manik");
    }
}
