﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadDomLab4JakubKazimierski.Models;
using ZadDomLab4JakubKazimierski.Repositories;

namespace ZadDomLab4JakubKazimierski
{
    public partial class AgentsMenu : Form
    {
        private readonly IFBIgeneric<FBIagentsList> _agents;
        private readonly IFBIgeneric<FBIagentsType> _agentsType;
        public AgentsMenu()
        {
            InitializeComponent();

            _agents = new FBIgeneric<FBIagentsList>();
            _agentsType = new FBIgeneric<FBIagentsType>();

            LoadAgents();
        }

        private void  LoadAgents()
        {
            AgentsDataGridView.DataSource = _agents.GetAll();
        }
    }
}