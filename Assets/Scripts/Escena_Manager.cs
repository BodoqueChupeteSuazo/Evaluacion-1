using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena_Manager : MonoBehaviour
{
    public void escena_facil()
    {
        SceneManager.LoadScene("Facil", LoadSceneMode.Single);

    }
    public void escena_medio()
    {
        SceneManager.LoadScene("Medio", LoadSceneMode.Single);

    }
    public void escena_dificil()
    {
        SceneManager.LoadScene("Dificil", LoadSceneMode.Single);

    }
}
