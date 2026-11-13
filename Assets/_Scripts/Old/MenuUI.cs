using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    GameManager gm;

    private void OnEnable()
    {
        // gm = GameManager.GetInstance();
    }
    
    public void Comecar()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.GAME);
    }
}
