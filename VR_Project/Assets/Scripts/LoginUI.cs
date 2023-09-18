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
    
    public Stack<GameObject> hoho = new Stack<GameObject>();        //������ ����
    public Queue<GameObject> list = new Queue<GameObject>();

    //�α��ο� ���õ� ���븸 �ۼ�

    //���� + ���� + ��Ÿ + �ִ�/�ּұ������� + ���� + ...

    /*
     UIUX�� ���� ���� ���̴� �˰���(���)
    Hashset�� �����ϰ� �������� ���� ��� ������� 
    DB -> �����̴�. 
    �ڷᱸ�� -> ��ųʸ�, ����Ʈ �ؽ���: ��ųʸ��� 2�߱���: ������ ����ϴ�. 
    ����Ʈ�� �� �� ����ְ� ���� ���� �̷��Ÿ� ����Ʈ�� ������ ���� �ٸ� �ɷ� ������. ����: ������ �༮�� �ƴϰ� GameObjectŸ���� ������ ���ſ� Ÿ���̴�.
    2�� 3�� ����Ʈ�� ���� �� �ڷᱸ���� ���� �߾˸� DB�� ��� �� ���� ���� �����ϴ�. �ٸ� 2�� ����Ʈ�� ���� �ʴ�. 
    Json�� �迭�̴�. �̰� ���� �� �ʼ�!! DB�� ����Ƽ���� ����� Json�Ľ��ϴ� �� �߾˾ƾ��Ѵ�. �ϳ��� �԰��̴�. ������ �����ϴ�.
    ���¼ҽ� -> copy & paste + (�޻ﾲ�� + �ѱ�)���� -> �޸� ��Ű�� ���� ��´�. �ڵ��ϼ� �������� �ϳ��ϳ� �� ���鼭 �帧�� �ľ��ض�
    1.�ڷΰ���
    2.���������� �̵�
    3.���� ���

    4.ȸ������ �� �̸��� ���� üũ
    5.ȸ������ �� ���̵� ���� (���ڼ�) üũ + ��й�ȣ
     */

    public void OnClick_Login()
    {
        Login();
        Login_Server();
        Login_Database();

        Debug.Log("�α��� ����!");
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
    //Ư�� UI��
    //��ư -> ��ȹ����, ���� ��ô�� ���� ��ȭ����
    //��ư  function Name �ٲ�
    //
}
