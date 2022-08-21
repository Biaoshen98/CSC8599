using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    //read txt
    string[][] ArrayX;
    string[] lineArray;
    private int topicMax = 0;
    private List<bool> isAnserList = new List<bool>();

    //load question
    public GameObject tipsbtn;
    public Text tipsText;
    public List<Toggle> toggleList;
    public Text indexText;
    public Text TM_Text;
    public List<Text> DA_TextList;
    private int topicIndex = 0;

    //Function of BUtton
    public Button BtnBack;
    public Button BtnNext;
    public Button BtnTip;
    //public Button BtnJump;
    //public InputField jumpInput;
    public Text TextAccuracy;
    private int anserint = 0;
    private int isRightNum = 0;

    void Awake()
    {
        TextCsv();
        LoadAnswer();
    }

    void Start()
    {
        toggleList[0].onValueChanged.AddListener((isOn) => AnswerRightRrongJudgment(isOn,0));
        toggleList[1].onValueChanged.AddListener((isOn) => AnswerRightRrongJudgment(isOn,1));
        toggleList[2].onValueChanged.AddListener((isOn) => AnswerRightRrongJudgment(isOn,2));
        toggleList[3].onValueChanged.AddListener((isOn) => AnswerRightRrongJudgment(isOn,3));

        BtnTip.onClick.AddListener(() => Select_Answer(0));
        BtnBack.onClick.AddListener(() => Select_Answer(1));
        BtnNext.onClick.AddListener(() => Select_Answer(2));
        //BtnJump.onClick.AddListener(() => Select_Answer(3));
    }


    /*****************load txt******************/
    void TextCsv()
    {
        
        TextAsset binAsset = Resources.Load("YW", typeof(TextAsset)) as TextAsset;
        
        lineArray = binAsset.text.Split('\r');
         
        ArrayX = new string[lineArray.Length][];
         
        for (int i = 0; i < lineArray.Length; i++)
        {
            ArrayX[i] = lineArray[i].Split(':');
        }
        
        topicMax = lineArray.Length;
        for (int x = 0; x < topicMax + 1; x++)
        {
            isAnserList.Add(false);
        }
    }

    /*****************load question******************/
    void LoadAnswer()
    {
        for (int i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].isOn = false;
        }
        for (int i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].interactable = true;
        }
        
        tipsbtn.SetActive(false);
        tipsText.text = "";

        indexText.text = "The " + (topicIndex + 1) + " Question: ";
        TM_Text.text = ArrayX[topicIndex][1];
        int idx = ArrayX[topicIndex].Length - 3;
        for (int x = 0; x < idx; x++)
        {
            DA_TextList[x].text = ArrayX[topicIndex][x + 2];
        }
    }

    /*****************Button******************/
    void Select_Answer(int index)
    {
        switch (index)
        {
            case 0:
                int idx = ArrayX[topicIndex].Length - 1;
                int n = int.Parse(ArrayX[topicIndex][idx]);
                string nM = "";
                switch (n)
                {
                    case 1:
                        nM = "A";
                        break;
                    case 2:
                        nM = "B";
                        break;
                    case 3:
                        nM = "C";
                        break;
                    case 4:
                        nM = "D";
                        break;
                }
                tipsText.text = "<color=#FFAB08FF>" +"The right answer is："+ nM + "</color>";
                break;
            case 1:
                if (topicIndex > 0)
                {
                    topicIndex--;
                    LoadAnswer();
                }
                else
                {
                    tipsText.text = "<color=#27FF02FF>" + "None before this question！" + "</color>";
                }
                break;
            case 2:
                if (topicIndex < topicMax-1)
                {
                    topicIndex++;
                    LoadAnswer();
                }
                else
                {
                    tipsText.text = "<color=#27FF02FF>" + "None after this question." + "</color>";
                }
                break;
            // case 3://跳转
            //     int x = int.Parse(jumpInput.text) - 1;
            //     if (x >= 0 && x < topicMax)
            //     {
            //         topicIndex = x;
            //         jumpInput.text = "";
            //         LoadAnswer();
            //     }
            //     else
            //     {
            //         tipsText.text = "<color=#27FF02FF>" + "不在范围内！" + "</color>";
            //     }
            //     break;
        }
    }

    /*****************题目对错判断******************/
    void AnswerRightRrongJudgment(bool check,int index)
    {
        if (check)
        {
            bool isRight;
            int idx = ArrayX[topicIndex].Length - 1;
            int n = int.Parse(ArrayX[topicIndex][idx]) - 1;
            if (n == index)
            {
                tipsText.text = "<color=#27FF02FF>" + "Congratulations! " + "</color>";
                isRight = true;
                tipsbtn.SetActive(true);
            }
            else
            {
                tipsText.text = "<color=#FF0020FF>" + "You are wroing！" + "</color>";
                isRight = false;
                tipsbtn.SetActive(true);
            }

            //正确率计算
            if (isAnserList[topicIndex])
            {
                tipsText.text = "<color=#FF0020FF>" + "You have answered this question." + "</color>";
            }
            else
            {
                anserint++;
                if (isRight)
                {
                    isRightNum++;
                }
                isAnserList[topicIndex] = true;
                TextAccuracy.text = "The percentage of correct:" + ((float)isRightNum / anserint * 100).ToString("f2") + "%";
            }

            //禁用掉选项
            for (int i = 0; i < toggleList.Count; i++)
            {
                toggleList[i].interactable = false;
            }
        }
    }
}