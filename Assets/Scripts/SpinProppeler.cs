using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProppeler : MonoBehaviour
{
    [SerializeField] private GameObject _proppeler;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.back * _rotationSpeed * Time.deltaTime);
    }
}
