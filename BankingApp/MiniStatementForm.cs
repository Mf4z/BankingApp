﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class MiniStatementForm : Form
    {
        public MiniStatementForm()
        {
            InitializeComponent();
        }

        public MiniStatementForm(int userId)
        {
            InitializeComponent();
            // Load user data and transactions.
        }
    }
}
