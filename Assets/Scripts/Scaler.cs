using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _growthSpeed;

    private void Update()
    {
        transform.localScale += _growthSpeed;
    }
}
