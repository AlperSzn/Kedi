using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MinaSokak : MonoBehaviour
{
    [SerializeField] GameObject interactionIndicator;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] GameObject uygarPanel;
    [SerializeField] GameObject uygarText;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] Button option1Button;
    [SerializeField] Button option2Button;
    [SerializeField] Button option3Button;

    private bool isPlayerNear = false;
    private int dialogueStage = 0;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }
    void Start()
    {
        interactionIndicator.SetActive(false);
        dialoguePanel.SetActive(false);


        option1Button.onClick.AddListener(() => PlayerChoiceMina(1));
        option2Button.onClick.AddListener(() => PlayerChoiceMina(2));
        option3Button.onClick.AddListener(() => PlayerChoiceMina(3));
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
        dialogueText.text = "Tekir: Mina, Meri�in �l�m�yle ilgili baz� sorular�m var. Onu en iyi tan�yanlardan birisin, bu konuda bana yard�mc� olabilir misin?\r\n" +
            "Mina: (H�z�nl� bir ifadeyle) Tabii ki, Tekir. Bu durumda elimden ne gelirse yapar�m� Meri� hak etti�i �ekilde an�lmal�.";
        if (dialogueStage == 0)
        {
            option1Button.GetComponentInChildren<TMP_Text>().text = "Son zamanlarda Meri�in garip davrand���n� fark ettin mi?";
            option2Button.GetComponentInChildren<TMP_Text>().text = "Meri�in d��man� olabilecek biri var m�yd�?";
            option3Button.GetComponentInChildren<TMP_Text>().text = "Meri�in �zel bir �eyini biliyor musun? G�nl�k gibi bir �ey tuttu�unu fark ettin mi?";
        }
        
    }

    void PlayerChoiceMina(int choice)
    {
        if (dialogueStage == 0)
        {
            if (choice == 1)
            {
                dialogueText.text = "�imdi d���n�nce, evet... Son haftalarda biraz dalg�nd�. Ama bana bir �ey anlatmad�. Belki i� stresi... �ok s�k g�r��emiyorduk, ama bir �eylerin onu rahats�z etti�i belliydi.\r\n";
                

            }
            else if (choice == 2)
            {
                dialogueText.text = "Meri� genelde insanlarla iyi ge�inirdi. Ama son zamanlarda bir telefon konu�mas�na denk geldim. Birine sinirli bir �ekilde ba��r�yordu, ama kim oldu�unu bilmiyorum. Ondan sonra sessizle�mi�ti� Belki bu �nemli bir �eydir. Belki Uygar bir �ey biliyordur Meri�'le uzun zamand�r arkada�lar.";
                uygarPanel.SetActive(true);
                uygarText.SetActive(true);

            }
            else if (choice == 3)
            {
                dialogueText.text = "Asl�nda� Evet. �ok sevdi�i k���k bir not defteri vard�. �o�u zaman yan�nda ta��d���n� bilirim. ��ine sadece �nemli �eyleri yazd���n� s�ylerdi. Ama nerede oldu�unu bilmiyorum. Belki evinde ya da karakolda olabilir.\r\n";

            }

            // Yeni se�enekleri g�ster
            //option1Button.GetComponentInChildren<TMP_Text>().text = "Tehlikeli mi? Ne demek istiyorsun?";
            //option2Button.GetComponentInChildren<TMP_Text>().text = "Peki ya son zamanlarda, ��phe duydu�u biri var m�yd�? Ya da ona zarar vermek isteyen?\r\n";
            //option3Button.GetComponentInChildren<TMP_Text>().text = "Kara, ba��m�za bela olmas�ndan korkacak m�y�z? Meri�i kaybettik. Ger�ek ne olursa olsun, ben ��renmek zorunday�m.\r\n";
            //dialogueStage = 1;
        }
        else if (dialogueStage == 1)
        {
            if (choice == 1)
            {
                dialogueText.text = "Belki denedi, ama hep ka�amak cevaplar verirdi. �zerinde b�y�k bir y�k ta��yor gibiydi, Tekir. Ama ona ne oldu�unu bilmeden ben de yard�m edemedim.\r\n";
                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri� son zamanlarda garip davran�yor muydu?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "O gece neden i� yerine geri d�nd�, fikrin var m�?";
                option3Button.GetComponentInChildren<TMP_Text>().text = "Meri�in d��man� olabilecek biri var m�yd�?";
                option1Button.gameObject.SetActive(true);
                option2Button.gameObject.SetActive(true);
                option3Button.gameObject.SetActive(true);
            }
            else if (choice == 2)
            {
                dialogueText.text = ": Evet, ama ne oldu�unu sordum. Sadece, �Bir �ey unuttum,� dedi. Halbuki biliyorum, o hi�bir �eyini unutan bir kedi de�ildi.\r\n";
                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri� son zamanlarda garip davran�yor muydu?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "O gece neden i� yerine geri d�nd�, fikrin var m�?";
                option3Button.GetComponentInChildren<TMP_Text>().text = "Meri�in d��man� olabilecek biri var m�yd�?";
                option1Button.gameObject.SetActive(true);
                option2Button.gameObject.SetActive(true);
                option3Button.gameObject.SetActive(true);
            }
            else if (choice == 3)
            {
                dialogueText.text = "Tekir, ne bulursan bul, l�tfen bana da anlat. Ger�ek ne olursa olsun, bilmek istiyorum.\r\n";
                option1Button.GetComponentInChildren<TMP_Text>().text = "Meri� son zamanlarda garip davran�yor muydu?";
                option2Button.GetComponentInChildren<TMP_Text>().text = "O gece neden i� yerine geri d�nd�, fikrin var m�?";
                option3Button.GetComponentInChildren<TMP_Text>().text = "Meri�in d��man� olabilecek biri var m�yd�?";
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
