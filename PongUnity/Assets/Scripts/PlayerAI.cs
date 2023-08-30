using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public Paddle paddle;
    Ball currentBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBall == null)
        {
            FindBall();
        }
        else
        {
            FollowBall();
        }
    }

    void TrashTalk()
    {
        Debug.Log("GG EZ FF");
    }
    
    void FindBall()
    {
        currentBall = FindAnyObjectByType<Ball>();
    }
            
    void FollowBall()
    {
        if (currentBall.transform.position.y > paddle.transform.position.y)
        {
            paddle.MoveUp();
        }
        else if (currentBall.transform.position.y < paddle.transform.position.y)
        {
            paddle.MoveDown();
        }

    }

}
