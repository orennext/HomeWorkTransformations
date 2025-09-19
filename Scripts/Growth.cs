
using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speedGrowth;

    private void Update()
    {
        transform.localScale += Vector3.one * _speedGrowth * Time.deltaTime;
    }
}
