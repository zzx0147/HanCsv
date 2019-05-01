using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBoxOpener : MonoBehaviour {

    public Image ItemBoxImage;
    public ShowArmorInfo showArmorInfo;
    public ShowWeaponInfo showWeaponInfo;
    private bool flipflop = true;

    public void PushButton()
    {
        if(flipflop)
        {
            GetComponentInChildren<Text>().text = "ReOpen";
            OpenBox(); 
        }
        else
        {
            GetComponentInChildren<Text>().text = "Open";
            ReOpenBox();
        }
        flipflop = !flipflop;
    }

	public void OpenBox()
    {
        Debug.Log("openBox");
        ItemBoxImage.gameObject.SetActive(false);
        int itemMax = ItemInfoDictionary.ArmorDictionary.Count + ItemInfoDictionary.WeaponDictionary.Count;

        int itemcode = Random.Range(0, itemMax);
        Debug.Log(itemcode+"max : " + itemMax);
        //아머가 나옴
        if(itemcode < ItemInfoDictionary.ArmorDictionary.Count)
        {
            showArmorInfo.gameObject.SetActive(true);
            Armor temp;
            bool result = ItemInfoDictionary.ArmorDictionary.TryGetValue(itemcode + 1, out temp);
            if (!result)
            {
                Debug.LogError("Error");
            }

            showArmorInfo.Show(temp);
        }
        //무기가 나옴
        else
        {
            showWeaponInfo.gameObject.SetActive(true);
            Weapon temp;
            ItemInfoDictionary.WeaponDictionary.TryGetValue(itemcode - ItemInfoDictionary.ArmorDictionary.Count + 1, out temp);
            showWeaponInfo.Show(temp);
        }
    }

    public void ReOpenBox()
    {
        showArmorInfo.gameObject.SetActive(false);
        showWeaponInfo.gameObject.SetActive(false);
        ItemBoxImage.gameObject.SetActive(true);
    }
}
