using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//아이템 기본 정보 클래스
public class Item {

    public int M_ID { get; set; }               //아이템 아이디
    public string M_Name { get; set; }          //아이템 이름(한글)
    public int M_Require_Level { get; set; }    //필요 레벨

    public Sprite M_Image_File { get; set; }     //아이템 이미지 파일

    //생성자, 이미지 파일의 경우 패스를 입력받아 로드한다
    public Item(int m_ID, string m_Name, int m_Require_Level, string imagePath)
    {
        M_ID = m_ID;
        M_Name = m_Name;
        M_Require_Level = m_Require_Level;
        M_Image_File = Resources.Load<Sprite>("Image/"+imagePath);

    }
}