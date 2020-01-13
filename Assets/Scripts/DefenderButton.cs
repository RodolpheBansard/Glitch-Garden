using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private DefendersSpawner defendersSpawner;

    private void Start()
    {
        defendersSpawner = FindObjectOfType<DefendersSpawner>();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(0x30, 0x30, 0x30,0xFF);
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        defendersSpawner.SetSelectedDefender(defenderPrefab);
    }
}
