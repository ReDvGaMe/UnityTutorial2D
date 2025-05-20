using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + Vector3.forward * moveSpeed;

        if (Input.GetKey(KeyCode.W))    // 앞으로 가는 기능
        {
            transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))    // 뒤로 가는 기능
            transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        {
        }
        if (Input.GetKey(KeyCode.A))    // 왼쪽으로 가는 기능
        {
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))     // 오른쪽으로 가는 기능
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
    }
}
