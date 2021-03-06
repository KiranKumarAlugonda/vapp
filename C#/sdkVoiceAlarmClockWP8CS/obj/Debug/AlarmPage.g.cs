﻿#pragma checksum "C:\Users\kirankumar\Downloads\Alarm Clock with voice Commands Sample\C#\sdkVoiceAlarmClockWP8CS\AlarmPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FF403C889B30E043FC9B1BFAF1D76E20"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AlarmClockWithVoice {
    
    
    public partial class AlarmPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard hourHandBlinkStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard minuteHandBlinkStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock alarmTimeTextBlock;
        
        internal System.Windows.Controls.Image clockFaceImage;
        
        internal System.Windows.Controls.Image hourHand;
        
        internal System.Windows.Media.CompositeTransform hourHandRotation;
        
        internal System.Windows.Controls.Image minuteHand;
        
        internal System.Windows.Media.CompositeTransform minuteHandRotation;
        
        internal Microsoft.Phone.Controls.TimePicker timePicker;
        
        internal Microsoft.Phone.Controls.ToggleSwitch alarmToggleSwitch;
        
        internal Microsoft.Phone.Controls.ToggleSwitch adjustDirectionToggleSwitch;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/sdkVoiceAlarmClockWP8CS;component/AlarmPage.xaml", System.UriKind.Relative));
            this.hourHandBlinkStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("hourHandBlinkStoryboard")));
            this.minuteHandBlinkStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("minuteHandBlinkStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.alarmTimeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("alarmTimeTextBlock")));
            this.clockFaceImage = ((System.Windows.Controls.Image)(this.FindName("clockFaceImage")));
            this.hourHand = ((System.Windows.Controls.Image)(this.FindName("hourHand")));
            this.hourHandRotation = ((System.Windows.Media.CompositeTransform)(this.FindName("hourHandRotation")));
            this.minuteHand = ((System.Windows.Controls.Image)(this.FindName("minuteHand")));
            this.minuteHandRotation = ((System.Windows.Media.CompositeTransform)(this.FindName("minuteHandRotation")));
            this.timePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("timePicker")));
            this.alarmToggleSwitch = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("alarmToggleSwitch")));
            this.adjustDirectionToggleSwitch = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("adjustDirectionToggleSwitch")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
        }
    }
}

