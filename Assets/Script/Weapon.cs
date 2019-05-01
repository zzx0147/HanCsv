using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

    public enum WeaponAttribute
    {
        Image_File = 1,
        ID = 2,
        Name = 3,
        Require_Level = 4,
        S_Dmg = 5,
        S_Str = 6,
        S_Dex = 7,
        S_Agi = 8,
        Cri = 9,
        CriDmg = 10
    }

    public Weapon(int m_ID, string m_Name, int m_Require_Level, string imagePath, int m_S_Dmg, int m_S_Agi, int m_S_Cri, int m_S_CriDmg, int m_S_Str, int m_S_Dex)
    :base(m_ID,m_Name,m_Require_Level, imagePath)
    {
        M_S_Dmg = m_S_Dmg;
        M_S_Agi = m_S_Agi;
        M_S_Cri = m_S_Cri;
        M_S_CriDmg = m_S_CriDmg;
        M_S_Str = m_S_Str;
        M_S_Dex = m_S_Dex;
    }

    public int M_S_Dmg { get; set; }
    public int M_S_Agi { get; set; }
    public int M_S_Cri { get; set; }
    public int M_S_CriDmg { get; set; }
    public int M_S_Str { get; set; }
    public int M_S_Dex { get; set; }
}
