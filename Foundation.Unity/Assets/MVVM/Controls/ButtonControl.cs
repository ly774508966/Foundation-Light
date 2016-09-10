using MVVM;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonControl : MonoBehaviour
{
    public SourceBinding Source;

    [MemberConstraint(MemberType.Properties, typeof(bool))]
    public MemberBinding Enabled;

    [MemberConstraint(MemberType.Methods)]
    public MemberBinding OnClick;

    [MemberConstraint(MemberType.Properties)]
    public MemberBinding Label;
    
    private Button _uiElement;

    void Awake()
    {
        _uiElement = GetComponent<Button>();
        _uiElement.onClick.AddListener(Call);

        Source.Subscribe(proxy =>
        {
            if (proxy == null)
            {
                Reset();
            }
            else
            {
                // We are bound !
            }
        });
        
        OnClick.Subscribe<bool>(e =>
        {
            _uiElement.enabled = e;
        });

        Enabled.Subscribe<bool>(e =>
        {
            _uiElement.enabled = e;

        });

        Label.Subscribe<string>(e =>
        {
            GetComponentInChildren<Text>().text = e;
        });
    }

    private void Call()
    {
        // Call the method on the view model
        // which method ? the bound method 'OnClick.Member'
        Source.Post(OnClick.Member);
    }

    private void Reset()
    {
        //defaults here
    }
}