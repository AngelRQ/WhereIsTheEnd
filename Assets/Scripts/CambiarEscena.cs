using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
   public void CambiarEscenaClick(string sceneName)
    {
        Debug.Log("CAMBIO DE ESCENA:" + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void SalirJuego()
    {
        Debug.Log("SALIENDO DEL JUEGO");
        Application.Quit();
    }
}
