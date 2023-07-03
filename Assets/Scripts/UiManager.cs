using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    [SerializeField]
    Text _haveMoneyTaxt;
    [SerializeField, ElementNames(new string[] { "ShopA", "ShopB", "所持品" })]
    private Button[] _button = default;
    [SerializeField, ElementNames(new string[] { "ShopA", "ShopB", "所持品", "行動選択" })]
    private GameObject[] _screen = default;
    [SerializeField, ElementNames(new string[] { "剣", "盾", "毒消し草", "聖水", "薬草","聖水1" })]
    private Button[] _buyItem;
    [SerializeField,Tooltip("それぞれの所持数")]
    private int[]_eachAmount;
    [SerializeField]
    private Transform _panel;
    [SerializeField]
    private GameObject _itemButton;
    GameObject obj;
    void Start()
    {
        FirstSelectButton();

        _haveMoneyTaxt.text = "所持金:" + GameManager.Instance.Money + "G";
    }

    // Update is called once per frame
    void Update()
    {
        _haveMoneyTaxt.text = "所持金:" + GameManager.Instance.Money + "G";
    }
    /// <summary>最初の行動選択</summary>
    void FirstSelectButton()
    {
        _button[0].onClick.AddListener(() =>
        {
            _screen[0].SetActive(true);
            _screen[3].SetActive(false);
        });
        _button[1].onClick.AddListener(() =>
        {
            _screen[1].SetActive(true);
            _screen[3].SetActive(false);
        });
        _button[2].onClick.AddListener(() =>
        {
            _screen[2].SetActive(true);
            _screen[3].SetActive(false);
        });
        _buyItem[0].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 100) return;
            GameManager.Instance.Money -= 100;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "剣";
            if (_eachAmount[0] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
            
            _eachAmount[0]++;
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[0];
        });
        _buyItem[1].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 100) return;
            GameManager.Instance.Money -= 100;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "盾";
            if (_eachAmount[1] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
                    
            _eachAmount[1]++;
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[1];
        });
        _buyItem[2].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 20) return;
            GameManager.Instance.Money -= 20;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "毒消し草";
            if (_eachAmount[2] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
            
            _eachAmount[2]++;
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[2];
        });
        _buyItem[3].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 40) return;
            GameManager.Instance.Money -= 40;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "聖水";
            if (_eachAmount[3] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
            _eachAmount[3]++;
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[3];
        });
        _buyItem[4].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 10) return;
            GameManager.Instance.Money -= 10;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "薬草";
            if (_eachAmount[4] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
            _eachAmount[4]++;
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[4];
        });
        _buyItem[5].onClick.AddListener(() =>
        {
            if (GameManager.Instance.Money < 40) return;
            GameManager.Instance.Money -= 40;
            _itemButton.transform.GetChild(0).GetComponent<Text>().text = "聖水";
            if (_eachAmount[3] == 0)
            {
                obj = (GameObject)Instantiate(_itemButton, this.transform);
                obj.transform.SetParent(_panel);
            }
            _eachAmount[3]++;           
            _itemButton.transform.GetChild(1).GetComponent<Text>().text = "✕" + _eachAmount[3];
        });
    }
}
