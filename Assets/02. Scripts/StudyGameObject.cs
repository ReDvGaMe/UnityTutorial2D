using Unity.VisualScripting;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private GameObject destroyObj;

    [SerializeField] private Vector3 pos;
    [SerializeField] private Quaternion rot;

    void Start()
    {
        CreateAmongUs();

        // Destroy(destroyObj); // 매개 변수로 들어간 게임 오브젝트를 파괴하는 기능
        // Destroy(destroyObj, 3f); // 3초 뒤에 파괴시키는 기능
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>
    /// <param name="name"></param>
    void CreateAmongUs(string name = "어몽어스 캐릭터")
    {
        GameObject obj = Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능
        obj.name = name;

        Debug.Log($"<color=#0000FF> 오브젝트({name})</color>가 생성되었습니다.");

        GameObject childObj = obj.transform.GetChild(0).gameObject; // 자식 오브젝트를 가져오는 기능
        Transform childObjTransform = childObj.transform; // 자식 오브젝트의 Transform을 가져오는 기능
        int count = childObjTransform.childCount; // 자식 오브젝트의 수를 가져오는 기능

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {childObjTransform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {childObjTransform.GetChild(count - 1).name}");
    }
}
