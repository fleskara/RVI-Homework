using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthElement : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    public void SetHealth(float amount, Color barColor) {
        healthBar.fillAmount = amount;
        healthBar.color = barColor;
    }

    private void Start() {  
    }

    private void Update() {
    }
}

