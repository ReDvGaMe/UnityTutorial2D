using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f; // 자전 속도
    [SerializeField] private float orbitSpeed = 10f; // 공전 속도
    [SerializeField] private float orbitSpeedMultiplier = 10f;

    [SerializeField] private Transform orbitTarget; // 공전할 타겟

    void Start()
    {
        if (gameObject.name == "Sun Sphere") return;

        orbitTarget = gameObject.transform.parent;
        orbitSpeed *= orbitSpeedMultiplier; // 공전 속도 조정
    }

    void Update()
    {
        Rotate();

        if(orbitTarget != null)
            Orbit();
    }

    // 자전
    void Rotate()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

    // 공전
    void Orbit()
    {
        transform.RotateAround(orbitTarget.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
