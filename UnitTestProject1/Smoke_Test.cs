using Microsoft.VisualStudio.TestTools.UnitTesting;
using REHC_Project.General;
using REHC_Project.PageObjects;
using REHC_Project.PageObjects.AgenciesPage;
using REHC_Project.PageObjects.AgentsPage;
using REHC_Project.PageObjects.BV.AddingProspect;
using REHC_Project.PageObjects.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHC_SmokeTest
{
    [TestClass]
    public class Smoke_Test : Base
    {
        
        AddAgency aa = new AddAgency();
        AddAgent aagnt = new AddAgent();
        AddBranch ab = new AddBranch();
        AddDocument ad = new AddDocument();
        AddNotes an = new AddNotes();
        ClientsPage cp = new ClientsPage();
        TopMenu tm = new TopMenu();
        LoginPage lp = new LoginPage();
        SearchAgency sa = new SearchAgency();
        SearchAgent sag = new SearchAgent();
        AddProspect ap = new AddProspect();
        PurchaseTab pt = new PurchaseTab();
        

        [TestMethod]
        public void REHC_SMOKE_TEST()
        {
            lp.Log_in();
            aa.AgencyFormFiller();
            aagnt.AgentFormFiller();
            ab.BranchFormFiller();
            an.AddingNotes();
            ad.AddDocuments();
            cp.ClientFormFiller();
            tm.ClickTopMenuTabs();
        }

        [TestMethod]

        public void SearchAgency()
        {
            lp.Log_in();
            sa.AgencySearch(); 
        }

        [TestMethod]
        public void SearchAgent()
        {
            lp.Log_in();
            sag.AgentSearch();
        }

        [TestMethod]
        public void AddProspect()
        {
            ap.Login();
            //ap.AddNewProspect();
            pt.PurchaseInfo();

        }

    }
}


