using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _positionSpawn;
    [SerializeField] private float _timeBeetwenSpanw;

    private float _elapsedTime = 0;
    private int _numberPointSpawn = 0;


    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBeetwenSpanw && _numberPointSpawn < _positionSpawn.Length)
        {
            _elapsedTime = 0;
            Instantiate(_prefab, _positionSpawn[_numberPointSpawn]);
            _numberPointSpawn += 1;

            if (_numberPointSpawn >= _positionSpawn.Length)
                _numberPointSpawn = 0;
        }
        
    }
}
