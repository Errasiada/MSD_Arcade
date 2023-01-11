using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;

    public void ActivateLosePanel()
    {
        losePanel.SetActive(false);
    }
    
}

