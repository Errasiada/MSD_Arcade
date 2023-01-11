using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    private Paddle _playerController;
    [SerializeField] private TextMeshProUGUI texto;
    private void Start()
    {
        _playerController = FindObjectOfType<Paddle>();
    }

    private void Update()
    {
        texto.SetText($"Health: {_playerController.Health}");
    }
}