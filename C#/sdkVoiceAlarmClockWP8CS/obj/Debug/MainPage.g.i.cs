﻿#pragma checksum "C:\Users\kirankumar\Downloads\Alarm Clock with voice Commands Sample\C#\sdkVoiceAlarmClockWP8CS\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C2CD8140CCB497249F95C9CA16C3ED6"
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
using Microsoft.Phone.Shell;
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock TimeBlock;
        
        internal System.Windows.Controls.TextBlock monTextBlock;
        
        internal System.Windows.Controls.TextBlock tueTextBlock;
        
        internal System.Windows.Controls.TextBlock wedTextBlock;
        
        internal System.Windows.Controls.TextBlock thuTextBlock;
        
        internal System.Windows.Controls.TextBlock friTextBlock;
        
        internal System.Windows.Controls.TextBlock satTextBlock;
        
        internal System.Windows.Controls.TextBlock sunTextBlock;
        
        internal System.Windows.Controls.Image hourHand;
        
        internal System.Windows.Controls.Image minuteHand;
        
        internal System.Windows.Controls.Image secondHand;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton alarmButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton settingsButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/sdkVoiceAlarmClockWP8CS;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TimeBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TimeBlock")));
            this.monTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("monTextBlock")));
            this.tueTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("tueTextBlock")));
            this.wedTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("wedTextBlock")));
            this.thuTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("thuTextBlock")));
            this.friTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("friTextBlock")));
            this.satTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("satTextBlock")));
            this.sunTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("sunTextBlock")));
            this.hourHand = ((System.Windows.Controls.Image)(this.FindName("hourHand")));
            this.minuteHand = ((System.Windows.Controls.Image)(this.FindName("minuteHand")));
            this.secondHand = ((System.Windows.Controls.Image)(this.FindName("secondHand")));
            this.alarmButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("alarmButton")));
            this.settingsButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("settingsButton")));
        }
    }
}
