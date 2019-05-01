using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWeaponInfo : MonoBehaviour {
    public Image img;
    public Text S_name;
    public Text Require_Level;
    public Text S_Dmg;
    public Text S_Str;
    public Text S_Dex;
    public Text S_Agi;
    public Text Cri;
    public Text CriDmg;
    public void Show(Weapon weapon)
    {
        img.sprite = weapon.M_Image_File;
        S_name.text = "이름 : "+weapon.M_Name;
        Require_Level.text = "필요 레벨 : " + weapon.M_Require_Level.ToString();
        S_Dmg.text = "공격력 : " + weapon.M_S_Dmg.ToString();
        S_Str.text = "힘 : " + weapon.M_S_Str.ToString();
        S_Dex.text = "민첩 : " + weapon.M_S_Dex.ToString();
        S_Agi.text = "공격속도 : " + weapon.M_S_Agi.ToString();
        Cri.text = "크리티컬 확률 : " + weapon.M_S_Cri.ToString();
        CriDmg.text = "크리티컬 데미지 : " + weapon.M_S_CriDmg.ToString();
    }
}
