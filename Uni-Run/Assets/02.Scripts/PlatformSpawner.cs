using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ �����ϰ� �ֱ������� ���ġ�ϴ� ��ũ��Ʈ
public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // ������ ������ ���� ������
    public int count = 3; // ������ ���� ��

    public float timeBetSpawnMin = 1.25f; // ���� ��ġ������ �ð� ���� �ּڰ�
    public float timeBetSpawnMax = 2.25f; // ���� ��ġ������ �ð� ���� �ִ�
    private float timeBetSpawn; // ���� ��ġ������ �ð� ����

    public float yMin = -3.5f; // ��ġ�� ��ġ�� �ּ� y ��
    public float yMax = 1.5f; // ��ġ�� ��ġ�� �ִ� y ��
    private float xPos = 20f; // ��ġ�� ��ġ�� x ��

    private GameObject[] platforms; // �̸� ������ ���ǵ�
    private float currentIndex = 0; // ����� ���� ������ ����

    // �ʹݿ� ������ ������ ȭ�� �ۿ� ���ܵ� ��ġ
    private Vector2 poolPosition = new Vector2(0, -25);
    private float lastSpqwnTime; // ������ ��ġ ����
    
    void Start()
    {
        // count ��ŭ�� ������ ������ ���ο� ���� �迭 ����
        platforms = new GameObject[count];

        // count��ŭ �����ϸ鼭 ���� ����
        for (int i = 0; i<count; i++)
        {

        }
    }

    void Update()
    {
        // ������ ���ư��� �ֱ������� ������ ��ġ
    }
}
