//In diesem Skript werden die einzelnen Punkte des Spawnmenüs mit den jeweiligen Spawnpoints verknüpft.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnDropdown : MonoBehaviour
{
    public GameObject Visitor;
    public GameObject sp_001alt;
    public GameObject sp_004bla;
    public GameObject sp_005amb;
    public GameObject sp_006bol;
    public GameObject sp_008bre;
    public GameObject sp_009auf;
    public GameObject sp_010bud;
    public GameObject sp_011bur;
    public GameObject sp_012but;
    public GameObject sp_013but;
    public GameObject sp_014caz;
    public GameObject sp_015dom;
    public GameObject sp_016ros;
    public GameObject sp_017ehr;
    public GameObject sp_018eig;
    public GameObject sp_020fet;
    public GameObject sp_021fil;
    public GameObject sp_022fle;
    public GameObject sp_023ger;
    public GameObject sp_024glo;
    public GameObject sp_025gol;
    public GameObject sp_026unt;
    public GameObject sp_027mom;
    public GameObject sp_028haf;
    public GameObject sp_029her;
    public GameObject sp_030heu;
    public GameObject sp_031amh;
    public GameObject sp_032hoh;
    public GameObject sp_033hoh;
    public GameObject sp_034hoh;
    public GameObject sp_035hoh;
    public GameObject sp_036hoh;
    public GameObject sp_037hoh;
    public GameObject sp_039joh;
    public GameObject sp_040unt;
    public GameObject sp_042ans;
    public GameObject sp_044kat;
    public GameObject sp_045col;
    public GameObject sp_046sch;
    public GameObject sp_047lac;
    public GameObject sp_048lac;
    public GameObject sp_049auf;
    public GameObject sp_050lin;
    public GameObject sp_051lun;
    public GameObject sp_052gro;
    public GameObject sp_054mar;
    public GameObject sp_055mar;
    public GameObject sp_056mar;
    public GameObject sp_057vor;
    public GameObject sp_058mar;
    public GameObject sp_059mat;
    public GameObject sp_061fis;
    public GameObject sp_062min;
    public GameObject sp_063muh;
    public GameObject sp_064muh;
    public GameObject sp_065neu;
    public GameObject sp_066neu;
    public GameObject sp_067neu;
    public GameObject sp_068neu;
    public GameObject sp_069pep;
    public GameObject sp_070per;
    public GameObject sp_071pet;
    public GameObject sp_072put;
    public GameObject sp_073and;
    public GameObject sp_074rhe;
    public GameObject sp_076rot;
    public GameObject sp_078sal;
    public GameObject sp_079sun;
    public GameObject sp_080san;
    public GameObject sp_081san;
    public GameObject sp_082san;
    public GameObject sp_083sch;
    public GameObject sp_084sch;
    public GameObject sp_085unt;
    public GameObject sp_086sev;
    public GameObject sp_087sev;
    public GameObject sp_088vor;
    public GameObject sp_090ste;
    public GameObject sp_091ste;
    public GameObject sp_092sto;
    public GameObject sp_093unt;
    public GameObject sp_094dip;
    public GameObject sp_095tra;
    public GameObject sp_096amu;
    public GameObject sp_098auf;
    public GameObject sp_100wei;
    public GameObject sp_106mar;
    public GameObject sp_107unt;
    public GameObject sp_108ste;
    public int index;

    void Start()
    {
        var dropdown = transform.GetComponent<TMP_Dropdown>();
        dropdown.options.Clear();

        List<string> points = new List<string>();
            points.Add("Alter Markt (Nr. 1)");
            points.Add("Blaubach (Nr. 4)");
            points.Add("Am Bollwerk (Nr. 5)");
            points.Add("Boltzengasse (Nr. 6)");
            points.Add("Breite Straße (Nr. 8I, II und III)");
            points.Add("Auf den Brücken (Nr. 9)");
            points.Add("Budengasse (Nr. 10)");
            points.Add("Bürgerstraße (Nr. 11)");
            points.Add("Büttgasse (Nr. 12)");
            points.Add("Buttergasse (Nr. 13)");
            points.Add("Caezilienstraße (Nr. 14)");
            points.Add("Dominikaner (Nr. 15)");
            points.Add("Rosengasse (Nr. 16)");
            points.Add("Ehrenstraße (Nr. 17)");
            points.Add("Eigelstein (Nr. 18)");
            points.Add("Fettenhenne (Nr. 20)");
            points.Add("Filzengraben (Nr. 21)");
            points.Add("Fleischmengergasse (Nr. 22)");
            points.Add("Gereonstraße (Nr. 23)");
            points.Add("Glockengasse (Nr. 25)");
            points.Add("Goldgasse (Nr. 26)");
            points.Add("Unter Gottes Gnaden (Nr. 27)");
            points.Add("Mommersloch (Nr. 27)");
            points.Add("Hafengasse (Nr. 28)");
            points.Add("Herzogstraße (Nr. 29)");
            points.Add("Heumarkt (Nr. 30)");
            points.Add("am Hof (Nr. 31)");
            points.Add("Hohepforte (Nr. 32)");
            points.Add("Hohe Straße (Nr. 33)");
            points.Add("Hohe Straße (Nr. 34)");
            points.Add("Hohe Straße (Nr. 35)");
            points.Add("Hohe Straße (Nr. 36)");
            points.Add("Hohe Straße (Nr. 37)");
            points.Add("Johannisstraße (Nr. 39)");
            points.Add("Unter Käster (Nr. 40)");
            points.Add("An St. Katharinen (Nr. 42)");
            points.Add("Katzenbüchel (Nr. 44)");
            points.Add("Columba (Nr. 45)");
            points.Add("Schmierstraße (Nr. 46)");
            points.Add("Lach (Nr. 47)");
            points.Add("Lach (Nr. 48)");
            points.Add("Aufm Lichhof (Nr. 49)");
            points.Add("Linkgasse (Nr. 50)");
            points.Add("Lungengasse (Nr. 51)");
            points.Add("Großer Malzbüchel (Nr. 52)");
            points.Add("Marien-Malzbüchel (Nr. 54)");
            points.Add("Markmansgasse (Nr. 55)");
            points.Add("Marspforten (Nr. 56)");
            points.Add("Vor St. Martin (Nr. 57)");
            points.Add("Martinstraße (Nr. 58)");
            points.Add("Mathäusstraße (Nr. 59)");
            points.Add("Fischmarkt (Nr. 61)");
            points.Add("Minoritenstraße (Nr. 62)");
            points.Add("Mühlenbach (Nr. 63)");
            points.Add("Mühlengasse (Nr. 64)");
            points.Add("Neugasse (Nr. 65)");
            points.Add("Neumarkt (Nr. 66)");
            points.Add("Neumarkt (Nr. 67)");
            points.Add("Neumarkt (Nr. 68)");
            points.Add("Pepinstraße (Nr. 69)");
            points.Add("Perlengraben (Nr. 70)");
            points.Add("Peterstraße (Nr. 71)");
            points.Add("Pützgasse (Nr. 72)");
            points.Add("An der Rechtsschule (Nr. 73)");
            points.Add("Rheingasse (Nr. 74)");
            points.Add("Rothgerberbach (Nr. 76)");
            points.Add("Salzgasse (Nr. 78)");
            points.Add("Sandbahn (Nr. 79)");
            points.Add("Sandkaul (Nr. 80)");
            points.Add("Sandkaul (Nr. 81)");
            points.Add("Sandkaul (Nr. 82)");
            points.Add("Schildergasse (Nr. 83)");
            points.Add("Schwertnergasse (Nr. 84)");
            points.Add("unter Seidmacher (Nr. 85)");
            points.Add("Severinstraße (Nr. 86)");
            points.Add("Severinstraße (Nr. 87)");
            points.Add("Vor den Siebenburgen (Nr. 88)");
            points.Add("Steinweg (Nr. 90)");
            points.Add("Sternengasse (Nr. 91)");
            points.Add("Stolkgasse (Nr. 92)");
            points.Add("Unter Taschenmacher (Nr. 93)");
            points.Add("Dipoltsgasse (Nr. 94)");
            points.Add("Trankgasse (Nr. 95)");
            points.Add("Am Ufer (Nr. 96)");
            points.Add("auf dem Waidmarkt (Nr. 98)");
            points.Add("Weidenbach (Nr. 100)");
            points.Add("Marzellenstraße (Nr. 106)");
            points.Add("Unter Goldschmied (Nr. 107)");
            points.Add("Sternengasse (Nr. 108)");

        foreach(var point in points)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = point });
        }
        DropdownValueChanged(dropdown);
        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(dropdown); });
    }

    void Update()
    {

    }

    public void DropdownValueChanged(TMP_Dropdown dropdown)
    {
        index = dropdown.value;
        switch (index)
        {
            case 0:Visitor.gameObject.transform.position = sp_001alt.gameObject.transform.position;break;
            case 1:Visitor.gameObject.transform.position = sp_004bla.gameObject.transform.position;break;
            case 2:Visitor.gameObject.transform.position = sp_005amb.gameObject.transform.position;break;
            case 3:Visitor.gameObject.transform.position = sp_006bol.gameObject.transform.position;break;
            case 4:Visitor.gameObject.transform.position = sp_008bre.gameObject.transform.position;break;
            case 5:Visitor.gameObject.transform.position = sp_009auf.gameObject.transform.position;break;
            case 6:Visitor.gameObject.transform.position = sp_010bud.gameObject.transform.position;break;
            case 7:Visitor.gameObject.transform.position = sp_011bur.gameObject.transform.position;break;
            case 8:Visitor.gameObject.transform.position = sp_012but.gameObject.transform.position;break;
            case 9:Visitor.gameObject.transform.position = sp_013but.gameObject.transform.position;break;
            case 10:Visitor.gameObject.transform.position = sp_014caz.gameObject.transform.position;break;
            case 11:Visitor.gameObject.transform.position = sp_015dom.gameObject.transform.position;break;
            case 12:Visitor.gameObject.transform.position = sp_016ros.gameObject.transform.position;break;
            case 13:Visitor.gameObject.transform.position = sp_017ehr.gameObject.transform.position;break;
            case 14:Visitor.gameObject.transform.position = sp_018eig.gameObject.transform.position;break;
            case 15:Visitor.gameObject.transform.position = sp_020fet.gameObject.transform.position;break;
            case 16:Visitor.gameObject.transform.position = sp_021fil.gameObject.transform.position;break;
            case 17:Visitor.gameObject.transform.position = sp_022fle.gameObject.transform.position;break;
            case 18:Visitor.gameObject.transform.position = sp_023ger.gameObject.transform.position;break;
            case 19:Visitor.gameObject.transform.position = sp_024glo.gameObject.transform.position;break;
            case 20:Visitor.gameObject.transform.position = sp_025gol.gameObject.transform.position;break;
            case 21:Visitor.gameObject.transform.position = sp_026unt.gameObject.transform.position;break;
            case 22:Visitor.gameObject.transform.position = sp_027mom.gameObject.transform.position;break;
            case 23:Visitor.gameObject.transform.position = sp_028haf.gameObject.transform.position;break;
            case 24:Visitor.gameObject.transform.position = sp_029her.gameObject.transform.position;break;
            case 25:Visitor.gameObject.transform.position = sp_030heu.gameObject.transform.position;break;
            case 26:Visitor.gameObject.transform.position = sp_031amh.gameObject.transform.position;break;
            case 27:Visitor.gameObject.transform.position = sp_032hoh.gameObject.transform.position;break;
            case 28:Visitor.gameObject.transform.position = sp_033hoh.gameObject.transform.position;break;
            case 29:Visitor.gameObject.transform.position = sp_034hoh.gameObject.transform.position;break;
            case 30:Visitor.gameObject.transform.position = sp_035hoh.gameObject.transform.position;break;
            case 31:Visitor.gameObject.transform.position = sp_036hoh.gameObject.transform.position;break;
            case 32:Visitor.gameObject.transform.position = sp_037hoh.gameObject.transform.position;break;
            case 33:Visitor.gameObject.transform.position = sp_039joh.gameObject.transform.position;break;
            case 34:Visitor.gameObject.transform.position = sp_040unt.gameObject.transform.position;break;
            case 35:Visitor.gameObject.transform.position = sp_042ans.gameObject.transform.position;break;
            case 36:Visitor.gameObject.transform.position = sp_044kat.gameObject.transform.position;break;
            case 37:Visitor.gameObject.transform.position = sp_045col.gameObject.transform.position;break;
            case 38:Visitor.gameObject.transform.position = sp_046sch.gameObject.transform.position;break;
            case 39:Visitor.gameObject.transform.position = sp_047lac.gameObject.transform.position;break;
            case 40:Visitor.gameObject.transform.position = sp_048lac.gameObject.transform.position;break;
            case 41:Visitor.gameObject.transform.position = sp_049auf.gameObject.transform.position;break;
            case 42:Visitor.gameObject.transform.position = sp_050lin.gameObject.transform.position;break;
            case 43:Visitor.gameObject.transform.position = sp_051lun.gameObject.transform.position;break;
            case 44:Visitor.gameObject.transform.position = sp_052gro.gameObject.transform.position;break;
            case 45:Visitor.gameObject.transform.position = sp_054mar.gameObject.transform.position;break;
            case 46:Visitor.gameObject.transform.position = sp_055mar.gameObject.transform.position;break;
            case 47:Visitor.gameObject.transform.position = sp_056mar.gameObject.transform.position;break;
            case 48:Visitor.gameObject.transform.position = sp_057vor.gameObject.transform.position;break;
            case 49:Visitor.gameObject.transform.position = sp_058mar.gameObject.transform.position;break;
            case 50:Visitor.gameObject.transform.position = sp_059mat.gameObject.transform.position;break;
            case 51:Visitor.gameObject.transform.position = sp_061fis.gameObject.transform.position;break;
            case 52:Visitor.gameObject.transform.position = sp_062min.gameObject.transform.position;break;
            case 53:Visitor.gameObject.transform.position = sp_063muh.gameObject.transform.position;break;
            case 54:Visitor.gameObject.transform.position = sp_064muh.gameObject.transform.position;break;
            case 55:Visitor.gameObject.transform.position = sp_065neu.gameObject.transform.position;break;
            case 56:Visitor.gameObject.transform.position = sp_066neu.gameObject.transform.position;break;
            case 57:Visitor.gameObject.transform.position = sp_067neu.gameObject.transform.position;break;
            case 58:Visitor.gameObject.transform.position = sp_068neu.gameObject.transform.position;break;
            case 59:Visitor.gameObject.transform.position = sp_069pep.gameObject.transform.position;break;
            case 60:Visitor.gameObject.transform.position = sp_070per.gameObject.transform.position;break;
            case 61:Visitor.gameObject.transform.position = sp_071pet.gameObject.transform.position;break;
            case 62:Visitor.gameObject.transform.position = sp_072put.gameObject.transform.position;break;
            case 63:Visitor.gameObject.transform.position = sp_073and.gameObject.transform.position;break;
            case 64:Visitor.gameObject.transform.position = sp_074rhe.gameObject.transform.position;break;
            case 65:Visitor.gameObject.transform.position = sp_076rot.gameObject.transform.position;break;
            case 66:Visitor.gameObject.transform.position = sp_078sal.gameObject.transform.position;break;
            case 67:Visitor.gameObject.transform.position = sp_079sun.gameObject.transform.position;break;
            case 68:Visitor.gameObject.transform.position = sp_080san.gameObject.transform.position;break;
            case 69:Visitor.gameObject.transform.position = sp_081san.gameObject.transform.position;break;
            case 70:Visitor.gameObject.transform.position = sp_082san.gameObject.transform.position;break;
            case 71:Visitor.gameObject.transform.position = sp_083sch.gameObject.transform.position;break;
            case 72:Visitor.gameObject.transform.position = sp_084sch.gameObject.transform.position;break;
            case 73:Visitor.gameObject.transform.position = sp_085unt.gameObject.transform.position;break;
            case 74:Visitor.gameObject.transform.position = sp_086sev.gameObject.transform.position;break;
            case 75:Visitor.gameObject.transform.position = sp_087sev.gameObject.transform.position;break;
            case 76:Visitor.gameObject.transform.position = sp_088vor.gameObject.transform.position;break;
            case 77:Visitor.gameObject.transform.position = sp_090ste.gameObject.transform.position;break;
            case 78:Visitor.gameObject.transform.position = sp_091ste.gameObject.transform.position;break;
            case 79:Visitor.gameObject.transform.position = sp_092sto.gameObject.transform.position;break;
            case 80:Visitor.gameObject.transform.position = sp_093unt.gameObject.transform.position;break;
            case 81:Visitor.gameObject.transform.position = sp_094dip.gameObject.transform.position;break;
            case 82:Visitor.gameObject.transform.position = sp_095tra.gameObject.transform.position;break;
            case 83:Visitor.gameObject.transform.position = sp_096amu.gameObject.transform.position;break;
            case 84:Visitor.gameObject.transform.position = sp_098auf.gameObject.transform.position;break;
            case 85:Visitor.gameObject.transform.position = sp_100wei.gameObject.transform.position;break;
            case 86:Visitor.gameObject.transform.position = sp_106mar.gameObject.transform.position;break;
            case 87:Visitor.gameObject.transform.position = sp_107unt.gameObject.transform.position;break;
            case 88:Visitor.gameObject.transform.position = sp_108ste.gameObject.transform.position;break;
        }
    }
}
