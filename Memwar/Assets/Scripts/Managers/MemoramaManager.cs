using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoramaManager : AppObject
{
    public List<GameObject> cardList;
    public Transform cardParent;
    public GameObject gameOverPanel;
    public GameObject WinPanel;
    public int maxPairs = 5;

    private int pairCounter = 0;
    private Card savedCard;
    private bool isFirstCard = true;
    private bool IsGameFinished;

    private TimerImage timer;


    private static MemoramaManager _instance;
    public static MemoramaManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MemoramaManager>();
            }
            return _instance;

        }
    }


    private void Start()
    {
        AddEventListener<TimeOutEvent>(TimeOutEventListener);
        timer = GameObject.FindObjectOfType<TimerImage>();
        StartGame();
    }

    private void TimeOutEventListener(TimeOutEvent eventTimer)
    {
        if (IsGameFinished)
            return;

        Debug.Log("Game over! Se me acabó el tiempo");
        IsGameFinished = true;
        gameOverPanel.SetActive(true);
        SoundManager.instance.StopBGMAudio();
        timer.StopTimer();
    }

    public void StartGame()
    {
        SetCards();
        gameOverPanel.SetActive(false);
        WinPanel.SetActive(false);
        IsGameFinished = false;
        isFirstCard = true;
        pairCounter = 0;
        SoundManager.instance.PlayBGMAudioClip("Background");
        SoundManager.instance.SetBGMVolume(0.5f);
        timer.StartTimer();
    }

    private void SetCards()
    {
        for (int i = 0; i < cardParent.childCount; i++)
        {
            GameObject.Destroy(cardParent.GetChild(i).gameObject);
        }

        List<GameObject> localCardList = new List<GameObject>();

        foreach(GameObject card in cardList)
        {
            localCardList.Add(card);
        }

        int dice = 0;

        for (int i = 0; i < cardList.Count; i++)
        {
            dice = Random.Range(0, localCardList.Count);
            GameObject.Instantiate(localCardList[dice], cardParent);
            localCardList.RemoveAt(dice);
        }
    }
   

  
    

    public void CardReceived(Card newCard)
    {
        newCard.SetCardInteraction(false);
        if (isFirstCard)
        {
            savedCard = newCard;
           
            isFirstCard = false;
            return;
        }

        if(newCard.card_id == savedCard.card_id)
        {
            Debug.Log("Es par!");
            
            pairCounter++;

            if(pairCounter == maxPairs)
            {
                IsGameFinished = true;
                WinPanel.SetActive(true);
                SoundManager.instance.StopBGMAudio();
                timer.StopTimer();
            }
        }
        else
        {
            Debug.Log("No es par!");
            StartCoroutine(SetCardInteractable(newCard));
            StartCoroutine(SetCardInteractable(savedCard));
           // savedCard.SetCardColor();
        }

        isFirstCard = true;

        }


    public void RestartGame()
    {
        StartGame();
    }

    private IEnumerator SetCardInteractable(Card _card)
    {
        float timer = 0;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        _card.SetCardInteraction(true);
        _card.GetComponent<Animator>().SetTrigger("Clicked");
    }
}
