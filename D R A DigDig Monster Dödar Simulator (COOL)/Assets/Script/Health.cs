using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public float startHealth;

    public int damage = 10;
    public int maxHealth = 100;
    public int currentHealth;

    public healthBarController healthBar;
    public SpriteRenderer spriteRenderer;
    public Sprite hurtMonster;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); //Gör så att metoden "SetMaxHealth" i scriptet healthBarController aktiveras och variablen "health" i den metoden blir lika med "maxHealth" i detta scriptet.
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage()
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void healDamage()
    {
        //Ger fienden mer health
    }
}
