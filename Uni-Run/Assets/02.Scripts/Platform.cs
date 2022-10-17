using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; // 장애물 오브젝트들
    public GameObject[] coins; // 코인 애니메이션 오브젝트들
    public GameObject[] hearts; // 체력 오브젝트들

    private bool stepped = false; // 플레이어 캐릭터가 밟았는가

    // 컴포넌트가 활성화될 때마다 매번 실행되는 메서드
    private void OnEnable()
    {
        // 밟힘 상태를 리셋
        stepped = false;

        //// 장애물의 수만큼 루프
        //for (int i = 0; i < obstacles.Length; i++)
        //{
        //    // 현재 순번의 장애물을 1/3 확률로 활성화
        //    if (Random.Range(0, 3) == 0)
        //    {
        //        obstacles[i].SetActive(true);
        //    }
        //    else
        //    {
        //        obstacles[i].SetActive(false);
        //    }
        //}

        // 연산처리가 빨라서 실무에서 더 자주 사용
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
        // 충돌한 상대방의 태그가 Player이고
        // 이전에 플레이어 캐릭터가 밟지 않았다면
        if (collision.collider.tag == "Player" && !stepped)
        {
            // 점수를 추가하고 밟힘 상태를 참으로 변경
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}
