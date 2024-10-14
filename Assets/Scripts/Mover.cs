using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] private Vector3 _speedDirection;

     void Update()
     {
         transform.position += _speedDirection;
     }
}
