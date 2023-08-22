using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj; //Janela de di�logo
    public Image profileSprite; //Sprite do Perfil
    public Text speechText; //Texto da Fala
    public Text actorNameText; //Nome do NPC

    [Header("Settings")]
    public float typingSpeed; //Velocidade da fala

    //Vari�veis de Controle
    private bool isShowing; //Se a janela est� vis�vel
    private int index; //index das senten�as
    private string[] sentences;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }    
    }

    //Pular para a proxima frase
    public void NextSentence()
    {
        
    }

    //Chamar a fala do NPC
    public void Speech(string[] txt)
    {
        if(!isShowing) 
        { 
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = (true);
         }
    }
}
