using UnityEngine;

public class ScoreObserver : Observer
{
    ScoreLabel _scoreLabel;

    public override void Notify(Subject subject)
    {
        _scoreLabel.UpdateScore(100);
    }
    
}
