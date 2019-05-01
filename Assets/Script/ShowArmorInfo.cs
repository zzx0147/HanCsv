using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowArmorInfo : MonoBehaviour {

    public Image img;
    public Text S_name;
    public Text Reqire_Level;
    public Text S_HP;
    public Text S_Def;
    public Text S_Will;
    public Text S_Str;
    public Text S_Dex;

    public void Show(Armor armor)
    {
        img.sprite = armor.M_Image_File;
        S_name.text = "이름 : " + armor.M_Name;
        Reqire_Level.text = "필요 레벨 : " + armor.M_Require_Level.ToString();
        S_HP.text = "체력 : " + armor.M_S_HP.ToString();
        S_Def.text = "방어력 : " + armor.M_S_Def.ToString();
        S_Will.text = "강인함 : " + armor.M_S_Will.ToString();
        S_Str.text = "힘 : " + armor.M_S_Str.ToString();
        S_Dex.text = "민첩 : " + armor.M_S_Dex.ToString();
    }
}
