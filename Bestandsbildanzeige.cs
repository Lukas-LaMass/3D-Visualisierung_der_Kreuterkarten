//In diesem Skript werden die Bestandsbilder Straßen zugeordnet.

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Bestandsbildanzeige : MonoBehaviour
{
    public Transform playerCamera;
    public RawImage rawImage;
    public List<GameObjectTexturePair> objectTexturePairs = new List<GameObjectTexturePair>();

    [System.Serializable]
    public class GameObjectTexturePair
    {
        public GameObject gameObject;
        public Texture2D texture;
    }

    void Update()
    {
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            foreach (var pair in objectTexturePairs)
            {
                if (pair.gameObject == hitObject)
                {
                    rawImage.texture = pair.texture;
                    rawImage.enabled = true;
                    return;
                }
            }

            if (hitObject.name.Substring(0, 6) == "001alt")
            {
                rawImage.texture = objectTexturePairs[0].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "004bla")
            {
                rawImage.texture = objectTexturePairs[1].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "005amb")
            {
                rawImage.texture = objectTexturePairs[2].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "006bol")
            {
                rawImage.texture = objectTexturePairs[3].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "008bre")
            {
                rawImage.texture = objectTexturePairs[4].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "009auf")
            {
                rawImage.texture = objectTexturePairs[5].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "010bud")
            {
                rawImage.texture = objectTexturePairs[6].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "011bur")
            {
                rawImage.texture = objectTexturePairs[7].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "012but")
            {
                rawImage.texture = objectTexturePairs[8].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "013but")
            {
                rawImage.texture = objectTexturePairs[9].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "014caz")
            {
                rawImage.texture = objectTexturePairs[10].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "015dom")
            {
                rawImage.texture = objectTexturePairs[11].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "016ros")
            {
                rawImage.texture = objectTexturePairs[12].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "017ehr")
            {
                rawImage.texture = objectTexturePairs[13].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "018eig")
            {
                rawImage.texture = objectTexturePairs[14].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "020fet")
            {
                rawImage.texture = objectTexturePairs[15].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "021fil")
            {
                rawImage.texture = objectTexturePairs[16].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "022fle")
            {
                rawImage.texture = objectTexturePairs[17].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "023ger")
            {
                rawImage.texture = objectTexturePairs[18].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "024glo")
            {
                rawImage.texture = objectTexturePairs[19].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "025gol")
            {
                rawImage.texture = objectTexturePairs[20].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "026unt")
            {
                rawImage.texture = objectTexturePairs[21].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "027mom")
            {
                rawImage.texture = objectTexturePairs[22].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "028haf")
            {
                rawImage.texture = objectTexturePairs[23].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "029her")
            {
                rawImage.texture = objectTexturePairs[24].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "030heu")
            {
                rawImage.texture = objectTexturePairs[25].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "031amh")
            {
                rawImage.texture = objectTexturePairs[26].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "032hoh")
            {
                rawImage.texture = objectTexturePairs[27].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "033hoh")
            {
                rawImage.texture = objectTexturePairs[28].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "034hoh")
            {
                rawImage.texture = objectTexturePairs[29].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "035hoh")
            {
                rawImage.texture = objectTexturePairs[30].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "036hoh")
            {
                rawImage.texture = objectTexturePairs[31].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "037hoh")
            {
                rawImage.texture = objectTexturePairs[32].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "039joh")
            {
                rawImage.texture = objectTexturePairs[33].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "040unt")
            {
                rawImage.texture = objectTexturePairs[34].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "042ans")
            {
                rawImage.texture = objectTexturePairs[35].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "044kat")
            {
                rawImage.texture = objectTexturePairs[36].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "045col")
            {
                rawImage.texture = objectTexturePairs[37].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "046sch")
            {
                rawImage.texture = objectTexturePairs[38].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "047lac")
            {
                rawImage.texture = objectTexturePairs[39].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "048lac")
            {
                rawImage.texture = objectTexturePairs[40].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "049auf")
            {
                rawImage.texture = objectTexturePairs[41].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "050lin")
            {
                rawImage.texture = objectTexturePairs[42].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "051lun")
            {
                rawImage.texture = objectTexturePairs[43].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "052gro")
            {
                rawImage.texture = objectTexturePairs[44].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "054mar")
            {
                rawImage.texture = objectTexturePairs[45].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "055mar")
            {
                rawImage.texture = objectTexturePairs[46].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "056mar")
            {
                rawImage.texture = objectTexturePairs[47].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "057vor")
            {
                rawImage.texture = objectTexturePairs[48].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "058mar")
            {
                rawImage.texture = objectTexturePairs[49].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "059mat")
            {
                rawImage.texture = objectTexturePairs[50].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "061fis")
            {
                rawImage.texture = objectTexturePairs[51].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "062min")
            {
                rawImage.texture = objectTexturePairs[52].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "063muh")
            {
                rawImage.texture = objectTexturePairs[53].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "064muh")
            {
                rawImage.texture = objectTexturePairs[54].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "065neu")
            {
                rawImage.texture = objectTexturePairs[55].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "066neu")
            {
                rawImage.texture = objectTexturePairs[56].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "067neu")
            {
                rawImage.texture = objectTexturePairs[57].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "068neu")
            {
                rawImage.texture = objectTexturePairs[58].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "069pep")
            {
                rawImage.texture = objectTexturePairs[59].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "070per")
            {
                rawImage.texture = objectTexturePairs[60].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "071pet")
            {
                rawImage.texture = objectTexturePairs[61].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "072put")
            {
                rawImage.texture = objectTexturePairs[62].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "073and")
            {
                rawImage.texture = objectTexturePairs[63].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "074rhe")
            {
                rawImage.texture = objectTexturePairs[64].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "076rot")
            {
                rawImage.texture = objectTexturePairs[65].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "078sal")
            {
                rawImage.texture = objectTexturePairs[66].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "079san")
            {
                rawImage.texture = objectTexturePairs[67].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "080san")
            {
                rawImage.texture = objectTexturePairs[68].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "081san")
            {
                rawImage.texture = objectTexturePairs[69].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "082san")
            {
                rawImage.texture = objectTexturePairs[70].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "083sch")
            {
                rawImage.texture = objectTexturePairs[71].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "084sch")
            {
                rawImage.texture = objectTexturePairs[72].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "085unt")
            {
                rawImage.texture = objectTexturePairs[73].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "086sev")
            {
                rawImage.texture = objectTexturePairs[74].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "087sev")
            {
                rawImage.texture = objectTexturePairs[75].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "088vor")
            {
                rawImage.texture = objectTexturePairs[76].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "090ste")
            {
                rawImage.texture = objectTexturePairs[77].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "091ste")
            {
                rawImage.texture = objectTexturePairs[78].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "092sto")
            {
                rawImage.texture = objectTexturePairs[79].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "093unt")
            {
                rawImage.texture = objectTexturePairs[80].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "094dip")
            {
                rawImage.texture = objectTexturePairs[81].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "095tra")
            {
                rawImage.texture = objectTexturePairs[82].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "096amu")
            {
                rawImage.texture = objectTexturePairs[83].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "098auf")
            {
                rawImage.texture = objectTexturePairs[84].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "100wei")
            {
                rawImage.texture = objectTexturePairs[85].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "106mar")
            {
                rawImage.texture = objectTexturePairs[86].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "107unt")
            {
                rawImage.texture = objectTexturePairs[87].texture;
                rawImage.enabled = true;
                return;
            }
            if (hitObject.name.Substring(0, 6) == "108ste")
            {
                rawImage.texture = objectTexturePairs[88].texture;
                rawImage.enabled = true;
                return;
            }

            rawImage.enabled = false;
        }
        else
        {
            rawImage.enabled = false;
        }
    }
}