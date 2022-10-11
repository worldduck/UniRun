using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 발판을 생성하고 주기적으로 재배치하는 스크립트
public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // 생성할 발판의 원본 프리팹
    public int count = 3; // 생성할 발판 수

    public float timeBetSpawnMin = 1.25f; // 다음 배치까지의 시간 간격 최솟값
    public float timeBetSpawnMax = 2.25f; // 다음 배치까지의 시간 간격 최댓값
    private float timeBetSpawn; // 다음 배치까지의 시간 간격

    public float yMin = -3.5f; // 배치할 위치의 최소 y 값
    public float yMax = 1.5f; // 배치할 위치의 최대 y 값
    private float xPos = 20f; // 배치할 위치의 x 값

    private GameObject[] platforms; // 미리 생성한 발판들
    private float currentIndex = 0; // 사용할 현재 순번의 발판

    // 초반에 생성한 발판을 화면 밖에 숨겨둘 위치
    private Vector2 poolPosition = new Vector2(0, -25);
    private float lastSpqwnTime; // 마지막 배치 시점
    
    void Start()
    {
        // count 만큼의 공간을 가지는 새로운 발판 배열 생성
        platforms = new GameObject[count];

        // count만큼 루프하면서 발판 생성
        for (int i = 0; i<count; i++)
        {

        }
    }

    void Update()
    {
        // 순서를 돌아가며 주기적으로 발판을 배치
    }
}
