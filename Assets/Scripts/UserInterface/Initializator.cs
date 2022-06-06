using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.UserInterface
{
    public class Initializator : MonoBehaviour
    {
        [SerializeField] private SO_UserInterfaceHandler _userInterfaceHandler;
        [SerializeField] private GameObject PlayButton;
        [SerializeField] private GameObject SelectionArea;
        [SerializeField] private GameObject ButtonsHat;
        [SerializeField] private GameObject ButtonsGlass;
        [SerializeField] private GameObject ButtonsTexture;
        [SerializeField] private GameObject ButtonsColor;

        private Dictionary<string, GameObject> _objDic = new Dictionary<string, GameObject>();

        public Dictionary<string, GameObject> ObjDic { get => _objDic; private set => _objDic = value; }

        private void Start()
        {
            ObjDic.Add("PlayButton", PlayButton);
            ObjDic.Add("SelectionArea", SelectionArea);
            ObjDic.Add("ButtonsHat", ButtonsHat);
            ObjDic.Add("ButtonsGlass", ButtonsGlass);
            ObjDic.Add("ButtonsTexture", ButtonsTexture);

            _userInterfaceHandler.Init(this);
        }

        public void SetActive(string name, bool active)
        {
            if (!ObjDic.ContainsKey(name))
            {
                return;
            }

            ObjDic[name].SetActive(active);
        }
    }
}