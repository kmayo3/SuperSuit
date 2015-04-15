using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Score : MonoBehaviour 
{
        public static Score S; // The singleton for ScoreBoard
    public GameObject prefabFloatingScore;
    [SerializeField]
    int _score = 0;
    public string _scoreString;

    // The score property also sets the scoreString
    public int score
    {
        get { return _score; }
        set
        {
            _score = value;
        }
    }

    // The scoreString property also sets the GUIText.text
    public string scoreString
    {
        get { return _scoreString; }
        set { _scoreString = value;
        GetComponent<GUIText>().text = _scoreString; }
    }

    void Awake()
    {
        S = this;
    }

    // When called by SendMessage, this add the floatingScore.score to this.score
    public void FloatingScoreCallBack(Score floatingScore)
    {
        score += floatingScore.score;
    }

    // This will instantiate a new FloatingScore GameObject and initialize it
    // Also return a pointer to the FloatingScore created
    public Score CreateFloatingScore(int amount, List<Vector3> points)
    {
        GameObject gameObj = Instantiate(prefabFloatingScore) as GameObject;
        Score floatScore = gameObj.GetComponent<Score>();
        floatScore.score = amount;
        return floatScore;
    }
}
