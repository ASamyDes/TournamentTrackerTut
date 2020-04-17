using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class tournamentForm : Form , IPrizeRequestor,ITeamRequestor
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeam = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();


        public tournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void tournamentPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            // Tournaments Teams ListBox
            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeam;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t !=null)
            {
                availableTeams.Remove(t);
                selectedTeam.Add(t); 
            }

            WireUpLists();
        }

        private void deleteSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeam.Remove(t);
                availableTeams.Add(t);
                
            }

            WireUpLists();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

   
        }

        public void PrizeComplete(PrizeModel model)
        {


            //Take the created prizemodel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeam.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }
    }
}
