using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class TurretController : MonoBehaviour
{
    [SerializeField] private GameObject targetObj; // 바라보는 대상
    [SerializeField] private GameObject turretHead; // 터렛의 머리

    [SerializeField] private GameObject bulletPrefab; // 총알 프리팹
    [SerializeField] private Transform firePos; // 총알이 발사되는 위치
    [SerializeField] private float timer = 0f;
    [SerializeField] private float fireDelay = 0.5f; // 발사 딜레이

    void Start()
    {
        targetObj = GameObject.FindWithTag("Player"); // 태그를 통해서 바라보는 대상을 찾음
        turretHead = transform.GetChild(0).gameObject;
        firePos = turretHead.transform.GetChild(0).transform; // 총구 위치를 저장
        // Debug.Log($"firePos : {firePos.name}");
    }

    void Update()
    {
        ViewTarget();

        timer += Time.deltaTime;
        if (timer >= fireDelay)
        {
            timer = 0f; // 타이머 초기화
            Debug.Log("발사");
            Fire();
        }
    }

    void ViewTarget()   // 무엇인가를 바라보는 기능
    {
        turretHead.transform.LookAt(targetObj.transform.position);
    }

    void Fire() // 총알을 발사하는 기능
    {
        Quaternion rot = Quaternion.LookRotation(targetObj.transform.position - firePos.position); // 바라보는 방향을 구함
        GameObject bullet = Instantiate(bulletPrefab, firePos.position, rot); // 총알을 발사
        bullet.GetComponent<Bullet>().SetTarget(targetObj); // 총알의 바라보는 대상을 설정
    }
}
