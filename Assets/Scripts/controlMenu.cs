using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlMenu : MonoBehaviour
{
    [SerializeField]
    GameObject ayuda;


    int miNivel;
    public void Jugar(int nivel) {
        miNivel = nivel;
        Invoke("pasar", 1);
    }

    public void Ayuda() {
        ayuda.SetActive(true);
    }

    public void Salir() {
        Invoke("terminar",1);
    }

    public void CerrarAyuda() {
        ayuda.SetActive(false);
    }

    void pasar() {
        SceneManager.LoadScene(miNivel);
    }

    public void menu() {
        SceneManager.LoadScene(0);
    }

    void teminar() {
        Application.Quit();
    }
}
