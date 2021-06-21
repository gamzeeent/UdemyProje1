// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Scripts/Concretes/Inputs/DefaultAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace proje1.Inputs
{
    public class @DefaultAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocet"",
            ""id"": ""aff4c5ce-99f2-4ddd-b981-04505a882c6a"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1ac217c-e27b-43ba-97b8-2630c8433c83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f6e357bf-d04b-4cf8-bf4a-1258c6b5c5c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a91d98bb-cd89-4028-88aa-27c3101d9eac"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""3eadd83f-bc41-4c0d-aad4-0a7c43296210"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f99c6335-9520-40eb-8d99-9f8cc871eed9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""16734d00-4f46-4952-ac74-19a6b84b3ce2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocet
            m_Rocet = asset.FindActionMap("Rocet", throwIfNotFound: true);
            m_Rocet_ForceUp = m_Rocet.FindAction("ForceUp", throwIfNotFound: true);
            m_Rocet_LeftRight = m_Rocet.FindAction("LeftRight", throwIfNotFound: true);
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

        // Rocet
        private readonly InputActionMap m_Rocet;
        private IRocetActions m_RocetActionsCallbackInterface;
        private readonly InputAction m_Rocet_ForceUp;
        private readonly InputAction m_Rocet_LeftRight;
        public struct RocetActions
        {
            private @DefaultAction m_Wrapper;
            public RocetActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocet_ForceUp;
            public InputAction @LeftRight => m_Wrapper.m_Rocet_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_Rocet; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocetActions set) { return set.Get(); }
            public void SetCallbacks(IRocetActions instance)
            {
                if (m_Wrapper.m_RocetActionsCallbackInterface != null)
                {
                    @ForceUp.started -= m_Wrapper.m_RocetActionsCallbackInterface.OnForceUp;
                    @ForceUp.performed -= m_Wrapper.m_RocetActionsCallbackInterface.OnForceUp;
                    @ForceUp.canceled -= m_Wrapper.m_RocetActionsCallbackInterface.OnForceUp;
                    @LeftRight.started -= m_Wrapper.m_RocetActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_RocetActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_RocetActionsCallbackInterface.OnLeftRight;
                }
                m_Wrapper.m_RocetActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                }
            }
        }
        public RocetActions @Rocet => new RocetActions(this);
        public interface IRocetActions
        {
            void OnForceUp(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}
