using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var newPosition = transform.position;
        newPosition.z += _speed;
        transform.position = newPosition;
    }
}
