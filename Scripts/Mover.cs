using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
    }
}
