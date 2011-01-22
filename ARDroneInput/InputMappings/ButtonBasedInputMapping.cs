﻿using System;
using System.Collections.Generic;
using System.Text;
using ARDrone.Input.InputControls;

namespace ARDrone.Input.InputMappings
{
    public class ButtonBasedInputMapping : ValidatedInputMapping
    {
        public ButtonBasedInputMapping(List<String> validButtons, List<String> validAxes)
            : base(validButtons, validAxes, new ButtonBasedInputControl())
        { }

        private ButtonBasedInputMapping(List<String> validButtons, List<String> validAxes, InputControl controls)
            : base(validButtons, validAxes, controls)
        { }

        public override InputMapping Clone()
        {
            InputMapping clonedMapping = new ButtonBasedInputMapping(validButtons, validAxes, controls);
            return clonedMapping;
        }

        protected override InputControl CreateInputControlFromMappings(Dictionary<String, String> mappings)
        {
            return new ButtonBasedInputControl(mappings);
        }

        public void SetAxisMappings(Object rollAxisMapping, Object pitchAxisMapping, Object yawAxisMapping, Object gazAxisMapping)
        {
            controls.SetProperty(ButtonBasedInputControl.RollAxisMappingField, rollAxisMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.PitchAxisMappingField, pitchAxisMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.YawAxisMappingField, yawAxisMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.GazAxisMappingField, gazAxisMapping.ToString());
        }

        public void SetButtonMappings(Object cameraSwapButtonMapping, Object takeOffButtonMapping, Object landButtonMapping, Object hoverButtonMapping, Object emergencyButtonMapping, Object flatTrimButtonMapping, Object specialActionButtonMapping)
        {
            controls.SetProperty(ButtonBasedInputControl.CameraSwapButtonField, cameraSwapButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.TakeOffButtonField, takeOffButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.LandButtonField, landButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.HoverButtonField, hoverButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.EmergencyButtonField, emergencyButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.FlatTrimButtonField, flatTrimButtonMapping.ToString());
            controls.SetProperty(ButtonBasedInputControl.SpecialActionButtonField, specialActionButtonMapping.ToString());
        }

        public String RollAxisMapping
        {
            get { return controls.GetProperty(ButtonBasedInputControl.RollAxisMappingField); }
            set { controls.SetProperty(ButtonBasedInputControl.RollAxisMappingField, value); }
        }

        public String PitchAxisMapping
        {
            get { return controls.GetProperty(ButtonBasedInputControl.PitchAxisMappingField); }
            set { controls.SetProperty(ButtonBasedInputControl.PitchAxisMappingField, value); }
        }

        public String YawAxisMapping
        {
            get { return controls.GetProperty(ButtonBasedInputControl.YawAxisMappingField); }
            set { controls.SetProperty(ButtonBasedInputControl.YawAxisMappingField, value); }
        }

        public String GazAxisMapping
        {
            get { return controls.GetProperty(ButtonBasedInputControl.GazAxisMappingField); }
            set { controls.SetProperty(ButtonBasedInputControl.GazAxisMappingField, value); }
        }

        public String CameraSwapButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.RollAxisMappingField); }
            set { controls.SetProperty(ButtonBasedInputControl.CameraSwapButtonField, value); }
        }

        public String TakeOffButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.TakeOffButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.TakeOffButtonField, value); }
        }

        public String LandButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.LandButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.LandButtonField, value); }
        }

        public String HoverButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.HoverButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.HoverButtonField, value); }
        }

        public String EmergencyButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.EmergencyButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.EmergencyButtonField, value); }
        }

        public String FlatTrimButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.FlatTrimButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.FlatTrimButtonField, value); }
        }

        public String SpecialActionButton
        {
            get { return controls.GetProperty(ButtonBasedInputControl.SpecialActionButtonField); }
            set { controls.SetProperty(ButtonBasedInputControl.SpecialActionButtonField, value); }
        }

        private ButtonBasedInputControl ButtonControls
        {
            get
            {
                return (ButtonBasedInputControl)controls;
            }
        }
    }
}
