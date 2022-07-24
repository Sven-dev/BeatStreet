// GENERATED AUTOMATICALLY FROM 'Assets/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0d52572e-5fb6-40e6-8ff7-e49f4513b445"",
            ""actions"": [
                {
                    ""name"": ""DirectionRight"",
                    ""type"": ""Button"",
                    ""id"": ""72ee46c6-de76-45fc-b251-e5614288dfd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DirectionLeft"",
                    ""type"": ""Button"",
                    ""id"": ""fa66ba8a-6f40-423c-956f-01108355fdc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DirectionUp"",
                    ""type"": ""Button"",
                    ""id"": ""f01a3e23-05ae-4914-aa80-fd21418afc21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DirectionDown"",
                    ""type"": ""Button"",
                    ""id"": ""7518028b-fbd5-4c9e-b149-6d314c391dc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""52aea60c-6ce3-407a-96cc-d69189be3e7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""476cf904-4eff-403b-b7e0-1a83e6df155c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""9832a3b9-2020-4a6e-b001-1294cc83315e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f38a7f6-f636-4717-97b7-0e7210701a6e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8a43ea2-fa78-4419-bd42-d58a5ef96fe5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fabd418-e3d5-454b-92ab-01e7b0d4be9e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68e9d0b2-515f-4835-ac2e-0e12d98195fb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b275dc15-e1ba-4797-b594-146937f05c7c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f7a7368-4701-49d4-b11f-f0d8616d50b5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6224c2e-75d4-49a9-96da-68697296a4c7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c053495-9847-4575-b09d-0e58ee5e0bc4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DirectionDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f082df-ee2e-4698-a496-7430da1cd8cc"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""653944d6-ba61-4495-a3d1-2a321613ece9"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ffeecff9-1bda-409c-b5c3-1a9e3b89c70e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1806404c-1c44-4a81-91fd-e961c466d972"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c1e0421-5e9f-4600-8354-72c9e813ee43"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74b69a21-5465-4ee6-8204-a73b0e56c7fc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e42f3b56-0717-44d6-ad01-8095aeabf366"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""cd54f707-2f15-40cf-9a71-a73e1934aae7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3cd44b74-3ec9-4500-9089-59e463549175"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0a6148d2-47dd-41a1-a3b2-df58ce85902b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3d8824e2-fae7-4ec9-9fb0-9eea46cb8dd6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f2e8e6c-023e-4586-85f1-77a73e13e4ef"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_DirectionRight = m_Player.FindAction("DirectionRight", throwIfNotFound: true);
        m_Player_DirectionLeft = m_Player.FindAction("DirectionLeft", throwIfNotFound: true);
        m_Player_DirectionUp = m_Player.FindAction("DirectionUp", throwIfNotFound: true);
        m_Player_DirectionDown = m_Player.FindAction("DirectionDown", throwIfNotFound: true);
        m_Player_Punch = m_Player.FindAction("Punch", throwIfNotFound: true);
        m_Player_Kick = m_Player.FindAction("Kick", throwIfNotFound: true);
        m_Player_LeftStick = m_Player.FindAction("LeftStick", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_DirectionRight;
    private readonly InputAction m_Player_DirectionLeft;
    private readonly InputAction m_Player_DirectionUp;
    private readonly InputAction m_Player_DirectionDown;
    private readonly InputAction m_Player_Punch;
    private readonly InputAction m_Player_Kick;
    private readonly InputAction m_Player_LeftStick;
    public struct PlayerActions
    {
        private @Inputs m_Wrapper;
        public PlayerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @DirectionRight => m_Wrapper.m_Player_DirectionRight;
        public InputAction @DirectionLeft => m_Wrapper.m_Player_DirectionLeft;
        public InputAction @DirectionUp => m_Wrapper.m_Player_DirectionUp;
        public InputAction @DirectionDown => m_Wrapper.m_Player_DirectionDown;
        public InputAction @Punch => m_Wrapper.m_Player_Punch;
        public InputAction @Kick => m_Wrapper.m_Player_Kick;
        public InputAction @LeftStick => m_Wrapper.m_Player_LeftStick;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @DirectionRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionRight;
                @DirectionRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionRight;
                @DirectionRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionRight;
                @DirectionLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionLeft;
                @DirectionLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionLeft;
                @DirectionLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionLeft;
                @DirectionUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionUp;
                @DirectionUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionUp;
                @DirectionUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionUp;
                @DirectionDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionDown;
                @DirectionDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionDown;
                @DirectionDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionDown;
                @Punch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch;
                @Kick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick;
                @LeftStick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStick;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DirectionRight.started += instance.OnDirectionRight;
                @DirectionRight.performed += instance.OnDirectionRight;
                @DirectionRight.canceled += instance.OnDirectionRight;
                @DirectionLeft.started += instance.OnDirectionLeft;
                @DirectionLeft.performed += instance.OnDirectionLeft;
                @DirectionLeft.canceled += instance.OnDirectionLeft;
                @DirectionUp.started += instance.OnDirectionUp;
                @DirectionUp.performed += instance.OnDirectionUp;
                @DirectionUp.canceled += instance.OnDirectionUp;
                @DirectionDown.started += instance.OnDirectionDown;
                @DirectionDown.performed += instance.OnDirectionDown;
                @DirectionDown.canceled += instance.OnDirectionDown;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnDirectionRight(InputAction.CallbackContext context);
        void OnDirectionLeft(InputAction.CallbackContext context);
        void OnDirectionUp(InputAction.CallbackContext context);
        void OnDirectionDown(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
    }
}
