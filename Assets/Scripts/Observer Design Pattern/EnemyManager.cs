using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyManager : Subject
{
    private List<Enemy> _enemies;

    void Start()
    {
        Attach(GetComponent<ScoreObserver>());
    }
    
    public void RemoveEnemy(Enemy enemy)
    {
        if (_enemies.Contains(enemy))
        {
            _enemies.Remove(enemy);
            NotifyObservers();
        }
    }
}
