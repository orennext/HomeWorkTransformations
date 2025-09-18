using UnityEngine;

public class SphereMove : MonoBehaviour
{
    [SerializeField] private float _distanceMove;
    [SerializeField] private float _speedMove;

    private Vector3 _positionStart;
    private bool _IsMovingForward;

    private void Start()
    {
        _positionStart = transform.position;
        _IsMovingForward = true;
    }

    private void Update()
    {
        Vector3 targetPosition = _IsMovingForward ? _positionStart + Vector3.forward * _distanceMove : _positionStart;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speedMove * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) == 0)
        {
            _IsMovingForward = !_IsMovingForward;
        }
    }
}
