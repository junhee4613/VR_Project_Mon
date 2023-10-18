using System;
using System.Collections.Generic;
using UnityEngine;
//��Ʈ�� + k + E���ϸ� �Ⱦ��� ��¡�� �������.

//��ƿ��Ƽ ��ũ��Ʈ�� ���Ӽ��� ����� �Ѵ�.
public static class PageTracer
{
    public static Stack<GameObject> stackedPage = new Stack<GameObject>();

    public static void OpenPage(GameObject _nextPage, GameObject _prePage, bool _isOpenOnly = false, Action _action = null)         //_inOpenOnly�� �Ű������� �ƹ��͵� �ȳ����� false���� �ǰ�_action �� �Ű������� �ƹ� �͵� �ȳ־��ָ� null���� �ȴ�.
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
    public static void FlushStackedPages(Action _action = null)      //������ ������ �Ѿ �� (������ �ʱ�ȭ ���ִ� �Լ�)
    {
        _action?.Invoke();
    }

}
