using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _tankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_tankPrefab, transform.position, Quaternion.identity);
    }
}
