using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;

public class KaraMezarl�k : MonoBehaviour
{
    [SerializeField] GameObject interactionIndicator;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] Button option1Button;
    [SerializeField] Button option2Button;
    [SerializeField] Button option3Button;

    private bool isPlayerNear = false;
    private int dialogueStage = 0;

    void Start()
    {
        interactionIndicator.SetActive(false);
        dialoguePanel.SetActive(false);


        option1Button.onClick.AddListener(() => PlayerChoiceKara(1));
        option2Button.onClick.AddListener(() => PlayerChoiceKara(2));
        option3Button.onClick.AddListener(() => PlayerChoiceKara(3));
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            interactionIndicator.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            interactionIndicator.SetActive(false);
            dialoguePanel.SetActive(false);
        }
    }

    public void ShowDialogue()
    {
        interactionIndicator.SetActive(false);
        dialoguePanel.SetActive(true);
        if (dialogueStage == 0)
        {
            option1Button.GetComponentInChildren<TMP_Text>().text = "Meri�in i� yerine neden d�nd���n� biliyor musun?";
            option2Button.GetComponentInChildren<TMP_Text>().text = "Sence Meri�'in d��man� olabilir mi?";
            option3Button.GetComponentInChildren<TMP_Text>().text = "O gece garip bir �ey fark ettin mi?";
        }
    }

    void PlayerChoiceKara(int choice)
    {
        if (dialogueStage == 0)
        {
            if (choice == 1)
            {
                dialogueText.text = "Bak, ben de bilmiyorum, ama Meri�in bir derdi oldu�unu sezmi�tim. O gece neden i� yerine d�nd���n� kimse anlamad�. Belki bir �eyini unuttu diye d���nd�k ama... Tekir, sen de bilirsin, o saatte merkezde bulunmak tehlikelidir.\r\n";
                option1Button.GetComponentInChildren<TMP_Text>().text = "Tehlikeli mi? Ne demek istiyorsun?";
                option3Button.gameObject.SetActive(false);
                option2Button.gameObject.SetActive(false);

            }
            else if (choice == 2)
            {
               dialogueText.text = "Bazen duydu�u bir isim hakk�nda endi�elendi�ini biliyorum, ama kim oldu�unu asla s�ylemedi. Tekir, belki ona yeterince yak�n olsayd�k bunu ��renebilirdik, ama o bu s�rlar� kendiyle g�t�rd�.\r\n";
                option2Button.GetComponentInChildren<TMP_Text>().text = "Peki ya son zamanlarda, ��phe duydu�u biri var m�yd�? Ya da ona zarar vermek isteyen?\r\n";
                option1Button.gameObject.SetActive(false);
                option3Button.gameObject.SetActive(false);
            }
            else if (choice == 3)
            {
                dialogueText.text = "Belki... i�in i�inde ba�ka kediler de vard�. Bu konuda �ok soru sorma, Tekir. Bu mesele ne kadar kurcalan�rsa ba��m�za bela olabilir.\r\n";
                option3Button.GetComponentInChildren<TMP_Text>().text = "Kara, ba��m�za bela olmas�ndan korkacak m�y�z? Meri�i kaybettik. Ger�ek ne olursa olsun, ben ��renmek zorunday�m.\r\n";
                option1Button.gameObject.SetActive(false);
                option2Button.gameObject.SetActive(false);
            }

            // Yeni se�enekleri g�ster
            //option1Button.GetComponentInChildren<TMP_Text>().text = "Tehlikeli mi? Ne demek istiyorsun?";
            //option2Button.GetComponentInChildren<TMP_Text>().text = "Peki ya son zamanlarda, ��phe duydu�u biri var m�yd�? Ya da ona zarar vermek isteyen?\r\n";
            //option3Button.GetComponentInChildren<TMP_Text>().text = "Kara, ba��m�za bela olmas�ndan korkacak m�y�z? Meri�i kaybettik. Ger�ek ne olursa olsun, ben ��renmek zorunday�m.\r\n";
            dialogueStage = 1;
        }
        else if (dialogueStage == 1)
        {
            if (choice == 1)
            {
                dialogueText.text = "Bir kedi o saatte yaln�z kalmaktan ho�lanmaz, ama Meri� geri d�nd�. Kimseyle payla�mad��� bir �ey mi vard� bilmiyorum. Belki de sana anlat�rd�� ama art�k onu bilemeyece�iz.\r\n";
                
                
                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri�in i� yerine neden d�nd���n� biliyor musun?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "Sence Meri�'in d��man� olabilir mi?�";
                option3Button.GetComponentInChildren<TMP_Text>().text = "O gece garip bir �ey fark ettin mi?";
                
                
                option1Button.gameObject.SetActive(true);
                option2Button.gameObject.SetActive(true);
                option3Button.gameObject.SetActive(true);
            }
            else if (choice == 2)
            {
                dialogueText.text = "Meri�'in d��man�? Bilmem, Tekir. Meri� d��man kazanacak bir kedi de�ildi, ama bazen ge�mi�inden gelen sorunlarla bo�u�urdu. Bu da onun durgun ve d���nceli g�r�nmesine neden olurdu.\r\n";
                
                
                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri�in i� yerine neden d�nd���n� biliyor musun?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "Sence Meri�'in d��man� olabilir mi?�";
                option3Button.GetComponentInChildren<TMP_Text>().text = "O gece garip bir �ey fark ettin mi?";


                option1Button.gameObject.SetActive(true);
                option2Button.gameObject.SetActive(true);
                option3Button.gameObject.SetActive(true);
            }
            else if (choice == 3)
            {
                dialogueText.text = "O gece, birka� kez i� yerinin ���klar�n�n a��l�p kapand���n� duydum. Belki orada de�ildim ama g�z�mden bir �ey ka�maz. Anlad�n m�?\r\n";
                

                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri�in i� yerine neden d�nd���n� biliyor musun?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "Sence Meri�'in d��man� olabilir mi?�";
                option3Button.GetComponentInChildren<TMP_Text>().text = "O gece garip bir �ey fark ettin mi?";


                option1Button.gameObject.SetActive(true);
                option2Button.gameObject.SetActive(true);
                option3Button.gameObject.SetActive(true);
            }

            dialogueStage = 0;

            //option1Button.gameObject.SetActive(false);
            //option2Button.gameObject.SetActive(false);
            //option3Button.gameObject.SetActive(false);


            //StartCoroutine(CloseDialogueAfterDelay(3f));
        }
    }

    //IEnumerator CloseDialogueAfterDelay(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    dialoguePanel.SetActive(false);
    //    option1Button.gameObject.SetActive(true);
    //    option2Button.gameObject.SetActive(true);
    //    dialogueStage = 0;
    //}

}
