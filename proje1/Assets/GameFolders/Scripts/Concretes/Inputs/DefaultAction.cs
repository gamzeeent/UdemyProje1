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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocet
            m_Rocet = asset.FindActionMap("Rocet", throwIfNotFound: true);
            m_Rocet_ForceUp = m_Rocet.FindAction("ForceUp", throwIfNotFound: true);
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
        public struct RocetActions
        {
            private @DefaultAction m_Wrapper;
            public RocetActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocet_ForceUp;
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
                }
                m_Wrapper.m_RocetActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                }
            }
        }
        public RocetActions @Rocet => new RocetActions(this);
        public interface IRocetActions
        {
            void OnForceUp(InputAction.CallbackContext context);
        }
    }
}
