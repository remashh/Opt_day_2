using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Tanks;
using UnityEngine;

public class TankUpdate : MonoBehaviour, ITickable
{
    private readonly Vector3 _move = new Vector3(0, 0, 0.05f);
    public GameObject player;
    private Transform _playerTransform;

    private void Start()
    {
        player = GameObject.Find("Tank");
    }

    public void Tick()
    {
        _playerTransform = player.transform;
        if (player != null)
        {
            transform.LookAt(_playerTransform); 
            transform.Translate(_move);
        }
    }
}
