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
    public int healing = 10;

    public healthBarController healthBar;
    public SpriteRenderer spriteRenderer;

    public Sprite strongMonster;
    public Sprite normalMonster;
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
        if (currentHealth > 80)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = strongMonster;
        }
        else if (currentHealth > 40)
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = normalMonster;
        }
        else if (currentHealth > 0)
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = hurtMonster;
        }
        else
        {
            Destroy(healthBar.gameObject);
            Destroy(gameObject);

        }
    }

    public void takeDamage()
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void healDamage()
    {
        if (currentHealth < maxHealth)
        currentHealth += healing;
        healthBar.SetHealth(currentHealth);
    }
}
