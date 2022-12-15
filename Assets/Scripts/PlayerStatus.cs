using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private int collectibles = 0;
    [SerializeField] private int defMaxHealth = 10;
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    private int collectibles1;

    public int Collectibles { get => collectibles; set => collectibles = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }


    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = defMaxHealth;
        CurrentHealth = maxHealth;
    }

    /*
    public int GetCollectibles()
    {
        return collectibles;
    }



    public void SetCollectibles(int value)
    {
        collectibles = value;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public void SetMaxHealth(int value)
    {
        maxHealth = value;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public void SetCurrentHealth(int value)
    {
        currentHealth = value;
    }

    */
}
