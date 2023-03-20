using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;

    public void Slider(int currentHealth,int maxHealth)
    {
        _healthBarSlider.value=currentHealth;
        _healthBarSlider.maxValue=maxHealth;
    }
}
