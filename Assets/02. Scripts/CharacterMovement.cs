using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    void Update()
    {
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 방향키
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        /* if (Input.GetKey(KeyCode.W))    // 앞으로 가는 기능
            transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))    // 뒤로 가는 기능
            transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))    // 왼쪽으로 가는 기능
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))     // 오른쪽으로 가는 기능
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime); */

        // float h = Input.GetAxis("Horizontal"); // -1 ~ 1
        // float v = Input.GetAxis("Vertical"); // -1 ~ 1

        // 딱 떨어지는 값
        float h = Input.GetAxisRaw("Horizontal"); // -1 ~ 1
        float v = Input.GetAxisRaw("Vertical"); // -1 ~ 1

        Vector3 dir = new(h, 0, v); // 방향을 나타내는 벡터

        Vector3 normalizedDir = dir.normalized; // 방향을 나타내는 벡터의 정규화(0 ~ 1)

        Debug.Log($"현재 입력 : {normalizedDir}");

        transform.position += moveSpeed * Time.deltaTime * normalizedDir; // 이동하는 기능

        // 회전
        transform.LookAt(transform.position + normalizedDir); // 바라보는 기능
    }
}
