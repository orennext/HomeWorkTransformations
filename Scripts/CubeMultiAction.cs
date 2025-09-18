using UnityEngine;

public class CubeMultiAction : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedGrowth;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.up, _speedRotation * Time.deltaTime, Space.Self);
        transform.localScale += Vector3.one * _speedGrowth * Time.deltaTime;
    }
}
