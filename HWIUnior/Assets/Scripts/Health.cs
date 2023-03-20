using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _damage=10;
    private int _recovery=10;
    private int _nowHealth;

     [SerializeField] private HealthBar healthBar=new HealthBar();

    private void Start()
    {
        _nowHealth = _maxHealth;
        healthBar.Slider(_nowHealth, _maxHealth);
    }

    public void GetDamage()
    {
        if (_nowHealth > 0)
        {
            _nowHealth -= _damage;
            healthBar.Slider(_nowHealth, _maxHealth);
        }
    }

    public void RestorationHealth()
    {
        if (_nowHealth < _maxHealth)
        {
            _nowHealth += _recovery;
            healthBar.Slider(_nowHealth, _maxHealth);
        }
    }
}
