using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _spin;

    private void Update()
    {
        transform.Rotate(Vector3.up, _spin * Time.deltaTime);
    }
}
