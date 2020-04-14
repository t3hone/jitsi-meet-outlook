﻿namespace JitsiMeetOutlook
{
    partial class AppointmentRibbonButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AppointmentRibbonButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Appointment = this.Factory.CreateRibbonTab();
            this.JitsiMeet = this.Factory.CreateRibbonGroup();
            this.RoomID = this.Factory.CreateRibbonEditBox();
            this.buttonRandomiseRoomID = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.buttonRequireName = this.Factory.CreateRibbonToggleButton();
            this.buttonMuteOnStart = this.Factory.CreateRibbonToggleButton();
            this.buttonNoVideoOnStart = this.Factory.CreateRibbonButton();
            this.Appointment.SuspendLayout();
            this.JitsiMeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.Appointment.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Appointment.ControlId.OfficeId = "TabAppointment";
            this.Appointment.Groups.Add(this.JitsiMeet);
            this.Appointment.Label = "TabAppointment";
            this.Appointment.Name = "Appointment";
            // 
            // JitsiMeet
            // 
            this.JitsiMeet.Items.Add(this.RoomID);
            this.JitsiMeet.Items.Add(this.buttonRandomiseRoomID);
            this.JitsiMeet.Items.Add(this.separator1);
            this.JitsiMeet.Items.Add(this.buttonRequireName);
            this.JitsiMeet.Items.Add(this.buttonMuteOnStart);
            this.JitsiMeet.Items.Add(this.buttonNoVideoOnStart);
            this.JitsiMeet.Label = "Jitsi Meet";
            this.JitsiMeet.Name = "JitsiMeet";
            this.JitsiMeet.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupAttendees");
            // 
            // RoomID
            // 
            this.RoomID.Label = "ID:";
            this.RoomID.Name = "RoomID";
            this.RoomID.OfficeImageId = "StylesPaneNewStyle";
            this.RoomID.ShowImage = true;
            this.RoomID.SuperTip = "Longer names are more secure.";
            this.RoomID.Text = null;
            this.RoomID.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RoomID_TextChanged);
            // 
            // buttonRandomiseRoomID
            // 
            this.buttonRandomiseRoomID.Label = "Random ID";
            this.buttonRandomiseRoomID.Name = "buttonRandomiseRoomID";
            this.buttonRandomiseRoomID.OfficeImageId = "AccessRefreshAllLists";
            this.buttonRandomiseRoomID.ShowImage = true;
            this.buttonRandomiseRoomID.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCustomiseJitsiMeeting_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // buttonRequireName
            // 
            this.buttonRequireName.Label = "Require Name";
            this.buttonRequireName.Name = "buttonRequireName";
            this.buttonRequireName.OfficeImageId = "FormControlEditBox";
            this.buttonRequireName.ShowImage = true;
            this.buttonRequireName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRequireName_Click);
            // 
            // buttonMuteOnStart
            // 
            this.buttonMuteOnStart.Label = "Mute on Start";
            this.buttonMuteOnStart.Name = "buttonMuteOnStart";
            this.buttonMuteOnStart.OfficeImageId = "SpeechMicrophone";
            this.buttonMuteOnStart.ShowImage = true;
            this.buttonMuteOnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMuteOnStart_Click);
            // 
            // buttonNoVideoOnStart
            // 
            this.buttonNoVideoOnStart.Label = "No Video on Start";
            this.buttonNoVideoOnStart.Name = "buttonNoVideoOnStart";
            this.buttonNoVideoOnStart.OfficeImageId = "Camera";
            this.buttonNoVideoOnStart.ShowImage = true;
            this.buttonNoVideoOnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNoVideoOnStart_Click);
            // 
            // AppointmentRibbonButton
            // 
            this.Name = "AppointmentRibbonButton";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.Appointment);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AppointmentRibbonButton_Load);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.JitsiMeet.ResumeLayout(false);
            this.JitsiMeet.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Appointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup JitsiMeet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRandomiseRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonMuteOnStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonRequireName;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox RoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonNoVideoOnStart;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentRibbonButton AppointmentRibbonButton
        {
            get { return this.GetRibbon<AppointmentRibbonButton>(); }
        }
    }
}
