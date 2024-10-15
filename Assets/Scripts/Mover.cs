using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] private Vector3 _speedDirection;

     private void Update()
     {
         transform.position += _speedDirection;
     }
}
