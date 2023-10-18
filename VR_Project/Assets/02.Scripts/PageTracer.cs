using System;
using System.Collections.Generic;
using UnityEngine;
//컨트롤 + k + E를하면 안쓰는 유징이 사라진다.

//유틸리티 스크립트는 종속성이 없어야 한다.
public static class PageTracer
{
    public static Stack<GameObject> stackedPage = new Stack<GameObject>();

    public static void OpenPage(GameObject _nextPage, GameObject _prePage, bool _isOpenOnly = false, Action _action = null)         //_inOpenOnly이 매개변수에 아무것도 안넣으면 false값이 되고_action 이 매개변수에 아무 것도 안넣어주면 null값이 된다.
    {
        if (stackedPage.Count < 1)
            stackedPage.Push(_prePage);

        _action?.Invoke();
        stackedPage.Push(_nextPage);

        _nextPage.SetActive(true);
        if (!_isOpenOnly)
            _prePage.SetActive(false);
    }
    public static void ReturnPage(Action _action = null)
    {
        if (stackedPage.Count < 2)
        {
            return;
        }

        _action?.Invoke();
        stackedPage.Peek().SetActive(false);
        stackedPage.Pop();
        stackedPage.Peek().SetActive(true);
    }

    public static void ReturnPage(GameObject _nameOfReturnTo, Action _action = null)
    {
        if (stackedPage.Count < 2)
        {
            return;
        }

        _action?.Invoke();

        int targerIndex = -1;
        int currentIndex = 0;

        foreach (GameObject item in stackedPage)
        {
            if (item == _nameOfReturnTo)
            {
                targerIndex = currentIndex;
                break;
            }
            currentIndex++;
        }

        int realTarget = stackedPage.Count - targerIndex;
        while (stackedPage.Count > 0)
        {
            stackedPage.Peek().SetActive(false);
            stackedPage.Pop();
        }

        stackedPage.Peek().SetActive(true);
    }
    public static void FlushStackedPages(Action _action = null)      //씬에서 씬으로 넘어갈 때 (스택을 초기화 해주는 함수)
    {
        _action?.Invoke();
    }

}
