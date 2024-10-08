using UnityEngine;
using UnityEngine.UI;

public class ScoreLabel : MonoBehaviour
{
    // Variables

    private int _score;
    private Text _textUI;
    
    // Singleton Code
    private static ScoreLabel _instance;
    
    public static ScoreLabel Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindFirstObjectByType<ScoreLabel>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = nameof(ScoreLabel);
                    _instance = obj.AddComponent<ScoreLabel>();
                }
            }
            return _instance;
        }
    }
    
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            
            // Get UI Component
            _textUI = GetComponent<Text>();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // To be called by other objects
    public void UpdateScore(int score)
    {
        _score = score;
        DisplayScore();
    }

    // Update text component
    void DisplayScore()
    {
        _textUI.text = "Score: " + _score;
    }
    
    
}
