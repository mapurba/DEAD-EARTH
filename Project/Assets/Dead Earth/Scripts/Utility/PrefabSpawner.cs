using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab = null;
    [SerializeField] List<Transform> _spawnPoint = new List<Transform>();

    void Awake() 
    {
        if (_spawnPoint.Count == 0 || _prefab == null) return;
        int index = Random.Range(0, _spawnPoint.Count);
        Debug.Log(index);
        Transform spawnPoint = _spawnPoint[index];
        Instantiate(_prefab, spawnPoint.position, spawnPoint.rotation);

    }
}
