using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPElement : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private Image healthBar;

    public void SetImage(Sprite image) {
        img.sprite = image;
    }

    public void SetHealth(float amount, Color color) {
        healthBar.fillAmount = amount;
        healthBar.color = color;
    }

    private void Start() {
    }

    private void Update() {
    }
}
