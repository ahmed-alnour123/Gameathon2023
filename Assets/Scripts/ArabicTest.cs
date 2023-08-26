using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArabicTest : MonoBehaviour {
    public string origText;
    private TMP_Text text;
    private string currentText;

    void Start() {
        text = GetComponent<TMP_Text>();
        origText = text.text;
        currentText = "";
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            StartCoroutine(Type(origText));
        }
    }

    IEnumerator Type(string str) {
        foreach (var c in str.ToCharArray()) {
            currentText += c;
            text.text = currentText;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
