using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonSoundType 
{ 
    ONE,
    TWO,
    THREE
}

public class LoginUI : MonoBehaviour
{

    public List<int> haha = new List<int>();
    
    public Stack<GameObject> hoho = new Stack<GameObject>();        //페이지 관리
    public Queue<GameObject> list = new Queue<GameObject>();

    //로그인에 관련된 내용만 작성

    //서버 + 인증 + 오타 + 최대/최소글자제한 + 동의 + ...

    /*
     UIUX상 가장 많이 쓰이는 알고리즘(기능)
    Hashset은 간소하고 제한적인 곳에 우겨 넣을라고 
    DB -> 엑셀이다. 
    자료구조 -> 딕셔너리, 리스트 해쉬셋: 딕셔너리는 2중구조: 엑셀과 비슷하다. 
    리스트를 쓸 때 비어있게 하지 말라 이럴거면 리스트로 만들지 말고 다른 걸로 만들어라. 이유: 가벼운 녀석이 아니고 GameObject타입이 굉장히 무거운 타입이다.
    2중 3중 리스트를 쓰는 등 자료구조에 대해 잘알면 DB를 배울 때 쉽게 접근 가능하다. 다만 2중 리스트는 좋지 않다. 
    Json도 배열이다. 이거 쓰는 법 필수!! DB를 유니티에서 쓸라면 Json파싱하는 거 잘알아야한다. 하나의 규격이다. 굉장히 강력하다.
    오픈소스 -> copy & paste + (달삼쓰뱉 + 한글)금지 -> 달면 삼키고 쓰면 뱉는다. 자동완성 쓰지말고 하나하나 다 쓰면서 흐름을 파악해라
    1.뒤로가기
    2.다음페이지 이동
    3.사운드 출력

    4.회원가입 시 이메일 구조 체크
    5.회원가입 시 아이디 구조 (글자수) 체크 + 비밀번호
     */

    public void OnClick_Login()
    {
        Login();
        Login_Server();
        Login_Database();

        Debug.Log("로그인 성공!");
    }
    
    public void OnClick_GoToRegist()
    {
        gameObject.SetActive(false);
        GameObject registUI = new GameObject();
        registUI.SetActive(true);

        UITest.OpenPage(registUI);
    }
    void ReturnPage()
    {

    
    }
    void Login()
    {

    }
    void Login_Server()
    {

    }
    void Login_Database()
    {

    }
    //특히 UI쪽
    //버튼 -> 기획따라, 개발 진척도 따라 변화무쌍
    //버튼  function Name 바뀜
    //
}
