using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurufRule : MonoBehaviour
{
    public GameObject logoOperator;
    public int delaiOperator;
    public AudioSource mulai_awal;
    public AudioSource bertanya;
    public AudioSource benar;
    public AudioSource salah;
    public AudioSource SuaraA;
    public AudioSource SuaraB;
    public AudioSource SuaraC;
    public AudioSource SuaraD;
    public AudioSource SuaraE;
    public AudioSource SuaraF;
    public AudioSource SuaraG;
    public AudioSource SuaraH;
    public AudioSource SuaraI;
    public AudioSource SuaraJ;
    public AudioSource SuaraK;
    public AudioSource SuaraL;
    public AudioSource SuaraM;
    public AudioSource SuaraN;
    public AudioSource SuaraO;
    public AudioSource SuaraP;
    public AudioSource SuaraQ;
    public AudioSource SuaraR;
    public AudioSource SuaraS;
    public AudioSource SuaraT;
    public AudioSource SuaraU;
    public AudioSource SuaraV;
    public AudioSource SuaraW;
    public AudioSource SuaraX;
    public AudioSource SuaraY;
    public AudioSource SuaraZ;
    bool interaktive;
    char[] huruf;
    char tmp_huruf;
    int random_huruf;
    // Start is called before the first frame update
    void Start()
    {
        logoOperator.SetActive(false);
        StartCoroutine(Delai3(delaiOperator));
        random_huruf = 0;
        interaktive = false;
        huruf =new char[26];
        huruf[0] = 'a';
        huruf[1] = 'b';
        huruf[2] = 'c';
        huruf[3] = 'd';
        huruf[4] = 'e';
        huruf[5] = 'f';
        huruf[6] = 'g';
        huruf[7] = 'h';
        huruf[8] = 'i';
        huruf[9] = 'j';
        huruf[10] = 'k';
        huruf[11] = 'l';
        huruf[12] = 'm';
        huruf[13] = 'n';
        huruf[14] = 'o';
        huruf[15] = 'p';
        huruf[16] = 'q';
        huruf[17] = 'r';
        huruf[18] = 's';
        huruf[19] = 't';
        huruf[20] = 'u';
        huruf[21] = 'v';
        huruf[22] = 'w';
        huruf[23] = 'x';
        huruf[24] = 'y';
        huruf[25] = 'z';

    }
    IEnumerator Delai1(int delay1)
    {
        yield return new WaitForSeconds(delay1);
        if (interaktive)
        Bertanya_op();
    }
    IEnumerator Delai2(int nilai,int delay_me)
    {
        yield return new WaitForSeconds(delay_me);
        switch (nilai)
        {
            case 0:
                SuaraA.Play();
                break;
            case 1:
                SuaraB.Play();
                break;
            case 2:
                SuaraC.Play();
                break;
            case 3:
                SuaraD.Play();
                break;
            case 4:
                SuaraE.Play();
                break;
            case 5:
                SuaraF.Play();
                break;
            case 6:
                SuaraG.Play();
                break;
            case 7:
                SuaraH.Play();
                break;
            case 8:
                SuaraI.Play();
                break;
            case 9:
                SuaraJ.Play();
                break;
            case 10:
                SuaraK.Play();
                break;
            case 11:
                SuaraL.Play();
                break;
            case 12:
                SuaraM.Play();
                break;
            case 13:
                SuaraN.Play();
                break;
            case 14:
                SuaraO.Play();
                break;
            case 15:
                SuaraP.Play();
                break;
            case 16:
                SuaraQ.Play();
                break;
            case 17:
                SuaraR.Play();
                break;
            case 18:
                SuaraS.Play();
                break;
            case 19:
                SuaraT.Play();
                break;
            case 20:
                SuaraU.Play();
                break;
            case 21:
                SuaraV.Play();
                break;
            case 22:
                SuaraW.Play();
                break;
            case 23:
                SuaraX.Play();
                break;
            case 24:
                SuaraY.Play();
                break;
            case 25:
                SuaraZ.Play();
                break;
        }
    }
    IEnumerator Delai3(int delay1)
    {
        yield return new WaitForSeconds(delay1);
        logoOperator.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OperatorPower() {
        if (interaktive)
        {
            interaktive = false;
        }
        else if (interaktive == false) {
            interaktive = true;
            mulai_awal.Play();
            StartCoroutine(Delai1(5));
        }
    }
    void Bertanya_op() {
        random_huruf= Random.Range(0, 25);
        bertanya.Play();
        StartCoroutine(Delai2(random_huruf,2));

    }
    void TekanHuruf(int int_huruf) {
        if (int_huruf == random_huruf)
        {
            benar.Play();
            StartCoroutine(Delai2(random_huruf, 3));
            StartCoroutine(Delai1(5));

        }
        else {
            salah.Play();
            StartCoroutine(Delai2(int_huruf, 2));
        }

    }
    public void TekanA()
    {
        if (interaktive==false)
            SuaraA.Play();
        else TekanHuruf(0);
    }
    public void TekanB()
    {
        if (interaktive == false)
            SuaraB.Play();
        else TekanHuruf(1);
    }
    public void TekanC()
    {
        if (interaktive == false)
            SuaraC.Play();
        else TekanHuruf(2);
    }
    public void TekanD()
    {
        if (interaktive == false)
            SuaraD.Play();
        else TekanHuruf(3);
    }
    public void TekaND()
    {
        if (interaktive == false)
            SuaraD.Play();
        else TekanHuruf(3);
    }
    public void TekanE()
    {
        if (interaktive == false)
            SuaraE.Play();
        else TekanHuruf(4);
    }
    public void TekanF()
    {
        if (interaktive == false)
            SuaraF.Play();
        else TekanHuruf(5);
    }
    public void TekanG()
    {
        if (interaktive == false)
            SuaraG.Play();
        else TekanHuruf(6);
    }
    public void TekanH()
    {
        if (interaktive == false)
            SuaraH.Play();
        else TekanHuruf(7);
    }
    public void TekanI()
    {
        if (interaktive == false)
            SuaraI.Play();
        else TekanHuruf(8);
    }
    public void TekanJ()
    {
        if (interaktive == false)
            SuaraJ.Play();
        else TekanHuruf(9);
    }
    public void TekanK()
    {
        if (interaktive == false)
            SuaraK.Play();
        else TekanHuruf(10);
    }
    public void TekanL()
    {
        if (interaktive == false)
            SuaraL.Play();
        else TekanHuruf(11);
    }
    public void TekanM()
    {
        if (interaktive == false)
            SuaraM.Play();
        else TekanHuruf(12);
    }
    public void TekanN()
    {
        if (interaktive == false)
            SuaraN.Play();
        else TekanHuruf(13);
    }
    public void TekanO()
    {
        if (interaktive == false)
            SuaraO.Play();
        else TekanHuruf(14);
    }
    public void TekanP()
    {
        if (interaktive == false)
            SuaraP.Play();
        else TekanHuruf(15);
    }
    public void TekanQ()
    {
        if (interaktive == false)
            SuaraQ.Play();
        else TekanHuruf(16);
    }
    public void TekanR()
    {
        if (interaktive == false)
            SuaraR.Play();
        else TekanHuruf(17);
    }
    public void TekanS()
    {
        if (interaktive == false)
            SuaraS.Play();
        else TekanHuruf(18);
    }
    public void TekanT()
    {
        if (interaktive == false)
            SuaraT.Play();
        else TekanHuruf(19);
    }
    public void TekanU()
    {
        if (interaktive == false)
            SuaraU.Play();
        else TekanHuruf(20);
    }
    public void TekanV()
    {
        if (interaktive == false)
            SuaraV.Play();
        else TekanHuruf(21);
    }
    public void TekanW()
    {
        if (interaktive == false)
            SuaraW.Play();
        else TekanHuruf(22);
    }
    public void TekanX()
    {
        if (interaktive == false)
            SuaraX.Play();
        else TekanHuruf(23);
    }
    public void TekanY()
    {
        if (interaktive == false)
            SuaraY.Play();
        else TekanHuruf(24);
    }
    public void TekanZ()
    {
        if (interaktive == false)
            SuaraZ.Play();
        else TekanHuruf(25);
    }
    

}
