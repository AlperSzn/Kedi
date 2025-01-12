using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject mapButton;
    [SerializeField] GameObject haritaPanel;
    [SerializeField] GameObject envanterPanel;
    [SerializeField] GameObject supheliPanel;
    [SerializeField] GameObject karakolText;
    [SerializeField] public GameObject minagorevText;

    MinaMezarl�k minaMezarl�k;
    KaraMezarl�k karaMezarl�k;

    private void Awake()
    {
        karaMezarl�k = FindAnyObjectByType<KaraMezarl�k>();
        minaMezarl�k = FindAnyObjectByType<MinaMezarl�k>();
    }
    private void Update()
    {
        if(minaMezarl�k.minaGorev == true)
        {
            mapButton.SetActive(true);
            minagorevText.SetActive(true);
        }
        if(karaMezarl�k.karakolGorev == true)
        {
            karakolText.SetActive(true);

        }
    }

    public void Harita()
    {
        haritaPanel.SetActive(true);
    }
    public void Envanter()
    {
        envanterPanel.SetActive(true);
    }
    public void Liste()
    {
        supheliPanel.SetActive(true);
    }
}
