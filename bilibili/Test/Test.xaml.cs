﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using bilibili.Methods;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//  “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace bilibili.Test
{
   /// <summary>
   /// 可用于自身或导航至 Frame 内部的空白页。
   /// </summary>
    public sealed partial class Test : Page
    {
        public Test()
        {
            this.InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                list.Items.Add(i.ToString()+"___________________");
            }
        }

        private async void PullToRefreshPanel_RefreshRequested(object sender, EventArgs e)
        {
            await new ContentDialog { Content = "233", IsPrimaryButtonEnabled = true, PrimaryButtonText = "233" }.ShowAsync();
        }

        private void list_ContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {
            var scroll = Load.FindChildOfType<ScrollViewer>(list);
            scroll.ViewChanged +=  (s, a) =>
            {
                panel.Value = scroll.VerticalOffset;
            };

        }
    }
}
