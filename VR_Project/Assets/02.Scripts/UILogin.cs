using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;   //regex �� ��

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

        Debug.Log("�Է��Ͻ� ���̵�� : " + input_id);
        Debug.Log("�Է��Ͻ� ��й�ȣ�� : " + inputField_password);
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
            Debug.Log("��� �����ϼ���");
            return;
        }
        PageTracer.OpenPage(registPage, termsAndServicePage);
    }
    public void Onclick_Toggle1()
    {
        //��� 2�� üũ ����
        //����, ��� 2�� üũ �Ǿ� ���� ��, ��� allüũ

        //��� ���� ��, ��� allüũ ����
    }
    public void Onclick_Toggle2()
    {
        //��� 1�� üũ ����
        //����, ��� 1�� üũ �Ǿ� ���� ��, ��� allüũ

        //��� ���� ��, ��� allüũ ����

    }
    private bool is_toggle;
    public void Onclick_ToggleAll()
    {
        //��� 1�� 2�� üũ ����
        //�� ��� ���� �� üũ ǥ�� �� �Ǿ� ���� ��, üũ

        //�̹� üũ �Ǿ� �ִ� �����̾��� ��, ��� 1�� 2 ��� üũ ����
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
            Debug.Log("�̸��� ����");
            return;
        }
        if(!CheckPasswordForm2(inputField_regist_password.text, inputField_regist_passwordcheck.text))
        {
            Debug.Log("��й�ȣ ����");
            return;
        }
        Debug.Log("ȸ������ ������  ���ϵ帳�ϴ�. ¦¦¦");

    }
    private void OnRegistAccept()
    {
        if (!CheckEmailForm())
        {
            Debug.Log("�̸��� ��Ŀ� ���� �ʽ��ϴ�.");
            return;
        }
        if (!CheckPasswordForm())
        {
            Debug.Log("��й�ȣ�� 4-12�� �̳��� ������ ������ ȥ���� �̷������ �մϴ�.");
            return;
        }
        if (!CheckPasswordSame())
        {
            Debug.Log("�����ȣ�� ��ġ���� �ʽ��ϴ�.");
            return;
        }
        Debug.Log("ȸ������ ������ ���ϵ帳�ϴ�. ¦¦¦");

        PageTracer.OpenPage(popup_registSuccess, registPage, true);
    }

    //���Խ�
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
