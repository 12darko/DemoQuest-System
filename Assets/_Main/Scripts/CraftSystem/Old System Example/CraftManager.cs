using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
/*
public class CraftManager : MonoBehaviour
{
    private Item _currentItem;
    public Image CustomCursor;

    public Slot[] craftingSlots;

    public List<Item> itemList;
    public string[] recipes;
    public Item[] recipeResults;
    public Slot resultSlot;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (_currentItem != null)
            {
                CustomCursor.gameObject.SetActive(false);
                Slot nearestSlot = null;
                float shortestDistance = float.MaxValue;
                foreach (var slot in craftingSlots)
                {
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);

                    if (dist < shortestDistance)
                    {
                        shortestDistance = dist;
                        nearestSlot = slot;
                    }
                }

                nearestSlot.gameObject.SetActive(true);
                nearestSlot.GetComponent<Image>().sprite = _currentItem.GetComponent<Image>().sprite;
                nearestSlot.Item = _currentItem;
                itemList[nearestSlot.index] = _currentItem;
                _currentItem = null;

                CheckForCreatedRecipes();
            }
        }
    }

    private void CheckForCreatedRecipes()
    {
        resultSlot.gameObject.SetActive(false);
        resultSlot.Item = null;
        string currentRecipeString = "";

        foreach (var item in itemList)
        {
            if (item != null)
            {
                currentRecipeString += item.Name;
            }
            else
            {
                currentRecipeString += "null";
            }
        }

        for (int i = 0; i < recipes.Length; i++)
        {
            if (recipes[i] == currentRecipeString)
            {
                resultSlot.gameObject.SetActive(true);
                resultSlot.GetComponent<Image>().sprite = recipeResults[i].GetComponent<Image>().sprite;
                resultSlot.Item = recipeResults[i];
            }
        }
    }

    public void OnClickSlot(Slot slot)
    {
        slot.Item = null;
        itemList[slot.index] = null;
        slot.gameObject.SetActive(false);
        CheckForCreatedRecipes();
        
    }
    public void OnMouseDownItem(Item item)
    {
        if (_currentItem == null)
        {
            _currentItem = item;
            CustomCursor.gameObject.SetActive(true);
            CustomCursor.sprite = _currentItem.GetComponent<Image>().sprite;
        }
    }
}*/