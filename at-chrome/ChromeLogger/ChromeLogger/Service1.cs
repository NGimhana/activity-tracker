﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ChromeLogger
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TabLogger t = new TabLogger();
            t.chromeTabLogger();            
        }

        protected override void OnStop()
        {
        }
        public void onDebug()
        {
            OnStart(null);
        }
    }
}