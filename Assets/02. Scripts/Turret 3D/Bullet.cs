using UnityEditor.ShaderGraph;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 총알정보
    [SerializeField] private float bulletSpeed = 100f;
    [SerializeField] private float lifeTime = 3f; // 총알의 수명
    [SerializeField] private float timer = 0f; // 총알의 타이머

    [SerializeField] private Transform barrelTransform; // 총구 위치

    [SerializeField] private GameObject targetObj; // 바라보는 대상

    void Start()
    {
        barrelTransform = GameObject.Find("Barrel").transform; // 총구 위치를 저장

        if (targetObj == null) return;

        Vector3 dir = (targetObj.transform.GetChild(0).GetChild(0).position - barrelTransform.position).normalized; // 바라보는 방향을 구함
        transform.forward = dir; // 바라보는 방향으로 회전
    }

    void Update()
    {
        transform.position += transform.forward * (bulletSpeed * Time.deltaTime); // 총알이 날아가는 기능

        timer += Time.deltaTime; // 타이머 증가
        if (timer >= lifeTime)
        {
            Destroy(gameObject); // 총알을 파괴하는 기능
        }
    }

    public void SetTarget(GameObject target)
    {
        targetObj = target; // 바라보는 대상을 설정
    }
}