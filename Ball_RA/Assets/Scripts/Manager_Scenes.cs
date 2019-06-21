using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_Scenes : MonoBehaviour
{
    public void changeToExplosao()
    {
        SceneManager.LoadScene("Trimmer");
    }

    public void changeToConsersao()
    {
        SceneManager.LoadScene("Conversao");
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
