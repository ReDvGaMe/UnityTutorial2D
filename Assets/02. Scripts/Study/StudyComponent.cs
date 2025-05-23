using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private Transform objTf;
    [SerializeField] private string changeName; // 오브젝트 이름을 변경할 변수

    public Mesh mesh;
    public Material material;

    void Start()
    {
        // obj = GameObject.FindGameObjectWithTag("Main Camera"); // Main Camera 오브젝트를 찾아서 obj에 할당
        // obj = GameObject.FindGameObjectWithTag("Player");   // Player라는 태그를 가진 오브젝트를 찾아서 obj에 할당
        // objTf = obj.transform; // obj의 Transform 컴포넌트를 objTf에 할당

        // obj = new GameObject();
        // obj.name = "Cube";


        /* // obj.name = changeName;
        // obj.GetComponent<MeshRenderer>().material.color = Color.cyan;

        Debug.Log($"<color=#0000FF>이름 : {obj.name}</color>");    // 게임 오브젝트의 이름
        Debug.Log($"<color=#0000FF>태그 : {obj.tag}</color>");     // 게임 오브젝트의 태그
        Debug.Log($"<color=#0000FF>위치 : {obj.transform.position}</color>"); // 게임 오브젝트의 위치
        Debug.Log($"<color=#0000FF>회전 : {obj.transform.rotation}</color>"); // 게임 오브젝트의 회전
        Debug.Log($"<color=#0000FF>크기 : {obj.transform.localScale}</color>"); // 게임 오브젝트의 크기

        // MeshFilter 컴포넌트에 접근해서 Mesh를 Log로 출력하
        Debug.Log($"<color=#f5bf42>Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}</color>");

        // MeshRenderer 컴포넌트에 접근해서 Material을 Log로 출력
        Debug.Log($"<color=#f5bf42>Material 데이터 : {obj.GetComponent<MeshRenderer>().material}</color>");

        // obj의 MeshRenderer 컴포넌트에 접근해서 활성상태를 false로 변경
        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj의 GameObject 활성상태를 false로 변경
        // obj.SetActive(false);
        // obj의 Transform 컴포넌트를 통해 GameObject를 비활성화
        objTf.gameObject.SetActive(false); */

        // CreateCube("Cube"); // 큐브 생성 메서드 호출
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // 큐브 생성
    }

    // 큐브 생성 기능
    void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name); // "Cube"라는 이름을 가진 오브젝트를 찾아서 obj에 할당

        obj.AddComponent<MeshFilter>(); // obj에 MeshFilter 컴포넌트를 추가
        obj.AddComponent<MeshRenderer>(); // obj에 MeshRenderer 컴포넌트를 추가
        obj.AddComponent<BoxCollider>(); // obj에 BoxCollider 컴포넌트를 추가

        obj.GetComponent<MeshFilter>().mesh = mesh; // obj의 MeshFilter 컴포넌트에 mesh를 할당
        obj.GetComponent<MeshRenderer>().material = material; // obj의 MeshRenderer 컴포넌트에 material을 할당
    }
}
