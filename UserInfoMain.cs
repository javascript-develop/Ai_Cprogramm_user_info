/**********************************************************
 * Demo for Standalone SDK.Created by Darcy on Oct.15 2009*
***********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace UserInfo
{
    public partial class UserInfoMain : Form
    {
        public UserInfoMain()
        {
            InitializeComponent();
        }

        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        /*************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.*
        * This part is for demonstrating the communication with your device.                             *
        * ************************************************************************************************/
        #region Communication
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.

        //If your device supports the TCP/IP communications, you can refer to this.
        //when you are using the tcp/ip communication,you can distinguish different devices by their IP address.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                Cursor = Cursors.Default;
                return;
            }

            axCZKEM1.PullMode = 1;
            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //If your device supports the SerialPort communications, you can refer to this.
        private void btnRsConnect_Click(object sender, EventArgs e)
        {
            if (cbPort.Text.Trim() == "" || cbBaudRate.Text.Trim() == "" || txtMachineSN.Text.Trim() == "")
            {
                MessageBox.Show("Port,BaudRate and MachineSN cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;
            //accept serialport number from string like "COMi"
            int iPort;
            string sPort = cbPort.Text.Trim();
            for (iPort = 1; iPort < 10; iPort++)
            {
                if (sPort.IndexOf(iPort.ToString()) > -1)
                {
                    break;
                }
            }

            Cursor = Cursors.WaitCursor;
            if (btnRsConnect.Text == "Disconnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnRsConnect.Text = "Connect";
                btnRsConnect.Refresh();
                lblState.Text = "Current State:Disconnected";
                Cursor = Cursors.Default;
                return;
            }

            iMachineNumber = Convert.ToInt32(txtMachineSN.Text.Trim());//when you are using the serial port communication,you can distinguish different devices by their serial port number.
            bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, Convert.ToInt32(cbBaudRate.Text.Trim()));

            if (bIsConnected == true)
            {
                btnRsConnect.Text = "Disconnect";
                btnRsConnect.Refresh();
                lblState.Text = "Current State:Connected";

                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }

            Cursor = Cursors.Default;
        }

        #endregion

        /*************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.*
        * This part is for demonstrating operations with user(download/upload/delete/clear/modify).      *
        * ************************************************************************************************/
        #region UserInfo

        //Clear all the fingerprint templates in the device(While the parameter DataFlag  of the Function "ClearData" is 2 )
        private void btnClearDataTmps_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            int iDataFlag = 2;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearData(iMachineNumber, iDataFlag))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Clear all the fingerprint templates!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //Delete all the user information in the device,while the related fingerprint templates will be deleted either. 
        //(While the parameter DataFlag  of the Function "ClearData" is 5 )
        private void btnClearDataUserInfo_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            int iDataFlag = 5;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearData(iMachineNumber, iDataFlag))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Clear all the UserInfo data!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //Delete a kind of data that some user has enrolled
        //The range of the Backup Number is from 0 to 9 and the specific meaning of Backup number is described in the development manual,pls refer to it.

        //Clear all the administrator privilege(not clear the administrators themselves)
        private void btnClearAdministrators_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearAdministrators(iMachineNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Successfully clear administrator privilege from teiminal!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

private void btnDownLoadFace_Click(object sender, EventArgs e)
{
    if (bIsConnected == false)
    {
        MessageBox.Show("Please connect the device first!", "Error");
        return;
    }

    string sUserID = "";
    string sName = "";
    string sPassword = "";
    int iPrivilege = 0;
    bool bEnabled = false;
    int iFaceIndex = 50; // the only possible parameter value
    string sTmpData = "";
    int iLength = 0;
    lvFace.Items.Clear();
    lvFace.BeginUpdate();

    Cursor = Cursors.WaitCursor;
    axCZKEM1.EnableDevice(iMachineNumber, false);

    if (!axCZKEM1.ReadAllUserID(iMachineNumber)) // read all user information to memory
    {
        MessageBox.Show("Failed to read all user IDs from the device.", "Error");
        axCZKEM1.EnableDevice(iMachineNumber, true);
        lvFace.EndUpdate();
        Cursor = Cursors.Default;
        return;
    }

    while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sUserID, out sName, out sPassword, out iPrivilege, out bEnabled))
    {
        if (!axCZKEM1.GetUserFaceStr(iMachineNumber, sUserID, iFaceIndex, ref sTmpData, ref iLength))
        {
            // Log the failure details
            MessageBox.Show($"Failed to get face template for User ID: {sUserID}, Face Index: {iFaceIndex}", "Error");
            continue; // Continue with the next user
        }

        ListViewItem list = new ListViewItem();
        list.Text = sUserID;
        list.SubItems.Add(sName);
        list.SubItems.Add(sPassword);
        list.SubItems.Add(iPrivilege.ToString());
        list.SubItems.Add(iFaceIndex.ToString());
        list.SubItems.Add("0");
        string phtoName = sUserID + ".jpg";
        byte[] PhotoData = new byte[1024 * 1024];
        int phtoSize = 0;

        if (axCZKEM1.GetUserFacePhotoByName(iMachineNumber, phtoName, out PhotoData[0], out phtoSize))
        {
            using (MemoryStream memoryStream = new MemoryStream(PhotoData, 0, phtoSize))
            {
                string base64String = Convert.ToBase64String(memoryStream.ToArray());

                list.SubItems.Add(phtoSize.ToString());
                list.SubItems.Add(bEnabled.ToString());
                list.SubItems.Add(base64String);
                lvFace.Items.Add(list);
            }
        }
        else
        {
            MessageBox.Show($"Failed to get face photo for User ID: {sUserID}, Photo Name: {phtoName}", "Error");
        }
    }

    axCZKEM1.EnableDevice(iMachineNumber, true);
    lvFace.EndUpdate();
    Cursor = Cursors.Default;
}


private void btnUploadFace_Click(object sender, EventArgs e)
{
    if (bIsConnected == false)
    {
        MessageBox.Show("Please connect the device first!", "Error");
        return;
    }

    int idwErrorCode = 0;
    string sUserID = "";
    string sName = "";
    int iFaceIndex = 0;
    string sTmpData = "";
    int iLength = 0;
    int iPrivilege = 0;
    string sPassword = "";
    bool bEnabled = false;
    string AIData = "0";
    Cursor = Cursors.WaitCursor;
    axCZKEM1.EnableDevice(iMachineNumber, false);

    for (int i = 0; i < lvFace.Items.Count; i++)
    {
        sUserID = lvFace.Items[i].SubItems[0].Text;
        sName = lvFace.Items[i].SubItems[1].Text;
        sPassword = lvFace.Items[i].SubItems[2].Text;
        iPrivilege = Convert.ToInt32(lvFace.Items[i].SubItems[3].Text);
        iFaceIndex = Convert.ToInt32(lvFace.Items[i].SubItems[4].Text);
        sTmpData = lvFace.Items[i].SubItems[5].Text;
        iLength = Convert.ToInt32(lvFace.Items[i].SubItems[6].Text);
        bEnabled = lvFace.Items[i].SubItems[7].Text == "true";

        // Log the current user details
        Console.WriteLine($"Uploading face data for UserID: {sUserID}, Name: {sName}, Privilege: {iPrivilege}");

        if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sUserID, sName, sPassword, iPrivilege, bEnabled)) // Face templates are part of users' information
        {
            AIData = lvFace.Items[i].SubItems[8].Text;
            byte[] buffer = Convert.FromBase64String(AIData);
            using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
            {
                memoryStream.Write(buffer, 0, buffer.Length);
                Image.FromStream(memoryStream, true).Save(AppDomain.CurrentDomain.BaseDirectory + "\\verify_biophoto_9_" + sUserID + ".jpg");
            }

            if (axCZKEM1.SendFile(1, AppDomain.CurrentDomain.BaseDirectory + "\\verify_biophoto_9_" + sUserID + ".jpg"))
            {
                // Attempt to set user face template
                if (!axCZKEM1.SetUserFaceStr(1, sUserID, 50, AIData, AIData.Length))
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show($"Failed to set user face template for UserID: {sUserID}. ErrorCode: {idwErrorCode}", "Error");
                }
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show($"Failed to send file for UserID: {sUserID}. ErrorCode: {idwErrorCode}", "Error");
            }
        }
        else
        {
            axCZKEM1.GetLastError(ref idwErrorCode);
            MessageBox.Show($"Failed to set user info for UserID: {sUserID}. ErrorCode: {idwErrorCode}", "Error");
        }
    }

    axCZKEM1.RefreshData(iMachineNumber); // The data in the device should be refreshed
    Cursor = Cursors.Default;
    axCZKEM1.EnableDevice(iMachineNumber, true);
    MessageBox.Show($"Successfully uploaded the face templates, total: {lvFace.Items.Count}", "Success");
}


        //add by Darcy on Nov.23 2009
        //Add the existed userid to DropDownLists.
        bool bAddControl = true;
        private void UserIDTimer_Tick(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                cbUserIDDE.Items.Clear();
             //   cbUserIDTmp.Items.Clear();
                bAddControl = true;
                return;
            }
            else
            {
                if (bAddControl == true)
                {
                    string sEnrollNumber = "";
                    string sName = "";
                    string sPassword = "";
                    int iPrivilege = 0;
                    bool bEnabled = false;

                    axCZKEM1.EnableDevice(iMachineNumber, false);
                    axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory
                    while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sEnrollNumber, out sName, out sPassword, out iPrivilege, out bEnabled))
                    {
                        cbUserIDDE.Items.Add(sEnrollNumber);
                    //    cbUserIDTmp.Items.Add(sEnrollNumber);
                    }
                    bAddControl = false;
                    axCZKEM1.EnableDevice(iMachineNumber, true);
                }
                return;
            }
        }
        #endregion

       
    }
}