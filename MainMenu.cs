using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {
    public void NextScene()
    { 
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextScene2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void NextScene3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BackScene2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    public void BackScene3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Restart()
    {
        SceneManager.LoadScene("signbengkala");
    }
    public void pilihmarker()
    {
        SceneManager.LoadScene("pilihmarker");
    }
    public void poster()
    {
        SceneManager.LoadScene("poster");
    }
    public void kartu()
    {
        SceneManager.LoadScene("kartu");
    }
    public void cangkir()
    {
        SceneManager.LoadScene("cangkir");
    }
    public void eja()
    {
        SceneManager.LoadScene("eja");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void tentang()
    {
        SceneManager.LoadScene("tentang");
    }
    public void QuitApps ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
