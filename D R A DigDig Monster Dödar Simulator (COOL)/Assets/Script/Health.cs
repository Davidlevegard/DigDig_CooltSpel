using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;

    int damage = 10;

    int maxHealth = 100;
    int currentHealth = 100;
    int dmg = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentHealth);
    }

    public void takeDamage()
    {
        currentHealth -= dmg;
    }
    public void onTakeDamage()
    {
        health = health - damage;
        healthBar.fillAmount = health;
    }
}
