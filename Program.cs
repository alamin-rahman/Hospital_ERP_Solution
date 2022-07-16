using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital_ERP_Solution.DoctorInfoEntries;
using Hospital_ERP_Solution.DynamicFields;
using Hospital_ERP_Solution.Lab;

namespace Hospital_ERP_Solution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LabMasterPage());
        }
    }}
