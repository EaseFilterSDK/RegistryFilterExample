﻿///////////////////////////////////////////////////////////////////////////////
//
//    (C) Copyright 2011 EaseFilter Technologies
//    All Rights Reserved
//
//    This software is part of a licensed software product and may
//    only be used or copied in accordance with the terms of that license.
//
//    NOTE:  THIS MODULE IS UNSUPPORTED SAMPLE CODE
//
//    This module contains sample code provided for convenience and
//    demonstration purposes only,this software is provided on an 
//    "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
//     either express or implied.  
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using EaseFilter.CommonObjects;

namespace AutoFileCryptTool
{
    public partial class DropFolderForm : Form
    {
        public string dropFolder = string.Empty;

        public DropFolderForm()
        {
            InitializeComponent();
            textBox_DropFolder.Text = GlobalConfig.DropFolder;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            dropFolder = textBox_DropFolder.Text;
        }
    
    }
}
