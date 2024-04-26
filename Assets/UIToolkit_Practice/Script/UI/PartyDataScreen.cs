using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace UI_Toolkit_Practice
{
    public class PartyDataScreen : MonoBehaviour
    {
        [SerializeField] Texture2D knightAvatarImage;
        [SerializeField] string knightName;
        private VisualElement rootVisualElement;
        private void Awake()
        {
            rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
            //rootVisualElement.Query(name:"CharactorDataPanel").ForEach(OnSelectedMultipleElements);
            //rootVisualElement.Query<Label>(name: "NameLabel").ForEach(OnSelectedMultipleElements);
            rootVisualElement.Q<Label>(name: "NameLabel").text = "«_ÀI®a";
            var secondDataPanel = rootVisualElement.Query(name: "CharactorDataPanel").AtIndex(1);
            secondDataPanel.Q(name: "avatar").style.backgroundImage = knightAvatarImage;
            secondDataPanel.Q<Label>(name: "NameLabel").text = knightName;
        }

        private void OnSelectedMultipleElements(Label obj)
        {
            obj.text = "«_ÀI®a";
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rootVisualElement.style.display = rootVisualElement.style.display == DisplayStyle.Flex ? DisplayStyle.None : DisplayStyle.Flex;
            }
        }
    }
}