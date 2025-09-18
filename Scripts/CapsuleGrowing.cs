
using UnityEngine;

public class CapsuleGrowing : MonoBehaviour
{
    [SerializeField] private float _speedGrowth;
    [SerializeField] private float _maxSize;
    [SerializeField] private float _minSize;

    private bool _IsGrowing;

    private void Start()
    {
        _IsGrowing = true;
    }

    private void Update()
    {
        float scaleChange = _IsGrowing ? _speedGrowth * Time.deltaTime : -(_speedGrowth * Time.deltaTime);

        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);

        CheckSizeLimits();
    }

    private void CheckSizeLimits()
    {
        float currentSize = transform.localScale.x;

        if (currentSize >= _maxSize && _IsGrowing)
        {
            _IsGrowing = false;
        }
        else if (currentSize <= _minSize && !_IsGrowing)
        {
            _IsGrowing = true;
        }
    }
}
