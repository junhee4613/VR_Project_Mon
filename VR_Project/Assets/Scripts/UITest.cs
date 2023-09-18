using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UITest
{
    //UI Manager
    public static Stack<GameObject> pageTrace = new Stack<GameObject>();
    public static void OpenPage(GameObject _input)
    {
        pageTrace.Push(_input);
    }
    public static void ReturnPage()
    {

    }
    /*[Header("Login")]
    public GameObject a;
    public LoginUI login;
    [Header("Regist")]
    public GameObject b;
    public RegistUI regist;

    [SerializeField] AudioClip clip;

    public void PlaySound()
    {

    }
    public void OnClick_Login()
    {

    }
    public void OnClick_Register()
    {

    }*/
}
