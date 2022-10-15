// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""16ba97b0-eb77-4d40-a232-e3a8d0622bff"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""e70deaa8-5741-41d0-9cd6-fdfa38a014f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""9c93cbb8-9e9a-49fd-b129-93f3162f9ef5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PressButtonLogging"",
                    ""type"": ""Button"",
                    ""id"": ""7c7bd006-aaa8-4579-b06b-5c7718e49674"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotationButton"",
                    ""type"": ""Button"",
                    ""id"": ""b53782ba-4cce-4418-97a0-64044ab223f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""333f3611-e6bc-4b3b-b22b-1da62cb8c50a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c7e2bff0-e50c-4be2-ad8f-68ed4244fb59"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""053232bc-36b9-4e12-90d4-08749d10ec91"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2a1baeaf-51b6-4b96-a783-ba9c2acb2bc6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58d408e5-c14f-43b2-ba5e-f727bbd17510"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""30e94a65-a111-43c7-b602-e58c0a5a37b1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be48c06a-8629-4ca6-9c55-e8951c9d33f6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d9775ff0-fad7-4ac8-a8f6-2a3c9f958687"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressButtonLogging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""316bd48d-c15d-4d62-9119-886d807cb73f"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressButtonLogging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55f005ea-9da1-4d0b-ab73-a51efd174018"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0ce7295-b752-48ca-bc06-b710fd667000"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c48728c-9333-4973-a9f4-2f50c90c9447"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_Fire = m_ActionMap.FindAction("Fire", throwIfNotFound: true);
        m_ActionMap_Movement = m_ActionMap.FindAction("Movement", throwIfNotFound: true);
        m_ActionMap_PressButtonLogging = m_ActionMap.FindAction("PressButtonLogging", throwIfNotFound: true);
        m_ActionMap_RotationButton = m_ActionMap.FindAction("RotationButton", throwIfNotFound: true);
        m_ActionMap_Jump = m_ActionMap.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private IActionMapActions m_ActionMapActionsCallbackInterface;
    private readonly InputAction m_ActionMap_Fire;
    private readonly InputAction m_ActionMap_Movement;
    private readonly InputAction m_ActionMap_PressButtonLogging;
    private readonly InputAction m_ActionMap_RotationButton;
    private readonly InputAction m_ActionMap_Jump;
    public struct ActionMapActions
    {
        private @PlayerControls m_Wrapper;
        public ActionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_ActionMap_Fire;
        public InputAction @Movement => m_Wrapper.m_ActionMap_Movement;
        public InputAction @PressButtonLogging => m_Wrapper.m_ActionMap_PressButtonLogging;
        public InputAction @RotationButton => m_Wrapper.m_ActionMap_RotationButton;
        public InputAction @Jump => m_Wrapper.m_ActionMap_Jump;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnFire;
                @Movement.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMovement;
                @PressButtonLogging.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnPressButtonLogging;
                @PressButtonLogging.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnPressButtonLogging;
                @PressButtonLogging.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnPressButtonLogging;
                @RotationButton.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnRotationButton;
                @RotationButton.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnRotationButton;
                @RotationButton.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnRotationButton;
                @Jump.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PressButtonLogging.started += instance.OnPressButtonLogging;
                @PressButtonLogging.performed += instance.OnPressButtonLogging;
                @PressButtonLogging.canceled += instance.OnPressButtonLogging;
                @RotationButton.started += instance.OnRotationButton;
                @RotationButton.performed += instance.OnRotationButton;
                @RotationButton.canceled += instance.OnRotationButton;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    public interface IActionMapActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnPressButtonLogging(InputAction.CallbackContext context);
        void OnRotationButton(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
