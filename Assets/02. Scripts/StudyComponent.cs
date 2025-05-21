using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;

    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Main Camera 오브젝트를 찾아서 obj에 할당
        obj.name = changeName;
        // obj.GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
