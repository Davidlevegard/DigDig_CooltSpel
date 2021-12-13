using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;

    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }

}
