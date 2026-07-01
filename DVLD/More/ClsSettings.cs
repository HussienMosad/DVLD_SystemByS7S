using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.More
{
    public class ClsSettings
    {
        
        static public Color BlueMainColor = ColorTranslator.FromHtml("#00ADB5");
        static public Color GrayMainColor = ColorTranslator.FromHtml("#323232");
        static public Color DarkGrayMainColor = ColorTranslator.FromHtml("#212121");

        
        static public int ValidityLengthForInternationalLicense = 1;


        /*
         //testAppointment = new ClsTestAppointment();
                //testAppointment.localDrivingLicenseApplication = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).localDrivingLicenseApplication;
                //testAppointment.TestTypeID = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).FrmMode;
                //testAppointment.TestType = ClsTestType.Find(testAppointment.TestTypeID);
                //testAppointment.IsLocked = false;
                //testAppointment.PaidFees = testAppointment.TestType.TestTypeFees;
                //testAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                //testAppointment.User = ClsUser.Find(ClsGlobal.CurrentUser.UserID);
                //testAppointment.LocalDrivingLicenseApplicationID = testAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                this.TestAppointment = new ClsTestAppointment();
                this.TestAppointment.localDrivingLicenseApplication = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).localDrivingLicenseApplication;
                this.TestAppointment.TestTypeID = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).FrmMode;

                this.TestAppointment.TestType = ClsTestType.Find(this.TestAppointment.TestTypeID);
                this.TestAppointment.IsLocked = false;
                this.TestAppointment.PaidFees = this.TestAppointment.TestType.TestTypeFees;
                this.TestAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                this.TestAppointment.User = ClsUser.Find(ClsGlobal.CurrentUser.UserID);
                this.TestAppointment.LocalDrivingLicenseApplicationID = this.TestAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                this.TestAppointment.AppointmentDate = new DateTime();
                this.TestAppointment.AppointmentDate = DateTime.Now;
         */


        /*
         Mode = enMode.AddNew;
                testAppointment = new ClsTestAppointment();
                testAppointment.localDrivingLicenseApplication = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).localDrivingLicenseApplication;
                testAppointment.TestTypeID = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).FrmMode;
                testAppointment.TestType = ClsTestType.Find(testAppointment.TestTypeID);
                testAppointment.IsLocked = false;
                testAppointment.PaidFees = testAppointment.TestType.TestTypeFees;
                testAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                testAppointment.User = ClsUser.Find(ClsGlobal.CurrentUser.UserID);
                testAppointment.LocalDrivingLicenseApplicationID = testAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                this.TestAppointment = new ClsTestAppointment();
                this.TestAppointment = testAppointment;
                this.TestAppointment.AppointmentDate = new DateTime();
                this.TestAppointment.localDrivingLicenseApplication = testAppointment.localDrivingLicenseApplication;
                this.TestAppointment.TestType = testAppointment.TestType;
                this.TestAppointment.TestTypeID = testAppointment.TestTypeID;
                this.TestAppointment.AppointmentDate = DateTime.Now;
         */
    }
}
