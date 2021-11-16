﻿#region "copyright"

/*
    Copyright © 2021 - 2021 George Hilios <ghilios+NINA@googlemail.com>

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

#endregion "copyright"

using Joko.NINA.Plugins.TenMicron.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Joko.NINA.Plugins.TenMicron.View {

    /// <summary>
    /// Interaction logic for MountView.xaml
    /// </summary>
    public partial class MountView : UserControl {

        public MountView() {
            InitializeComponent();
        }

        private void UnattendedFlipEnabled_Unchecked(object sender, RoutedEventArgs e) {
            var checkBox = (CheckBox)sender;
            var mountVM = (MountVM)checkBox.DataContext;
            mountVM.DisableUnattendedFlip();
        }
    }
}