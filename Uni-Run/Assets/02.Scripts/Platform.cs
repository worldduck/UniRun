using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; // ��ֹ� ������Ʈ��
    public GameObject[] coins; // ���� �ִϸ��̼� ������Ʈ��
    public GameObject[] hearts; // ü�� ������Ʈ��

    private bool stepped = false; // �÷��̾� ĳ���Ͱ� ��Ҵ°�

    // ������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        // ���� ���¸� ����
        stepped = false;

        //// ��ֹ��� ����ŭ ����
        //for (int i = 0; i < obstacles.Length; i++)
        //{
        //    // ���� ������ ��ֹ��� 1/3 Ȯ���� Ȱ��ȭ
        //    if (Random.Range(0, 3) == 0)
        //    {
        //        obstacles[i].SetActive(true);
        //    }
        //    else
        //    {
        //        obstacles[i].SetActive(false);
        //    }
        //}

        // ����ó���� ���� �ǹ����� �� ���� ���
        foreach(GameObject a in obstacles)
        {
            a.SetActive(Random.Range(0, 3) == 0 ? true : false);
        }
        
        foreach (GameObject b in coins)
        {
            b.SetActive(Random.Range(0, 3) == 0 ? true : false);
        }

        foreach (GameObject c in hearts)
        {
            c.SetActive(Random.Range(0, 7) == 0 ? true : false);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������ �±װ� Player�̰�
        // ������ �÷��̾� ĳ���Ͱ� ���� �ʾҴٸ�
        if (collision.collider.tag == "Player" && !stepped)
        {
            // ������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}
