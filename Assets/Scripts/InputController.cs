// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""12e19ddd-2952-44d2-bad7-57f7795cbfdc"",
            ""actions"": [
                {
                    ""name"": ""Axis"",
                    ""type"": ""Button"",
                    ""id"": ""09ab18e1-b267-45a6-9812-4a1fce4557c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8c98d9b9-3252-4cdf-9844-fa8158947f22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Atack"",
                    ""type"": ""Button"",
                    ""id"": ""7568261c-84f4-4776-846b-8ee712b85b46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""7fdb1cf4-ada0-449d-8744-d420959694ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shield"",
                    ""type"": ""Button"",
                    ""id"": ""4d440611-815a-4697-808c-143dfe4ee4d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c2ef3599-bb43-4e33-b24b-f333c8a38bea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipXRight"",
                    ""type"": ""Button"",
                    ""id"": ""99940e70-f5c0-43bd-929f-94df324de399"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""26494704-0fb0-4f7b-bce6-8fc1d0d6d22c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e27a0250-4b57-40d4-8579-e3f26da5da28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8a672ab-cc7a-4b7b-9be4-2252bde17cde"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""5b7ad1f1-7255-43b8-bc7d-b4f055bd36f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""963117dc-3ec6-4b32-b9b0-1ba06a296355"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83ecef46-85d3-41f9-9db4-fa16d13865f9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0462ec10-b28c-4fa6-85dc-aaafcf6c7943"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1625ff35-9c39-4b1e-8678-f8fe3162836b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Atack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""102da6c8-fc6b-49ea-b8d5-4398ec9f3c8a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db436adc-46af-4b82-b2cb-17050cd936ce"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""683a2739-423d-446d-b754-2e7528962fc7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""525d6a87-53f0-4fdd-a2d1-b07ed1f29881"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipXRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Axis = m_Gameplay.FindAction("Axis", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Atack = m_Gameplay.FindAction("Atack", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_Shield = m_Gameplay.FindAction("Shield", throwIfNotFound: true);
        m_Gameplay_FlipLeft = m_Gameplay.FindAction("FlipLeft", throwIfNotFound: true);
        m_Gameplay_FlipXRight = m_Gameplay.FindAction("FlipXRight", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Axis;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Atack;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_Shield;
    private readonly InputAction m_Gameplay_FlipLeft;
    private readonly InputAction m_Gameplay_FlipXRight;
    public struct GameplayActions
    {
        private @InputController m_Wrapper;
        public GameplayActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis => m_Wrapper.m_Gameplay_Axis;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Atack => m_Wrapper.m_Gameplay_Atack;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @Shield => m_Wrapper.m_Gameplay_Shield;
        public InputAction @FlipLeft => m_Wrapper.m_Gameplay_FlipLeft;
        public InputAction @FlipXRight => m_Wrapper.m_Gameplay_FlipXRight;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Axis.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Axis.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Axis.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Atack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtack;
                @Atack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtack;
                @Atack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtack;
                @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Shield.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShield;
                @Shield.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShield;
                @Shield.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShield;
                @FlipLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipLeft;
                @FlipLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipLeft;
                @FlipLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipLeft;
                @FlipXRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipXRight;
                @FlipXRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipXRight;
                @FlipXRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlipXRight;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Axis.started += instance.OnAxis;
                @Axis.performed += instance.OnAxis;
                @Axis.canceled += instance.OnAxis;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Atack.started += instance.OnAtack;
                @Atack.performed += instance.OnAtack;
                @Atack.canceled += instance.OnAtack;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Shield.started += instance.OnShield;
                @Shield.performed += instance.OnShield;
                @Shield.canceled += instance.OnShield;
                @FlipLeft.started += instance.OnFlipLeft;
                @FlipLeft.performed += instance.OnFlipLeft;
                @FlipLeft.canceled += instance.OnFlipLeft;
                @FlipXRight.started += instance.OnFlipXRight;
                @FlipXRight.performed += instance.OnFlipXRight;
                @FlipXRight.canceled += instance.OnFlipXRight;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAtack(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
        void OnFlipLeft(InputAction.CallbackContext context);
        void OnFlipXRight(InputAction.CallbackContext context);
    }
}
