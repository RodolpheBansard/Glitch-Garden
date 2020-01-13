using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendersSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        Vector2 spawnPos = SnapToGrid(GetSquareClicked());
        AttemptToPlaceDefender(spawnPos);        
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefender(Vector2 spawnPos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();

        if (StarDisplay.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(spawnPos);
            StarDisplay.SpendingStars(defenderCost);
        }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private Vector2 SnapToGrid(Vector2 worldPos)
    {
        float newX = Mathf.RoundToInt(worldPos.x);
        float newY = Mathf.RoundToInt(worldPos.y);
        return new Vector2(newX, newY);
    }
    

    private void SpawnDefender(Vector2 spawnPos)
    {
        Defender newdefender = Instantiate(defender, spawnPos, transform.rotation) as Defender;
    }
}
