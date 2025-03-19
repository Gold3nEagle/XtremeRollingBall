using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text winText;

    public void GameWon()
    {
        winText.gameObject.SetActive(true);
    }


}
