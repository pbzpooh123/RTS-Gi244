using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapBlip : MonoBehaviour
{
    private GameObject blip;
    public GameObject Blip
    {
        get { return blip; }
    }

    private Unit unit;

    private Building building;

    private Faction faction;
    // Start is called before the first frame update
    void Awake()
    {
        unit = GetComponent<Unit>();
        building = GetComponent<Building>();
    }
    
    void OnDestroy()
    {
        Destroy(blip);
    }
    
    private void SetColor()
    {
        if (unit != null)
            faction = unit.Faction;

        if (building != null)
        {
            faction = building.Faction;
            blip.GetComponent<RectTransform>().sizeDelta = new Vector2(6f, 6f);
        }

        if (faction != null)
            blip.GetComponent<Image>().color = faction.GetNationColor();
        else
            blip.GetComponent<Image>().color = Color.white;
    }

    private void Start()
    {
        blip = Instantiate(Minimap.instance.blipPrefab);
        blip.transform.SetParent(Minimap.instance.blipParent.transform);
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        blip.transform.position = Minimap.instance.worldPosToMinimapPos(transform.position);
        blip.transform.position = MainUI.instance.ScalePosition(blip.transform.position);
    }
}
