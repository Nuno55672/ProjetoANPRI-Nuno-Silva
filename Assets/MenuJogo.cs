using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJogo : MonoBehaviour
{
    [SerializeField]
    GameObject _menuPausa;
    public void MenuJogo_Recomecar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuPrincipal_Iniciar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex!=0)
        {
            _menuPausa.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void MenuJogo_Continuar()
    {
        _menuPausa.SetActive(false);
        Time.timeScale = 1;
    }

    public void MenuJogo_Sair()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuPrincipal_Sair()
    {
        Application.Quit();
    }

    public void MenuPrincipal_AbreCreditos()
    {
        SceneManager.LoadScene(1);
    }

    public void Creditos_Voltar()
    {
        SceneManager.LoadScene(0);
    }
}
