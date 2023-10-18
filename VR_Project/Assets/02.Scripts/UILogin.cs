using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;   //regex 쓸 때

public class UILogin : MonoBehaviour
{
    [Header("Main Page")]
    [SerializeField] private GameObject loginPage;
    [SerializeField] private Button button_login;
    [SerializeField] private Button button_regist;
    [SerializeField] private TMP_InputField inputField_ID;
    [SerializeField] private TMP_InputField inputField_password;
    private string input_id;
    private string input_password;

    [Header("Terms and Service")]
    [SerializeField] private GameObject termsAndServicePage;
    [SerializeField] private Toggle toggle_1;
    [SerializeField] private Toggle toggle_2;
    [SerializeField] private Toggle toggle_all;

    //[compoenet]_[state]_[name]_[+description]
    [Header("Regist Page")]
    [SerializeField] private GameObject registPage;
    [SerializeField] private Button button_registAccept;
    [SerializeField] private TMP_InputField inputField_regist_email;
    [SerializeField] private TMP_InputField inputField_regist_password;
    [SerializeField] private TMP_InputField inputField_regist_passwordcheck;
    [SerializeField] private GameObject popup_registSuccess;
    public void Onclick_ReturnPage()
    {
        PageTracer.ReturnPage();
    }
    public void Onclick_ReturnToMainPage()
    {
        PageTracer.ReturnPage(loginPage);
    }
    #region Login
    public void Onclick_Login()
    {
        OnLogin();
    }
    public void Onclick_Regist()
    {
        OnGotoTASPage();
    }
    private void OnLogin()
    {
        input_id = inputField_ID.text;
        input_password = inputField_password.text;

        Debug.Log("입력하신 아이디는 : " + input_id);
        Debug.Log("입력하신 비밀번호는 : " + inputField_password);
    }
    public void OnGotoTASPage()
    {
        PageTracer.OpenPage(termsAndServicePage, loginPage);
    }
    #endregion

    #region TAS

    public void Onclick_AgreeTAS()
    {
        OnGoToRegistPage();
    }
    public void OnGoToRegistPage()
    {
        if (!CheckIsToggleAccept())
        {
            Debug.Log("모두 동의하세요");
            return;
        }
        PageTracer.OpenPage(registPage, termsAndServicePage);
    }
    public void Onclick_Toggle1()
    {
        //토글 2의 체크 조사
        //만약, 토글 2가 체크 되어 있을 시, 토글 all체크

        //토글 해제 시, 토글 all체크 해제
    }
    public void Onclick_Toggle2()
    {
        //토글 1의 체크 조사
        //만약, 토글 1가 체크 되어 있을 시, 토글 all체크

        //토글 해제 시, 토글 all체크 해제

    }
    private bool is_toggle;
    public void Onclick_ToggleAll()
    {
        //토글 1과 2의 체크 조사
        //각 토글 조사 후 체크 표시 안 되어 있을 시, 체크

        //이미 체크 되어 있는 상태이었을 시, 토글 1과 2 모두 체크 해제
    }
    private bool CheckIsToggleAccept()
    {
        if (!toggle_1.isOn || !toggle_2.isOn)
            return false;
        else
            return true;
    }
    #endregion
    #region Regist
    public void Onclick_RegistAccept()
    {
        if (!CheckEmailForm2(inputField_regist_email.text))
        {
            Debug.Log("이메일 에러");
            return;
        }
        if(!CheckPasswordForm2(inputField_regist_password.text, inputField_regist_passwordcheck.text))
        {
            Debug.Log("비밀번호 에러");
            return;
        }
        Debug.Log("회원가입 성공을  축하드립니다. 짝짝짝");

    }
    private void OnRegistAccept()
    {
        if (!CheckEmailForm())
        {
            Debug.Log("이메일 양식에 맞지 않습니다.");
            return;
        }
        if (!CheckPasswordForm())
        {
            Debug.Log("비밀번호는 4-12자 이내의 영문과 숫자의 혼합이 이루어져야 합니다.");
            return;
        }
        if (!CheckPasswordSame())
        {
            Debug.Log("비밀전호가 일치하지 않습니다.");
            return;
        }
        Debug.Log("회원가입 성공을 축하드립니다. 짝짝짝");

        PageTracer.OpenPage(popup_registSuccess, registPage, true);
    }

    //정규식
    //regex

    bool CheckEmailForm2(string email, GameObject _formError = null)
    {
        if(!Regex.IsMatch(email, ""))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    bool CheckPasswordForm2(string _password, string _passwordCheck, GameObject _formError = null, GameObject _confirmError= null)
    {
        if(!Regex.IsMatch(_password, ""))
        {

        }

        if (_password != _passwordCheck)
        {
            return false;
        }
        else
            return true;
    }
    bool CheckPasswordForm()
    {
        return false;
    }
    bool CheckEmailForm()
    {
        return false;
    }
    bool CheckPasswordSame()
    {
        return false;
    }
    #endregion
}
