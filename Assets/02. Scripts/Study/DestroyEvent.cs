using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    [SerializeField] private float destroyTime = 3f; // 파괴될 시간

    void Start()
    {
        Destroy(this.gameObject, destroyTime); // 자기 자신을 3초 뒤에 파괴시키는 기능
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name} 오브젝트가 파괴되었습니다.");
    }
}
