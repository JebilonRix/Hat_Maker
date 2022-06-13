using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Flow
{

    [CreateAssetMenu(fileName = "FlowMananger", menuName = "RedPanda/FlowMananger")]
    public class FlowMananger : ScriptableObject
    {
        [SerializeField] private string[] _keywords = new string[] { "start", "select_hat",
            "paint_hat", "add_texture", "select_glass", "select_pose", "take_photo", "social_media" };

        [Header("Objects")]
        [SerializeField] private GameObject _activeHat;
        [SerializeField] private GameObject _activeGlass;
        [SerializeField] private GameObject _character;
        [SerializeField] private GameObject _sprey;
        [SerializeField] private GameObject _photoCamera;

        [Header("Ui")]
        [SerializeField] private GameObject _startMenu;
        [SerializeField] private GameObject _selectionHat;
        [SerializeField] private GameObject _selectionColor;
        [SerializeField] private GameObject _selectionTexture;
        [SerializeField] private GameObject _selectionGlass;
        [SerializeField] private GameObject _selectionPose;
        [SerializeField] private GameObject _selectionSocialMedia;

        private Dictionary<string, GameObject[]> _flowDictionary = new Dictionary<string, GameObject[]>();
        private GameObject[] _allObjects;

        private void OnEnable()
        {
            //start
            _flowDictionary.Add(_keywords[0], new GameObject[] { _startMenu });
            //select_hat
            _flowDictionary.Add(_keywords[1], new GameObject[] { _selectionHat });
            //paint_hat
            _flowDictionary.Add(_keywords[2], new GameObject[] { _activeHat, _selectionColor });
            //add_texture
            _flowDictionary.Add(_keywords[3], new GameObject[] { _activeHat, _selectionTexture });
            //select_glass
            _flowDictionary.Add(_keywords[4], new GameObject[] { _activeHat, _selectionGlass });
            //select_pose
            _flowDictionary.Add(_keywords[5], new GameObject[] { _selectionPose, _activeHat, _activeGlass });
            //take_photo
            _flowDictionary.Add(_keywords[6], new GameObject[] { _photoCamera, _activeHat, _activeGlass });
            //social_media
            _flowDictionary.Add(_keywords[7], new GameObject[] { _selectionSocialMedia });

            _allObjects = new GameObject[] { _activeHat, _character, _sprey, _photoCamera, _startMenu, _selectionHat,
                _selectionTexture, _selectionGlass, _selectionPose, _selectionSocialMedia, _selectionColor };
        }

        public void ActivateObjects(string keyword)
        {
            if (!_flowDictionary.ContainsKey(keyword))
            {
                return;
            }

            for (int i = 0; i < _allObjects.Length; i++)
            {
                _allObjects[i].SetActive(false);
            }

            foreach (var obj in _flowDictionary[keyword])
            {
                obj.SetActive(true);
            }
        }
    }
}