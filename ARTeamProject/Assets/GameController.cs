using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{

    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    int maxplatform = 0;

    public void GameOver() //�������� 0�̸� �� ���� ���� function �ҷ����� ��.
    {
        GameOverScreen.Setup(maxplatform);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
