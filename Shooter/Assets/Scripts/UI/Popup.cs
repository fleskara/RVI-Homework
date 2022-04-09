using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private HPElement playerHealthBar;
    [SerializeField] private Sprite playerImage;
    [SerializeField] private Color playerHealthColor;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private Color enemyHealthColor;
    [SerializeField] private GameObject healthBarPrefab;

    private void OnEnable() {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHealthBar.SetImage(playerImage);
        playerHealthBar.SetHealth((float)player.Health / 100, playerHealthColor);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < enemies.Length; i++) {
            Enemy enemy = enemies[i].GetComponent<Enemy>();
            GameObject enemyHealthBar = Instantiate(healthBarPrefab, GameObject.FindGameObjectWithTag("Content").transform);
            HPElement enemyHPElement = enemyHealthBar.GetComponent<HPElement>();
            enemyHPElement.SetImage(enemyImage);
            enemyHPElement.SetHealth((float)enemy.Health / 100, enemyHealthColor);
        }
    }
    
    private void Start() {
    }

    private void Update() {
    }
}
