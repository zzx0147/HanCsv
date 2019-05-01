using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfoDictionary : MonoBehaviour {
    public static Dictionary<int, Armor> ArmorDictionary = new Dictionary<int, Armor>();
    public static Dictionary<int, Weapon> WeaponDictionary = new Dictionary<int, Weapon>(); 
    //public static Dictionary<int, Item>

    public static void Activate()
    {   

    }

    static ItemInfoDictionary()
    {
        string[,] ArmorArray = CsvLoader.LoadCsvBy2DimensionArray("Csv/DataTable_Item_CK_Armor");
        string[,] WeaponArray = CsvLoader.LoadCsvBy2DimensionArray("Csv/DataTable_Item_CK_Weapon");

        for(int i = 2; i < WeaponArray.GetLength(0);++i)
        {
            Weapon temp = new Weapon(
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.ID)]),
                          WeaponArray[i, (int)(Weapon.WeaponAttribute.Name)],
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.Require_Level)]),
                          WeaponArray[i, (int)(Weapon.WeaponAttribute.Image_File)],
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.S_Dmg)]),
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.S_Agi)]),
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.Cri)]),
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.CriDmg)]),
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.S_Str)]),
                int.Parse(WeaponArray[i, (int)(Weapon.WeaponAttribute.S_Dex)])
                );
            WeaponDictionary.Add(temp.M_ID, temp);
        }

        for(int i = 2;i < ArmorArray.GetLength(0);++i)
        {
            Armor temp = new Armor(
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.ID)]),
                          ArmorArray[i, (int)(Armor.ArmorAttribute.Name)],
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.Require_Level)]),
                          ArmorArray[i, (int)(Armor.ArmorAttribute.Image_File)],
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.S_HP)]),
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.S_Def)]),
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.S_Will)]),
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.S_Str)]),
                int.Parse(ArmorArray[i, (int)(Armor.ArmorAttribute.S_Dex)])
                );

            ArmorDictionary.Add(temp.M_ID, temp);
        }

    }
}
